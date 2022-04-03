using secPass.UserControls;
using Siticone.Desktop.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace secPass
{
    public partial class Dash : Form
    {
        string usrName;
        string usrMastPass;
        public static string  fileName;

        public Dash()
        {
            InitializeComponent();

            new SiticoneShadowForm(this);
            obj_aes = new secController();
        }

        secController obj_aes;
        static public  List<Credential> credList = new List<Credential>();

        private void Dash_Load(object sender, EventArgs e)
        {
            usrName = frmLogin.LoginName;
            usrMastPass = frmLogin.LoginPassword;

            fileName = createFile();

            credList = csvToList();
        }

        private string createFile()
        {
            //Take in generated filename
            string name = calcHash(usrName, usrMastPass);

            string fileName = name + ".csv";

            StringBuilder csvContent = new StringBuilder();
            csvContent.AppendLine("Account,Password");

            if (!File.Exists(fileName))
            {
                File.AppendAllText(fileName, csvContent.ToString());
            }

            return fileName;
        }

        public string calcHash(string u, string p)
        {
            //Hashes both strings seperatley, merges them both together, 
            //and then hashes the combination to get the final hash value
            string hup = obj_aes.hash(u) + obj_aes.hash(p);
            string hashed = obj_aes.hash(hup);

            return hashed;
        }

        public List<Credential> csvToList()
        {
            string delimiter = ",";

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


















        private void btnHome_CheckedChanged(object sender, EventArgs e)
        {
            if (btnHome.Checked)
            {
                home1.BringToFront();
            }
        }

        private void btnStoreP_CheckedChanged(object sender, EventArgs e)
        {
            if (btnStoreP.Checked)
            {
                storePassword1.BringToFront();
            }
        }

        private void btnGetPass_CheckedChanged(object sender, EventArgs e)
        {
            if (btnGetPass.Checked)
            {
                retrievePassword1.BringToFront();
            }
        }

        private void btnGenPass_CheckedChanged(object sender, EventArgs e)
        {
            if (btnGenPass.Checked)
            {
                genPass1.BringToFront();
            }
        }

        
    }
}