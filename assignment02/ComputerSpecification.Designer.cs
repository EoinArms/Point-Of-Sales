namespace assignment02
{
    partial class frmComputerSpecification
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmComputerSpecification));
            this.rboLaptop = new System.Windows.Forms.RadioButton();
            this.rboPC50 = new System.Windows.Forms.RadioButton();
            this.rboPC60 = new System.Windows.Forms.RadioButton();
            this.btnSelectDelivery = new System.Windows.Forms.Button();
            this.rbo750GB = new System.Windows.Forms.RadioButton();
            this.rbo1TB = new System.Windows.Forms.RadioButton();
            this.rbo2GB = new System.Windows.Forms.RadioButton();
            this.rbo4GB = new System.Windows.Forms.RadioButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblGraphics_Card = new System.Windows.Forms.Label();
            this.lblWarranty = new System.Windows.Forms.Label();
            this.lblHeading = new System.Windows.Forms.Label();
            this.lblHard_Drive = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.rbo3Years = new System.Windows.Forms.RadioButton();
            this.rboInHome = new System.Windows.Forms.RadioButton();
            this.rboHardwareSupport = new System.Windows.Forms.RadioButton();
            this.rboIncluded = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // rboLaptop
            // 
            this.rboLaptop.AutoSize = true;
            this.rboLaptop.Font = new System.Drawing.Font("Arial", 12F);
            this.rboLaptop.Location = new System.Drawing.Point(95, 126);
            this.rboLaptop.Name = "rboLaptop";
            this.rboLaptop.Size = new System.Drawing.Size(75, 22);
            this.rboLaptop.TabIndex = 3;
            this.rboLaptop.TabStop = true;
            this.rboLaptop.Text = "Laptop";
            this.rboLaptop.UseVisualStyleBackColor = true;
            this.rboLaptop.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rboPC50
            // 
            this.rboPC50.AutoSize = true;
            this.rboPC50.Font = new System.Drawing.Font("Arial", 12F);
            this.rboPC50.Location = new System.Drawing.Point(95, 193);
            this.rboPC50.Name = "rboPC50";
            this.rboPC50.Size = new System.Drawing.Size(67, 22);
            this.rboPC50.TabIndex = 5;
            this.rboPC50.TabStop = true;
            this.rboPC50.Text = "PC50";
            this.rboPC50.UseVisualStyleBackColor = true;
            this.rboPC50.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rboPC60
            // 
            this.rboPC60.AutoSize = true;
            this.rboPC60.Font = new System.Drawing.Font("Arial", 12F);
            this.rboPC60.Location = new System.Drawing.Point(95, 257);
            this.rboPC60.Name = "rboPC60";
            this.rboPC60.Size = new System.Drawing.Size(67, 22);
            this.rboPC60.TabIndex = 7;
            this.rboPC60.TabStop = true;
            this.rboPC60.Text = "PC60";
            this.rboPC60.UseVisualStyleBackColor = true;
            this.rboPC60.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // btnSelectDelivery
            // 
            this.btnSelectDelivery.Font = new System.Drawing.Font("Arial Narrow", 21.75F);
            this.btnSelectDelivery.Location = new System.Drawing.Point(295, 541);
            this.btnSelectDelivery.Name = "btnSelectDelivery";
            this.btnSelectDelivery.Size = new System.Drawing.Size(125, 72);
            this.btnSelectDelivery.TabIndex = 25;
            this.btnSelectDelivery.Text = "Delivery";
            this.btnSelectDelivery.UseVisualStyleBackColor = true;
            this.btnSelectDelivery.Click += new System.EventHandler(this.btnSelectWarranty_Click);
            // 
            // rbo750GB
            // 
            this.rbo750GB.AutoSize = true;
            this.rbo750GB.Font = new System.Drawing.Font("Arial", 12F);
            this.rbo750GB.Location = new System.Drawing.Point(11, 396);
            this.rbo750GB.Name = "rbo750GB";
            this.rbo750GB.Size = new System.Drawing.Size(150, 22);
            this.rbo750GB.TabIndex = 26;
            this.rbo750GB.TabStop = true;
            this.rbo750GB.Text = "750GB Hard Disc";
            this.rbo750GB.UseVisualStyleBackColor = true;
            this.rbo750GB.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // rbo1TB
            // 
            this.rbo1TB.AutoSize = true;
            this.rbo1TB.Font = new System.Drawing.Font("Arial", 12F);
            this.rbo1TB.Location = new System.Drawing.Point(11, 449);
            this.rbo1TB.Name = "rbo1TB";
            this.rbo1TB.Size = new System.Drawing.Size(142, 22);
            this.rbo1TB.TabIndex = 27;
            this.rbo1TB.TabStop = true;
            this.rbo1TB.Text = "1.0TB Hard Disc";
            this.rbo1TB.UseVisualStyleBackColor = true;
            this.rbo1TB.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // rbo2GB
            // 
            this.rbo2GB.Font = new System.Drawing.Font("Arial", 12F);
            this.rbo2GB.Location = new System.Drawing.Point(541, 116);
            this.rbo2GB.Name = "rbo2GB";
            this.rbo2GB.Size = new System.Drawing.Size(184, 42);
            this.rbo2GB.TabIndex = 28;
            this.rbo2GB.TabStop = true;
            this.rbo2GB.Text = "2 GB version of same card";
            this.rbo2GB.UseVisualStyleBackColor = true;
            this.rbo2GB.CheckedChanged += new System.EventHandler(this.radioButton6_CheckedChanged);
            // 
            // rbo4GB
            // 
            this.rbo4GB.Font = new System.Drawing.Font("Arial", 12F);
            this.rbo4GB.Location = new System.Drawing.Point(541, 177);
            this.rbo4GB.Name = "rbo4GB";
            this.rbo4GB.Size = new System.Drawing.Size(184, 47);
            this.rbo4GB.TabIndex = 29;
            this.rbo4GB.TabStop = true;
            this.rbo4GB.Text = "4 GB version of same card ";
            this.rbo4GB.UseVisualStyleBackColor = true;
            this.rbo4GB.CheckedChanged += new System.EventHandler(this.radioButton7_CheckedChanged);
            // 
            // lblGraphics_Card
            // 
            this.lblGraphics_Card.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGraphics_Card.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGraphics_Card.Location = new System.Drawing.Point(541, 66);
            this.lblGraphics_Card.Name = "lblGraphics_Card";
            this.lblGraphics_Card.Size = new System.Drawing.Size(214, 40);
            this.lblGraphics_Card.TabIndex = 51;
            this.lblGraphics_Card.Text = "Graphics Card";
            this.lblGraphics_Card.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWarranty
            // 
            this.lblWarranty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblWarranty.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarranty.Location = new System.Drawing.Point(11, 66);
            this.lblWarranty.Name = "lblWarranty";
            this.lblWarranty.Size = new System.Drawing.Size(458, 40);
            this.lblWarranty.TabIndex = 50;
            this.lblWarranty.Text = "Device";
            this.lblWarranty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHeading
            // 
            this.lblHeading.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHeading.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(11, 9);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(744, 40);
            this.lblHeading.TabIndex = 49;
            this.lblHeading.Text = "Device and Upgrades";
            this.lblHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHard_Drive
            // 
            this.lblHard_Drive.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHard_Drive.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHard_Drive.Location = new System.Drawing.Point(11, 326);
            this.lblHard_Drive.Name = "lblHard_Drive";
            this.lblHard_Drive.Size = new System.Drawing.Size(197, 40);
            this.lblHard_Drive.TabIndex = 52;
            this.lblHard_Drive.Text = "Hard Drive";
            this.lblHard_Drive.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(12, 245);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(60, 48);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 55;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(11, 182);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(60, 48);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 54;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 116);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 53;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F);
            this.label1.Location = new System.Drawing.Point(292, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 18);
            this.label1.TabIndex = 56;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F);
            this.label2.Location = new System.Drawing.Point(292, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 18);
            this.label2.TabIndex = 57;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F);
            this.label3.Location = new System.Drawing.Point(292, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 18);
            this.label3.TabIndex = 58;
            this.label3.Text = "label3";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Arial Narrow", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(661, 564);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(94, 49);
            this.btnExit.TabIndex = 62;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnHelp
            // 
            this.btnHelp.Font = new System.Drawing.Font("Arial Narrow", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.Location = new System.Drawing.Point(12, 564);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(94, 49);
            this.btnHelp.TabIndex = 61;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(267, 326);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(458, 40);
            this.label4.TabIndex = 63;
            this.label4.Text = "Warranty";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rbo3Years
            // 
            this.rbo3Years.AutoSize = true;
            this.rbo3Years.Font = new System.Drawing.Font("Arial", 12F);
            this.rbo3Years.Location = new System.Drawing.Point(267, 501);
            this.rbo3Years.Name = "rbo3Years";
            this.rbo3Years.Size = new System.Drawing.Size(470, 22);
            this.rbo3Years.TabIndex = 68;
            this.rbo3Years.TabStop = true;
            this.rbo3Years.Text = "3 Years Next Day In-Home Service with Premium Phone Support";
            this.rbo3Years.UseVisualStyleBackColor = true;
            this.rbo3Years.CheckedChanged += new System.EventHandler(this.rbo3Years_CheckedChanged);
            // 
            // rboInHome
            // 
            this.rboInHome.AutoSize = true;
            this.rboInHome.Font = new System.Drawing.Font("Arial", 12F);
            this.rboInHome.Location = new System.Drawing.Point(267, 462);
            this.rboInHome.Name = "rboInHome";
            this.rboInHome.Size = new System.Drawing.Size(462, 22);
            this.rboInHome.TabIndex = 67;
            this.rboInHome.TabStop = true;
            this.rboInHome.Text = "1 Year Next Day In-Home Service with Premium Phone Support";
            this.rboInHome.UseVisualStyleBackColor = true;
            this.rboInHome.CheckedChanged += new System.EventHandler(this.rboInHome_CheckedChanged);
            // 
            // rboHardwareSupport
            // 
            this.rboHardwareSupport.AutoSize = true;
            this.rboHardwareSupport.Font = new System.Drawing.Font("Arial", 12F);
            this.rboHardwareSupport.Location = new System.Drawing.Point(267, 421);
            this.rboHardwareSupport.Name = "rboHardwareSupport";
            this.rboHardwareSupport.Size = new System.Drawing.Size(268, 22);
            this.rboHardwareSupport.TabIndex = 66;
            this.rboHardwareSupport.TabStop = true;
            this.rboHardwareSupport.Text = "1 Year Next Day Hardware Support";
            this.rboHardwareSupport.UseVisualStyleBackColor = true;
            this.rboHardwareSupport.CheckedChanged += new System.EventHandler(this.rboHardwareSupport_CheckedChanged);
            // 
            // rboIncluded
            // 
            this.rboIncluded.AutoSize = true;
            this.rboIncluded.Font = new System.Drawing.Font("Arial", 12F);
            this.rboIncluded.Location = new System.Drawing.Point(267, 384);
            this.rboIncluded.Name = "rboIncluded";
            this.rboIncluded.Size = new System.Drawing.Size(328, 22);
            this.rboIncluded.TabIndex = 65;
            this.rboIncluded.TabStop = true;
            this.rboIncluded.Text = "1 Year Collect + Returns Warranty (Included)";
            this.rboIncluded.UseVisualStyleBackColor = true;
            this.rboIncluded.CheckedChanged += new System.EventHandler(this.rboIncluded_CheckedChanged);
            // 
            // frmComputerSpecification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(767, 625);
            this.Controls.Add(this.rbo3Years);
            this.Controls.Add(this.rboInHome);
            this.Controls.Add(this.rboHardwareSupport);
            this.Controls.Add(this.rboIncluded);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rboPC60);
            this.Controls.Add(this.rboPC50);
            this.Controls.Add(this.rboLaptop);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.rbo750GB);
            this.Controls.Add(this.lblHard_Drive);
            this.Controls.Add(this.rbo1TB);
            this.Controls.Add(this.rbo4GB);
            this.Controls.Add(this.rbo2GB);
            this.Controls.Add(this.lblGraphics_Card);
            this.Controls.Add(this.lblWarranty);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.btnSelectDelivery);
            this.Name = "frmComputerSpecification";
            this.Text = "Select Computer Specification";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rboLaptop;
        private System.Windows.Forms.RadioButton rboPC50;
        private System.Windows.Forms.RadioButton rboPC60;
        private System.Windows.Forms.Button btnSelectDelivery;
        private System.Windows.Forms.RadioButton rbo750GB;
        private System.Windows.Forms.RadioButton rbo1TB;
        private System.Windows.Forms.RadioButton rbo2GB;
        private System.Windows.Forms.RadioButton rbo4GB;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblGraphics_Card;
        private System.Windows.Forms.Label lblWarranty;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Label lblHard_Drive;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbo3Years;
        private System.Windows.Forms.RadioButton rboInHome;
        private System.Windows.Forms.RadioButton rboHardwareSupport;
        private System.Windows.Forms.RadioButton rboIncluded;
    }
}