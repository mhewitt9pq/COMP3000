using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace secPass
{
    public partial class frmLogin : Form
    {
        public static string LoginName;
        public static string LoginPassword;
        public frmLogin()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Gets user inputs and stores them
        /// </summary>
        public void getCred()
        {
            LoginName = txtLoginUserName.Text;
            LoginPassword = txtLoginMastP.Text;
        }

        /// <summary>
        /// Shows user help
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblLoginHelp_MouseMove(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(lblLoginHelp, "If you havent logged in previously, please enter a username and master password to identify yourself and encrypt your credentials. You are unable to access or decrypt your data without this information");
        }

        /// <summary>
        /// Login button opens new form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool empty = false;

            if (String.IsNullOrWhiteSpace(txtLoginUserName.Text) || String.IsNullOrWhiteSpace(txtLoginMastP.Text))
            {
                empty = true;
            }

            if (empty == true)
            {
                MessageBox.Show("All fields must be filled. Please enter a username and masterpassword", "Alert");

            }
            else if (empty == false)
            {
                getCred();
                this.Hide();
                Dash frm = new Dash();
                frm.Show();
            }
        }

        /// <summary>
        /// Closes login
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}