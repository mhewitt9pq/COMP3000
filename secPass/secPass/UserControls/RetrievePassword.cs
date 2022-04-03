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
        }

        private void RetrievePassword_Load(object sender, EventArgs e)
        {
            cListToDataGrid();
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
        }

        
    }
}