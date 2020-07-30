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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Hide();

            frmUserDetails copyOfForm2 = new frmUserDetails(this);

            copyOfForm2.Show();




        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            Form form = new frmUserDetails(ParentForm);
            form.Show();
            Hide();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("In this Application you will be able to select a Computer, showing each specification." +
               " Then if you want you can Uprgade it by adding an extended:" +
               " Hard Drive," +
               " Graphics Card and" +
               " Warrenty." +
               " This Application will also allow you give you the option on where it should be delivered." +
               " Finally showing you all of the details in the form of an Invoive");
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
