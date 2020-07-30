using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment02
{
    public partial class frmDelivery : Form
    {
        public frmDelivery()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

            rboCollect.Checked = true;

            Globals.selected_delivery = "Collection";

            Globals.delivery_price = 0.0;

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            Globals.selected_delivery = "Collection";

            Globals.delivery_price = 0.0;

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Globals.selected_delivery = "London";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Globals.selected_delivery = "England";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            Globals.selected_delivery = "Wales";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            Globals.selected_delivery = "Scotland";
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            Globals.selected_delivery = "Northern Ireland";
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            frmUserDetails myForm = (frmUserDetails)Application.OpenForms["Form1"];

            myForm.Show();

            this.Close();
        }

        private void btnSelectWarranty_Click(object sender, EventArgs e)
        {
            Hide();

            Invoice copyOfForm6 = new Invoice();

            copyOfForm6.Show();
        }
    }
}
