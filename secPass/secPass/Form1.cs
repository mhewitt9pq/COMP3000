﻿using System;
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


namespace secPass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            obj_aes = new Aes();
        }
        Aes obj_aes;

        private void Form1_Load(object sender, EventArgs e)
        {

            

        }



        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //Storing variables - Pass is stored in plaintext until encryption is implemented
            string passName = txtName.Text;
            string pass = txtPass.Text;
            string confPass = txtConfPass.Text;

            //Validation
            if (String.IsNullOrWhiteSpace(passName) ||
                String.IsNullOrWhiteSpace(pass) ||
                String.IsNullOrWhiteSpace(confPass))
            {
                MessageBox.Show("All fields must be filled. Please enter a name and your password");
                return;
            }
            if (pass != confPass)
            {
                MessageBox.Show("Both passwords must match. Please re enter your password");
                return;
            }

            Credential newCredential = new Credential(passName, pass);


            MessageBox.Show(newCredential.ToString());

            lblEncryptedPass.Text = obj_aes.encrypt(txtPass.Text);


        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            if (Control.IsKeyLocked(Keys.CapsLock))
            {
                MessageBox.Show("The Caps Lock key is ON.");
            }
        }

    }
}
