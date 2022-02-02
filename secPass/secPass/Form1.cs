using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;
using CsvHelper;
using CsvHelper.Configuration;
using CsvHelper.Configuration.Attributes;
using System.Globalization;


namespace secPass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            obj_aes = new secController();
        }
        secController obj_aes;

        static List<Credential> credList = new List<Credential>();

        private void Form1_Load(object sender, EventArgs e)
        {
            string filename = createFile();
            credList = csvToList();
        }

        /// <summary>
        /// Creates File with column names and returns file name
        /// </summary>
        /// <returns>File name</returns>
        private string createFile()
        {
            string fileName = "csvDB.csv";
            StringBuilder csvContent = new StringBuilder();
            csvContent.AppendLine("Account,Password");           
            
            if  (!File.Exists(fileName))
            {
                File.AppendAllText(fileName, csvContent.ToString());
            }
            return fileName;
        }
                
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string passName = txtName.Text;

            //Validation
            if (String.IsNullOrWhiteSpace(txtName.Text) ||
                String.IsNullOrWhiteSpace(txtPass.Text) ||
                String.IsNullOrWhiteSpace(txtConfPass.Text) ||
                String.IsNullOrWhiteSpace(txtMasterPass.Text))
            {
                MessageBox.Show("All fields must be filled. Please enter a name and your password");
                return;
            }
            if (txtPass.Text != txtConfPass.Text)
            {
                MessageBox.Show("Both passwords must match. Please re enter your password");
                return;
            }
            else if (txtPass.Text == txtConfPass.Text)
            {
                string pass = obj_aes.encrypt(txtMasterPass.Text, txtPass.Text);                

                Credential tempCred = new Credential(passName + "," + pass);

                credList.Add(tempCred);

                var custDataSource = credList.Select(x => new
                {
                    Account = x.Account,
                    Password = x.Password,
                }).ToList();

                //This will assign the datasource. All the columns you listed will show up, and every row
                //of data in the list will populate into the DataGridView.
                credentialBindingSource.DataSource = custDataSource;

                MessageBox.Show(string.Format("Thank you for storing {0}", tempCred.Account));

                lblEncryptedPass.Text = tempCred.Password;
            }
        }


        /// <summary>
        /// Takes object list and converts to csv string and saves to csv file
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="credData"></param>
        private void SaveToCsv<T>(List<T> credData)
        {
            string path = "csvDB.csv";
            var lines = new List<string>();
            IEnumerable<PropertyDescriptor> props = TypeDescriptor.GetProperties(typeof(T)).OfType<PropertyDescriptor>();
            var header = string.Join(",", props.ToList().Select(x => x.Name));
            lines.Add(header);
            var valueLines = credData.Select(row => string.Join(",", header.Split(',').Select(a => row.GetType().GetProperty(a).GetValue(row, null))));
            lines.AddRange(valueLines);
            File.WriteAllLines(path, lines.ToArray());
        }

        /// <summary>
        /// Button click calls savetocsv function
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveToCsv(credList);
        }


        /// <summary>
        /// Alert if caps lock is on
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            if (Control.IsKeyLocked(Keys.CapsLock))
            {
                MessageBox.Show("The Caps Lock key is ON.");
            }
        }

        /// <summary>
        /// Decrypts ciphertext
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            lblDecrypted.Text = obj_aes.decrypt(txtMasterPass.Text, lblEncryptedPass.Text);
        }

        /// <summary>
        /// Reads the csv and populates datagrid with data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGetPass_Click(object sender, EventArgs e)
        {
            //getDataToString();
            
            using (var reader = new StreamReader("csvDB.csv"))
            {
                using (var csvReader = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    csvReader.Context.RegisterClassMap<CredClassMap>();

                    //Populates datagridview using bindingsource
                    credentialBindingSource.DataSource = csvReader.GetRecords<Credential>();                    
                }
            }
            /*var sr = new StreamReader(new FileStream("file\\csvDB.csv", FileMode.Open));
            var csv = new CsvReader(sr);
            studentBindingSource.DataSource = csv.GetRecords<Student>();
            sr.Close();*/
        }

        /// <summary>
        /// Reads the data from the csv and converts into list of objects and returns the list
        /// </summary>
        /// <returns></returns>
        public List<Credential> csvToList()
        {
            string delimiter = ",";
            string fileName = "csvDB.csv";

            string[] csvLines = System.IO.File.ReadAllLines(fileName);

            for (int i = 1; i < csvLines.Length; i++)
            {
                Credential tCred = new Credential(csvLines[i]);
                credList.Add(tCred);
            }

            //Creates list of accounts
            var accounts = new List<string>();

            for (int i = 1; i < csvLines.Length; i++)
            {
                string[] rowData = csvLines[i].Split(delimiter.ToCharArray());
                accounts.Add(rowData[0]);
            }
            //Returns a list of the accounts held
            //return accounts;
            return credList;
        }
         
        /// <summary>
        /// Maps the input data to the properties of the credentials object
        /// </summary>
        public class CredClassMap : ClassMap<Credential>
        {
            public CredClassMap()
            {
                Map(m => m.Account).Name("Account");
                Map(m => m.Password).Name("Password");
            }
        }

        int rowIndex;

        /// <summary>
        /// Sets the cell index
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgCreds_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowIndex = e.RowIndex;
        }        

        /// <summary>
        /// Gets data from selected row, decrypts the password and populated the text boxes appropriately 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdateDisplayData_Click_1(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtUpdateMastPass.Text))
            {
                MessageBox.Show("Master password must be entered to display credentials");
                return;             
            }
            if (txtUpdatePass.Text != txtUpdateConfPass.Text)
            {
                MessageBox.Show("Both passwords must match. Please re enter your passwords");
                return;
            }
            else if (txtUpdatePass.Text == txtUpdateConfPass.Text)
            {
                try
                {
                    txtUpdateName.Text = dgCreds.CurrentRow.Cells[0].Value.ToString();
                    txtUpdatePass.Text = dgCreds.CurrentRow.Cells[1].Value.ToString();
                    string updateMastPass = txtUpdateMastPass.Text;
                    string encPass = txtUpdatePass.Text;
                    string plainTxtPass = obj_aes.decrypt(updateMastPass, encPass);
                    txtUpdatePass.Text = plainTxtPass;
                }
                catch (Exception)
                {
                    return;
                }
            }
        }

        /// <summary>
        /// Saves any modifications to csv file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            DataGridViewRow newDataRow = dgCreds.Rows[rowIndex];

            string mastPass = txtUpdateMastPass.Text;
            string plainTxtNewPass = txtUpdateConfPass.Text;
            string cryptPass = obj_aes.encrypt(mastPass, plainTxtNewPass);
            newDataRow.Cells[0].Value = txtUpdateName.Text;

            dgCreds.Rows[rowIndex].Cells[1].Value = cryptPass;

            //Credential obj = (Credential)dgCreds.CurrentRow.DataBoundItem;
            //obj.Password = cryptPass;
            //obj.Account = txtUpdateName.Text;

            //dgCreds.CurrentRow.DataBoundItem = obj;
            //obj.MyProperty = newValue;
            //string t = credentialBindingSource.List[0]
            dgCreds.Refresh();
            txtUpdatePass.Clear();
            txtUpdateMastPass.Clear();
            txtUpdateName.Clear();
            txtUpdateConfPass.Clear();
            dgToCsv();
        }

        /// <summary>
        /// Reads and formats data in datagridview to csv format and writes to file
        /// </summary>
        void dgToCsv()
        {
            StreamWriter dgCsv = new StreamWriter("csvDB.csv");
            dgCsv.WriteLine("Account,Password");
            for (int i = 0; i < dgCreds.Rows.Count; i++)
            {
                String Name = dgCreds.Rows[i].Cells[0].Value?.ToString();
                String Password = dgCreds.Rows[i].Cells[1].Value?.ToString();
                dgCsv.WriteLine(Name + "," + Password);
            }
            dgCsv.Close();
        }

        /// <summary>
        /// Generates strong random password
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGeneratePass_Click(object sender, EventArgs e)
        {
            int passLengthMin = 12;
            int passLengthMax = 16;
            StringBuilder randPass = new StringBuilder();
            const string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789.,!/?@#;:-=+";

            Random r = new Random();

            int passLength = r.Next(passLengthMin, passLengthMax);

            for (int i = 0; i < passLength; i++)
            {
                randPass.Append(chars[r.Next(chars.Length)]);
            }

            lblRandPass.Text = randPass.ToString();
        }

        /// <summary>
        /// Copies generated password to clipboard
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(lblRandPass.Text);

            MessageBox.Show("Password copied to clipboard!");
        }
    }
}