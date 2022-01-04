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
            if (String.IsNullOrWhiteSpace(passName) ||
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
                string pass = obj_aes.encrypt(txtPass.Text, txtMasterPass.Text);                

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
            }
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
            //lblDecrypted.Text = obj_aes.decrypt(lblEncryptedPass.Text);
        }

        /// <summary>
        /// Reads the csv and populates datagrid with data and stores data in array
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
    }
}