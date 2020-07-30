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
    public partial class frmUserDetails : Form
    {
        //Create Object to retain name of Form 
        //which opened a copy of Form2
        Form opener;
        
        public frmUserDetails(Form parentForm)
        {
            InitializeComponent();
            opener = parentForm;
        }

        public frmUserDetails()
        {
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            progressBar1.Value = 0;                   

        }
        private void button1_Click(object sender, EventArgs e)
        {
                       
        }

        private void btnSelectComputerSpecification_Click(object sender, EventArgs e)
        {

            Hide();

            frmComputerSpecification copyOfForm3 = new frmComputerSpecification(opener);

            copyOfForm3.Show();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void Check_Progress()
        {
            double progress = 0.0;
            int totalProgress = 0;

            foreach (Control C in this.Controls)
            {
                if (C.GetType() == typeof(System.Windows.Forms.TextBox))
                {
                    if (C.Text != String.Empty)
                    {
                        progress += 11.11111;

                     }
                 }
             }
            
            try
            {

                totalProgress = Convert.ToInt16(progress);
            }
            catch (Exception ex)
            {
                System.Console.WriteLine("Error: " + (ex));

            }

            
            progressBar1.Value = (totalProgress);
            
            label12.Text = "Progress: " + (totalProgress) + "%";

            if (totalProgress > 99)
            {
                //Hides Progressbar until whole form is completed
                //progressBar1.Visible = true;

                btnSelectComputerSpecification.Enabled = true;

              

            }
            else
            {

                //progressBar1.Visible = false;

                btnSelectComputerSpecification.Enabled = false;


            }

         }

        private void txtForename_TextChanged(object sender, EventArgs e)
        {
            Globals.Forename = txtForename.Text;
            Check_Progress();
        }

        private void txtSurmane_TextChanged(object sender, EventArgs e)
        {
            Globals.Surname = txtSurname.Text;
            Check_Progress();
        }

        private void txtHouseNo_TextChanged(object sender, EventArgs e)
        {
            Globals.HouseNo = txtHouseNo.Text;
            //validation - goes here to allow the user to ONLY add DIGIGTS instead of characters and digits

            Check_Progress();
        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {
            Globals.Address = txtAddress.Text;
            Check_Progress();
        }

        private void txtTown_TextChanged(object sender, EventArgs e)
        {
            Globals.Town_City = txtTown_City.Text;
            Check_Progress();
        }

        private void txtCounty_TextChanged(object sender, EventArgs e)
        {
            Globals.County = txtCounty.Text;
            Check_Progress();
        }

        private void txtPostcode_TextChanged(object sender, EventArgs e)
        {
            Globals.Postcode = txtPostcode.Text;
            Check_Progress();
        }

        private void txtMobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            Globals.Mobile = txtMobile.Text;
            Check_Progress();
        }
       
        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            Globals.Email = txtEmail.Text;
            Check_Progress();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you would like to Exit the Form?", "Question", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit(); //this closes the form
            }
        }
    }


    }

