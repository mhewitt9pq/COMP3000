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

namespace secPass.UserControls
{
    public partial class StorePassword : UserControl
    {
        public StorePassword()
        {
            InitializeComponent();
            obj_aes = new secController();
        }
        secController obj_aes;


        private void btnSave_Click(object sender, EventArgs e)
        {
            bool store = false;
            string passName = txtName.Text;

            //Validation
            if (String.IsNullOrWhiteSpace(txtName.Text) ||
                String.IsNullOrWhiteSpace(txtPass.Text) ||
                String.IsNullOrWhiteSpace(txtConfPass.Text) ||
                String.IsNullOrWhiteSpace(txtMastPass.Text))
            {
                MessageBox.Show("All fields must be filled. Please enter a name and your password", "Alert");
                return;
            }
            if (txtPass.Text != txtConfPass.Text)
            {
                MessageBox.Show("Both passwords must match. Please re enter your password");
                return;
            }
            else if (txtPass.Text == txtConfPass.Text)
            {
                int passStrength = strengthCheck(txtPass.Text);
                if (passStrength < 5)
                {
                    string tRandPass = GenPass.generatePass();
                    string message = "Our algorithm has detected that the entered password could be stronger. A stronger password could be: " + tRandPass +
                        ". Would you like to copy this password to your clipboard?";
                    string title = "Warning";

                    if (MessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    //If user selects yes
                    {
                        copyToClip(tRandPass);

                    }
                    //If user selects no
                    else
                    {
                        string areYouSureMessage = "Do you want to store this credential anyway";
                        string areYouSureTitle = "Are you sure?";
                        if (MessageBox.Show(areYouSureMessage, areYouSureTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        //If user selects yes. Stores credentials
                        {
                            store = true;
                        }
                        //If user selects no
                        else
                        {
                            return;
                        }
                    }
                }
                else if (passStrength > 4)
                {
                    string areYouSureM = "Are you sure you want to store this credential?";
                    string areYouSureT = "Are you sure?";
                    if (MessageBox.Show(areYouSureM, areYouSureT, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    //If user selects yes. Stores credentials
                    {
                        store = true;
                    }
                    //If user selects no
                    else
                    {
                        return;
                    }
                }
                if (store == true)
                {
                    encryptSave(txtMastPass.Text, txtPass.Text, passName);
                }
                else
                {
                    return;
                }
            }
        }

        public void encryptSave(string mastP, string Pass, string name)
        {
            string pass = obj_aes.encrypt(mastP, Pass);

            Credential tempCred = new Credential(name + "," + pass);
            Dash.credList.Add(tempCred);
            //Dash.cListToDataGrid();
            string thankMessage = "Thank you for storing your " + txtName.Text.ToString() + " credentials.";
            string thankTitle = "Credential stored";
            SaveToCsv(Dash.credList);
            MessageBox.Show(thankMessage, thankTitle);

            //Clear the textboxes
            txtName.Clear();
            txtPass.Clear();
            txtConfPass.Clear();
        }

        public static void SaveToCsv<T>(List<T> credData)
        {
            string path = Dash.fileName;
            var lines = new List<string>();
            IEnumerable<PropertyDescriptor> props = TypeDescriptor.GetProperties(typeof(T)).OfType<PropertyDescriptor>();
            var header = string.Join(",", props.ToList().Select(x => x.Name));
            lines.Add(header);
            var valueLines = credData.Select(row => string.Join(",", header.Split(',').Select(a => row.GetType().GetProperty(a).GetValue(row, null))));
            lines.AddRange(valueLines);
            File.WriteAllLines(path, lines.ToArray());
        }

        public static int strengthCheck(string pass)
        {
            //Very weak = 1
            //Weak = 2
            //Medium = 3
            //Strong = 4
            //Very strong = 5
            //Ideal strength = 6
            int strengthScore = 0;
            bool hasUpperCase;
            bool hasLowerCase;
            bool hasNumber;
            bool hasSpecial;
            hasUpperCase = hasUpper(pass);
            hasLowerCase = hasLower(pass);
            hasNumber = hasDigit(pass);
            hasSpecial = hasSpecialChar(pass);

            //Checks length and inclusion of uppercase/lowercase letters, numbers or special characters
            if (pass.Length > 6)
            {
                strengthScore++;
            }
            if (pass.Length > 12)
            {
                strengthScore++;
            }
            if (hasUpperCase == true)
            {
                strengthScore++;
            }
            if (hasLowerCase == true)
            {
                strengthScore++;
            }
            if (hasNumber == true)
            {
                strengthScore++;
            }
            if (hasSpecial == true)
            {
                strengthScore++;
            }
            return strengthScore;
        }

        /// <summary>
        /// Returns true if password contains an upper case letter
        /// </summary>
        /// <param name="pass"></param>
        /// <returns></returns>
        public static bool hasUpper(string pass)
        {
            return pass.Any(c => char.IsUpper(c));
        }

        /// <summary>
        /// Returns true if password contains a lower case letter
        /// </summary>
        /// <param name="pass"></param>
        /// <returns></returns>
        public static bool hasLower(string pass)
        {
            return pass.Any(c => char.IsLower(c));
        }

        /// <summary>
        /// Returns true if password includes at least 1 number
        /// </summary>
        /// <param name="pass"></param>
        /// <returns></returns>
        public static bool hasDigit(string pass)
        {
            return pass.Any(c => char.IsDigit(c));
        }

        /// <summary>
        /// Returns true if password contains special char
        /// </summary>
        /// <param name="pass"></param>
        /// <returns></returns>
        public static bool hasSpecialChar(string pass)
        {
            return pass.Any(c => char.IsSymbol(c) || char.IsPunctuation(c));
        }

        /// <summary>
        /// Copies input text to clipboard
        /// </summary>
        /// <param name="text"></param>
        public void copyToClip(string text)
        {
            string cText = text;
            Clipboard.SetText(cText);
            MessageBox.Show("Password copied to clipboard!", "Attention");

        }
    }
}
