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

        private void Form1_Load(object sender, EventArgs e)
        {
            string filename = createFile();

            //openFile(fileName);
        }

        /// <summary>
        /// Creates File with column names and returns file name
        /// </summary>
        /// <returns>File name</returns>
        private string createFile()
        {
            string fileName = "csvDB.csv";
            StringBuilder csvContent = new StringBuilder();
            csvContent.AppendLine("Account,Encrypted Credential");            
            if  (!File.Exists(fileName))
            {
                File.AppendAllText(fileName, csvContent.ToString());

            }
            return fileName;
        }

        /*public void openFile(string fileName)
        {
            //OpenFileDialog ofd = new OpenFileDialog();
            //ofd.ShowDialog();

            Credential creds = new Credential();

            string[] CredentialArray;

            DataTable dt = new DataTable();
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Credential", typeof(string));

            using (StreamReader sr = new StreamReader(fileName))
            {
                while(!sr.EndOfStream)
                {
                    CredentialArray = sr.ReadLine().Split(',');

                    creds.passName = CredentialArray[0];
                    creds.pass = CredentialArray[1];

                    dt.Rows.Add(CredentialArray);
                }
                DataView dv = new DataView(dt);
                dgCreds.DataSource = dv;
            }
        }*/
        

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string passName = txtName.Text;

            //Validation
            if (String.IsNullOrWhiteSpace(passName) ||
                String.IsNullOrWhiteSpace(txtPass.Text) ||
                String.IsNullOrWhiteSpace(txtConfPass.Text))
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
                //Credential newCredential = new Credential(passName, pass);
                lblEncryptedPass.Text = pass;
                //MessageBox.Show("Thank you for storing ", newCredential.passName);
            }
        }

        /*public void ReadCSV(string filename)
        {
            try
            {
                // your code here 
                string CSVFilePathName = filename;
                string[] Lines = File.ReadAllLines(CSVFilePathName);
                string[] Fields;
                Fields = Lines[0].Split(new char[] { ',' });
                int Cols = Fields.GetLength(0);
                DataTable dt = new DataTable();
                //1st row must be column names; force lower case to ensure matching later on.
                for (int i = 0; i < Cols; i++)
                    dt.Columns.Add(Fields[i].ToLower(), typeof(string));
                DataRow Row;
                for (int i = 1; i < Lines.GetLength(0); i++)
                {
                    Fields = Lines[i].Split(new char[] { ',' });
                    Row = dt.NewRow();
                    for (int f = 0; f < Cols; f++)
                        Row[f] = Fields[f];
                    dt.Rows.Add(Row);
                }
                dgCreds.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error is " + ex.ToString());
                throw;
            }
        }*/
        



        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            if (Control.IsKeyLocked(Keys.CapsLock))
            {
                MessageBox.Show("The Caps Lock key is ON.");
            }
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            //lblDecrypted.Text = obj_aes.decrypt(lblEncryptedPass.Text);
        }

        private void btnGetPass_Click(object sender, EventArgs e)
        {
            using (var streamReader = new StreamReader("csvDB.csv"))
            {
                using (var csvReader = new CsvReader(streamReader, CultureInfo.InvariantCulture))
                {
                    csvReader.Context.RegisterClassMap<CredClassMap>();
                    var credList = csvReader.GetRecords<Credential>().ToList();
                    dgCreds.DataSource = credList;
                }
            }

            /*var sr = new StreamReader(new FileStream("file\\csvDB.csv", FileMode.Open));
            var csv = new CsvReader(sr);
            studentBindingSource.DataSource = csv.GetRecords<Student>();
            sr.Close();*/
        }

        public class CredClassMap : ClassMap<Credential>
        {
            public CredClassMap()
            {
                Map(m => m.Account).Name("Account");
                Map(m => m.Password).Name("Encrypted Credential");
            }
        }

    }
}