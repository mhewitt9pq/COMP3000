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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            getCred();
            this.Hide();
            Form1 frm = new Form1();
            frm.Show();
        }

        public void getCred()
        {
            LoginName = txtUsername.Text;
            LoginPassword = txtMastP.Text;
        }
    }
}