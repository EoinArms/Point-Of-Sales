using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using System.Drawing.Printing;

namespace assignment02
{
    public partial class Invoice : Form
    {

        Bitmap memoryImage;
        
        public Invoice()
        {
            InitializeComponent();
                   
        }

        private void CaptureScreen()
        {
            Graphics myGraphics = this.CreateGraphics();

            Size s = this.Size;

            memoryImage = 
                new Bitmap(s.Width, s.Height, myGraphics);

            Graphics memoryGraphics = 
                Graphics.FromImage(memoryImage);

            memoryGraphics.CopyFromScreen
                (this.Location.X, this.Location.Y, 0, 0, s);

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            //Populate Screen with captured Customer details
            txtForename.Text = Globals.Forename ;
            txtSurname.Text = Globals.Surname ;
            txtHouseNo.Text = Globals.HouseNo ;
            txtAddress.Text = Globals.Address ;
            txtTown_City.Text = Globals.Town_City ;
            txtCounty.Text = Globals.County ;
            txtPostcode.Text = Globals.Postcode ;
            txtMobile.Text = Globals.Mobile ;
            txtEmail.Text = Globals.Email ;

            //Populate Screen with captured Device details
            txtType.Text = Globals.selected_device;
            txtHD.Text = Globals.selected_harddisc;
            txtGraphics.Text = Globals.selected_graphicsadapter;
            txtWarranty.Text = Globals.selected_warranty;
            txtOption.Text = Globals.selected_delivery;
            //textbox16 populate
            switch (Globals.selected_device )
            {
                case "Laptop":
                    txtInfo .Text = "This is a description of the Laptop";
                    break;
                case "PC50":
                    txtInfo.Text = "This is a description of PC50";
                    break;
                 case "PC60":
                    txtInfo.Text = "This is a description of PC60";
                    break;
                default:
                    txtInfo.Text = "Error! Please Check Program!!!";
                    break;
                
            }

            txtTypeCost.Text = Convert.ToString (Globals.device_price);
            txtHDCost.Text = Convert.ToString(Globals.harddisc_price);
            txtGraphicsCost.Text = Convert.ToString(Globals.graphicsadapter_price);
            txtWarrantyCost.Text = Globals.warranty_price.ToString ();
            txtDelivery_Cost.Text = Globals.delivery_price.ToString();
            
            //Nett price
            double subTotal = Globals.device_price 
                            + Globals.harddisc_price 
                            + Globals.graphicsadapter_price 
                            + Globals.warranty_price
                            + Globals.delivery_price;

            txtCost.Text = Convert.ToString(subTotal);
            
            //VAT @ 20%
            double VAT = ((subTotal)*0.2);
            txtVat.Text = Convert.ToString(VAT);

            //Total Inc VAT
            double totalPrice = (subTotal + VAT);
            txtTotal.Text = Convert.ToString(totalPrice);

        }


        private void btnPrint_Click(object sender, EventArgs e)
        {
            CaptureScreen();
            
            try
            {

                printDocument1.Print();
            }
            catch (Exception ex)
            {
                throw ex;//nothing really
            }
            
        }
        
        private void printDocument1_PrintPage
            (object sender, PrintPageEventArgs e)
        {
            try
            {
                e.Graphics.DrawImage(memoryImage, 0, 0);
            }
            catch (Exception ex)
            {
                //Here you can add code which will execute if an unexpecetd error (ex) occurs
                MessageBox.Show(ex.ToString());

            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            txtForename.Enabled = false;
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {
            txtInfo.Enabled = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you would like to Exit the Form?", "Question", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit(); //this closes the form
            }
        }

        private void txtSurname_TextChanged(object sender, EventArgs e)
        {
            txtSurname.Enabled = false;
        }

        private void txtHouseNo_TextChanged(object sender, EventArgs e)
        {
            txtHouseNo.Enabled = false;
        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {
            txtAddress.Enabled = false;
        }

        private void txtTown_City_TextChanged(object sender, EventArgs e)
        {
            txtTown_City.Enabled = false;
        }

        private void txtCounty_TextChanged(object sender, EventArgs e)
        {
            txtCounty.Enabled = false;
        }

        private void txtPostcode_TextChanged(object sender, EventArgs e)
        {
            txtPostcode.Enabled = false;
        }

        private void txtMobile_TextChanged(object sender, EventArgs e)
        {
            txtMobile.Enabled = false;
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            txtEmail.Enabled = false;
        }

        private void txtType_TextChanged(object sender, EventArgs e)
        {
            txtType.Enabled = false;
        }

        private void txtHD_TextChanged(object sender, EventArgs e)
        {
            txtHD.Enabled = false;
        }

        private void txtTypeCost_TextChanged(object sender, EventArgs e)
        {
            txtTypeCost.Enabled = false;
        }

        private void txtHDCost_TextChanged(object sender, EventArgs e)
        {
            txtHDCost.Enabled = false;
        }

        private void txtGraphics_TextChanged(object sender, EventArgs e)
        {
            txtGraphics.Enabled = false;
        }

        private void txtGraphicsCost_TextChanged(object sender, EventArgs e)
        {
            txtGraphicsCost.Enabled = false;
        }

        private void txtWarranty_TextChanged(object sender, EventArgs e)
        {
            txtWarranty.Enabled = false;
        }

        private void txtWarrantyCost_TextChanged(object sender, EventArgs e)
        {
            txtWarrantyCost.Enabled = false;
        }

        private void txtCost_TextChanged(object sender, EventArgs e)
        {
            txtCost.Enabled = false;
        }

        private void txtVat_TextChanged(object sender, EventArgs e)
        {
            txtVat.Enabled = false;
        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {
            txtTotal.Enabled = false;
        }

        private void txtOption_TextChanged(object sender, EventArgs e)
        {
            txtOption.Enabled = false;
        }
    }
}
