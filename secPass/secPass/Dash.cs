using secPass.UserControls;
using Siticone.Desktop.UI.WinForms;
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
    public partial class Dash : Form
    {
        public Dash()
        {
            InitializeComponent();

            new SiticoneShadowForm(this);
            new SiticoneDragControl(this);

            //panelSlider.Controls.Add(new Home());
            panelSlider.Controls.Add(new Home());
            panelSlider.Controls.Add(new StorePassword());
            panelSlider.Controls.Add(new RetrievePassword());
            panelSlider.Controls.Add(new GenPass());
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            panelSlider.Controls.Find("Home", false)[0].BringToFront();
        }

        private void btnStoreP_Click(object sender, EventArgs e)
        {
            panelSlider.Controls.Find("StorePassword", false)[0].BringToFront();
        }

        private void btnGetPass_Click(object sender, EventArgs e)
        {
            panelSlider.Controls.Find("RetrievePassword", false)[0].BringToFront();
        }

        private void btnGenPass_Click(object sender, EventArgs e)
        {
            panelSlider.Controls.Find("GenPass", false)[0].BringToFront();
        }
    }
}
