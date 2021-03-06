using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace secPass.UserControls
{
    public partial class GenPass : UserControl
    {
        public GenPass()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Calls generate pass and displays it 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGenPass_Click(object sender, EventArgs e)
        {
            string randomPass = "";
            randomPass = generatePass();
            lblRandPass.Text = randomPass;
        }

        /// <summary>
        /// Generates strong password
        /// </summary>
        /// <returns></returns>
        public static string generatePass()
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
            return randPass.ToString();
        }
        
        /// <summary>
        /// Copies generated password to clipboard
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(lblRandPass.Text);
            MessageBox.Show("Password copied to clipboard!", "Attention");
        }
    }
}