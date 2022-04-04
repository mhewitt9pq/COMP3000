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
    public partial class RetrievePassword : UserControl
    {
        public RetrievePassword()
        {
            InitializeComponent();
            obj_aes = new secController();
        }
        secController obj_aes;
        
        private void btnDisplay_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtUpdateMastP.Text))
            {
                MessageBox.Show("Master password must be entered to display credentials");
                return;
            }
            else
            {
                txtUpdateName.Text = dgvCreds.CurrentRow.Cells[0].Value.ToString();

                //txtUpdatePass.Text = dgvCreds.CurrentRow.Cells[1].Value.ToString();

                string updateMastPass = txtUpdateMastP.Text;

                string encPass = dgvCreds.CurrentRow.Cells[1].Value.ToString();

                string plainTxtPass = obj_aes.decrypt(updateMastPass, encPass);

                if (String.IsNullOrWhiteSpace(plainTxtPass))
                {
                    string message = "Decryption failed, pelase ensure the master password is correct!";
                    string title = "Attention!";
                    MessageBox.Show(message, title);
                }
                else
                {
                    txtUpdatePass.Text = plainTxtPass;
                }
                
            }            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtUpdateName.Text) ||
                String.IsNullOrWhiteSpace(txtUpdatePass.Text) ||
                String.IsNullOrWhiteSpace(txtUpdateConfPass.Text))
            {
                MessageBox.Show("All fields must be filled. Please enter a name and your password", "Alert");
                return;
            }
            if (txtUpdatePass.Text != txtUpdateConfPass.Text)
            {
                MessageBox.Show("Both passwords must match. Please re enter your password");
                return;
            }
            else if (txtUpdatePass.Text == txtUpdateConfPass.Text)
            {
                string mastPass = txtUpdateMastP.Text;
                string plainTxtNewPass = txtUpdateConfPass.Text;
                string cryptPass = obj_aes.encrypt(mastPass, plainTxtNewPass);

                Dash.credList[rowIndex].Account = txtUpdateName.Text;
                Dash.credList[rowIndex].Password = cryptPass;

                txtUpdatePass.Clear();
                txtUpdateName.Clear();
                txtUpdateConfPass.Clear();

                StorePassword.SaveToCsv(Dash.credList);
                updateData();
                dgvCreds.Refresh();
            }            
        }

        public void updateData()
        {
            var custDataSource = Dash.credList.Select(x => new
            {
                Account = x.Account,
                Password = x.Password,
            }).ToList();

            //This will assign the datasource. All the columns you listed will show up, and every row
            //of data in the list will populate into the DataGridView.

            credentialBindingSource.DataSource = custDataSource;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string tAcc = "";
            string message = "You must select a record before you attempt to delete it.";
            string title = "Attention!";


            try
            {
                if (dgvCreds.Rows[rowIndex].Cells[0].Value != null)
                {
                    try
                    {
                        tAcc = dgvCreds.Rows[rowIndex].Cells[0].Value.ToString();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show(message, title);
                    }
                }
            }
            catch (Exception)
            {

                MessageBox.Show(message, title);
            }
            //Add password so wont give error if have two acc names the same
            var c = Dash.credList.SingleOrDefault(x => x.Account == tAcc);

            if (c != null)
            {
                Dash.credList.Remove(c);
            }               

            StorePassword.SaveToCsv(Dash.credList);
            updateData();
            dgvCreds.Refresh();
        }



        int rowIndex = 0;
        int oldRowIndex;
        private void dvgCreds_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            oldRowIndex = rowIndex;

            rowIndex = e.RowIndex;
            

            if (rowIndex != oldRowIndex)
            {
                txtUpdateName.Clear();
                txtUpdatePass.Clear();
                txtUpdateConfPass.Clear();
            }

        }


        /*public void setData(List<Credential> source)
        {
            credentialBindingSource.DataSource = source;
        }

        public void cListToDataGrid()
        {

            var custDataSource = Dash.credList.Select(x => new
            {
                Account = x.Account,
                Password = x.Password,
            }).ToList();

            //This will assign the datasource. All the columns you listed will show up, and every row
            //of data in the list will populate into the DataGridView.
            
            credentialBindingSource.DataSource = custDataSource;
        }  */
    }
}