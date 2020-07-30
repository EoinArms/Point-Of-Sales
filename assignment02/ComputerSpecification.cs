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
    public partial class frmComputerSpecification : Form
    {
        //Create Object to retain name of Form 
        //which opened a copy of Form2
        Form opener;


        public frmComputerSpecification(Form parentForm)
        {
            InitializeComponent();
            opener = parentForm;

        }

         private void Form3_Load(object sender, EventArgs e)
        {
           
            //Device Options Variables Default Settings
            //Hard Disc
            rbo750GB.Checked = true;
            Globals.selected_harddisc = "750GB";
            Globals.harddisc_price = 35.00;

            //Graphics Adapter
            rbo2GB.Checked = true;
            Globals.selected_graphicsadapter = "2.0GB";
            Globals.graphicsadapter_price = 80.00;

            //Reset Device Type to No Device Selected
            rboLaptop.Checked = false;
            rboPC50.Checked = false;
            rboPC60.Checked = false;

            rboIncluded.Checked = true;
            Globals.selected_warranty = "1Yr Collect & Returns Warranty ";
            Globals.warranty_price = 0.0;

        }


        private void btnSelectWarranty_Click(object sender, EventArgs e)
        {
            Form frm = new frmDelivery();
            frm.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                        
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Globals.selected_device = "Laptop";
            Globals.device_price = 430.00;

            label1.Text = Globals.selected_device;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Globals.selected_device = "PC50";
            Globals.device_price = 475.00;

            label1.Text = Globals.selected_device;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            Globals.selected_device = "PC60";
            Globals.device_price = 700.00;

            label1.Text = Globals.selected_device;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

            Globals.selected_harddisc = "750GB";
            Globals.harddisc_price = 35.00;

            label2.Text = Globals.harddisc_price.ToString();
        }


        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            Globals.selected_harddisc = "1.0TB";
            Globals.harddisc_price = 55.00;

            label2.Text = Globals.harddisc_price.ToString();
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {

            Globals.selected_graphicsadapter = "4.0GB";
            Globals.graphicsadapter_price = 110.00;

            label3.Text = Globals.selected_graphicsadapter;
        }


        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            Globals.selected_graphicsadapter = "2.0GB";
            Globals.graphicsadapter_price = 80.00;

            label3.Text = Globals.selected_graphicsadapter;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            //This says what the form is about
            MessageBox.Show("This form shows the name of ther computers that can be selected " +
                "along with the possible upgrades that are available for each of the three different " +
                "types of Computers.");
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void rboIncluded_CheckedChanged(object sender, EventArgs e)
        {
            Globals.selected_warranty = "1Yr Collect & Returns Warranty ";
            Globals.warranty_price = 0.0;
        }

        private void rboHardwareSupport_CheckedChanged(object sender, EventArgs e)
        {
            Globals.selected_warranty = "1Yr Next Day Hardware Support ";
            Globals.warranty_price = 45.0;
        }

        private void rboInHome_CheckedChanged(object sender, EventArgs e)
        {
            Globals.selected_warranty = "1 Year Next Day In-Home Service with Premium Phone Support ";
            Globals.warranty_price = 75.0;
        }

        private void rbo3Years_CheckedChanged(object sender, EventArgs e)
        {
            Globals.selected_warranty = "3 Years Next Day In-Home Service with Premium Phone Support  ";
            Globals.warranty_price = 145.0;
        }
    }
}
