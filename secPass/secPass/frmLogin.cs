﻿using System;
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
        /// Stores user inputs
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOk_Click(object sender, EventArgs e)
        {
            bool empty = false;

            if (String.IsNullOrWhiteSpace(txtUsername.Text) || String.IsNullOrWhiteSpace(txtMastP.Text))
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
                Form1 frm = new Form1();
                frm.Show();
            }            
        }

        /// <summary>
        /// Gets user inputs and stores them
        /// </summary>
        public void getCred()
        {
            LoginName = txtUsername.Text;
            LoginPassword = txtMastP.Text;
        }

        /// <summary>
        /// Closes application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}