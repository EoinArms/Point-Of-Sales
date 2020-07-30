namespace assignment02
{
    partial class Invoice
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
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.txtPostcode = new System.Windows.Forms.TextBox();
            this.txtCounty = new System.Windows.Forms.TextBox();
            this.txtTown_City = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtHouseNo = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtForename = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblPostcode = new System.Windows.Forms.Label();
            this.lblCounty = new System.Windows.Forms.Label();
            this.lblTown_City = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblHouseNo = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtType = new System.Windows.Forms.TextBox();
            this.txtHD = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtGraphics = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtWarranty = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtOption = new System.Windows.Forms.TextBox();
            this.lblDeliveryOption = new System.Windows.Forms.Label();
            this.txtTypeCost = new System.Windows.Forms.TextBox();
            this.txtHDCost = new System.Windows.Forms.TextBox();
            this.txtGraphicsCost = new System.Windows.Forms.TextBox();
            this.txtWarrantyCost = new System.Windows.Forms.TextBox();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.txtVat = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtDelivery_Cost = new System.Windows.Forms.TextBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblHeading = new System.Windows.Forms.Label();
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(156, 435);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(268, 26);
            this.txtEmail.TabIndex = 43;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // txtMobile
            // 
            this.txtMobile.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMobile.Location = new System.Drawing.Point(156, 388);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(268, 26);
            this.txtMobile.TabIndex = 42;
            this.txtMobile.TextChanged += new System.EventHandler(this.txtMobile_TextChanged);
            // 
            // txtPostcode
            // 
            this.txtPostcode.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPostcode.Location = new System.Drawing.Point(156, 343);
            this.txtPostcode.Name = "txtPostcode";
            this.txtPostcode.Size = new System.Drawing.Size(268, 26);
            this.txtPostcode.TabIndex = 40;
            this.txtPostcode.TextChanged += new System.EventHandler(this.txtPostcode_TextChanged);
            // 
            // txtCounty
            // 
            this.txtCounty.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCounty.Location = new System.Drawing.Point(156, 302);
            this.txtCounty.Name = "txtCounty";
            this.txtCounty.Size = new System.Drawing.Size(268, 26);
            this.txtCounty.TabIndex = 39;
            this.txtCounty.TextChanged += new System.EventHandler(this.txtCounty_TextChanged);
            // 
            // txtTown_City
            // 
            this.txtTown_City.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTown_City.Location = new System.Drawing.Point(156, 257);
            this.txtTown_City.Name = "txtTown_City";
            this.txtTown_City.Size = new System.Drawing.Size(268, 26);
            this.txtTown_City.TabIndex = 38;
            this.txtTown_City.TextChanged += new System.EventHandler(this.txtTown_City_TextChanged);
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(156, 215);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(268, 26);
            this.txtAddress.TabIndex = 37;
            this.txtAddress.TextChanged += new System.EventHandler(this.txtAddress_TextChanged);
            // 
            // txtHouseNo
            // 
            this.txtHouseNo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHouseNo.Location = new System.Drawing.Point(156, 168);
            this.txtHouseNo.Name = "txtHouseNo";
            this.txtHouseNo.Size = new System.Drawing.Size(268, 26);
            this.txtHouseNo.TabIndex = 36;
            this.txtHouseNo.TextChanged += new System.EventHandler(this.txtHouseNo_TextChanged);
            // 
            // txtSurname
            // 
            this.txtSurname.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSurname.Location = new System.Drawing.Point(156, 116);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(268, 26);
            this.txtSurname.TabIndex = 35;
            this.txtSurname.TextChanged += new System.EventHandler(this.txtSurname_TextChanged);
            // 
            // txtForename
            // 
            this.txtForename.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtForename.Location = new System.Drawing.Point(156, 70);
            this.txtForename.Name = "txtForename";
            this.txtForename.Size = new System.Drawing.Size(268, 26);
            this.txtForename.TabIndex = 33;
            this.txtForename.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(11, 437);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(133, 22);
            this.label11.TabIndex = 32;
            this.label11.Text = "Email Address";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(11, 387);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(138, 22);
            this.label10.TabIndex = 31;
            this.label10.Text = "Mobile Number";
            // 
            // lblPostcode
            // 
            this.lblPostcode.AutoSize = true;
            this.lblPostcode.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPostcode.Location = new System.Drawing.Point(11, 342);
            this.lblPostcode.Name = "lblPostcode";
            this.lblPostcode.Size = new System.Drawing.Size(92, 22);
            this.lblPostcode.TabIndex = 29;
            this.lblPostcode.Text = "Postcode";
            // 
            // lblCounty
            // 
            this.lblCounty.AutoSize = true;
            this.lblCounty.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCounty.Location = new System.Drawing.Point(11, 303);
            this.lblCounty.Name = "lblCounty";
            this.lblCounty.Size = new System.Drawing.Size(69, 22);
            this.lblCounty.TabIndex = 28;
            this.lblCounty.Text = "County";
            // 
            // lblTown_City
            // 
            this.lblTown_City.AutoSize = true;
            this.lblTown_City.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTown_City.Location = new System.Drawing.Point(11, 258);
            this.lblTown_City.Name = "lblTown_City";
            this.lblTown_City.Size = new System.Drawing.Size(91, 22);
            this.lblTown_City.TabIndex = 27;
            this.lblTown_City.Text = "Town/City";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(11, 216);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(82, 22);
            this.lblAddress.TabIndex = 26;
            this.lblAddress.Text = "Address";
            // 
            // lblHouseNo
            // 
            this.lblHouseNo.AutoSize = true;
            this.lblHouseNo.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHouseNo.Location = new System.Drawing.Point(11, 169);
            this.lblHouseNo.Name = "lblHouseNo";
            this.lblHouseNo.Size = new System.Drawing.Size(99, 22);
            this.lblHouseNo.TabIndex = 25;
            this.lblHouseNo.Text = "House No.";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurname.Location = new System.Drawing.Point(11, 115);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(86, 22);
            this.lblSurname.TabIndex = 24;
            this.lblSurname.Text = "Surname";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 22);
            this.label1.TabIndex = 22;
            this.label1.Text = "Forename";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 14.25F);
            this.label12.Location = new System.Drawing.Point(446, 70);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(141, 22);
            this.label12.TabIndex = 44;
            this.label12.Text = "Computer Type";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // txtType
            // 
            this.txtType.Font = new System.Drawing.Font("Arial", 12F);
            this.txtType.Location = new System.Drawing.Point(627, 70);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(237, 26);
            this.txtType.TabIndex = 45;
            this.txtType.TextChanged += new System.EventHandler(this.txtType_TextChanged);
            // 
            // txtHD
            // 
            this.txtHD.Font = new System.Drawing.Font("Arial", 12F);
            this.txtHD.Location = new System.Drawing.Point(627, 109);
            this.txtHD.Name = "txtHD";
            this.txtHD.Size = new System.Drawing.Size(237, 26);
            this.txtHD.TabIndex = 47;
            this.txtHD.TextChanged += new System.EventHandler(this.txtHD_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 14.25F);
            this.label13.Location = new System.Drawing.Point(446, 108);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(126, 22);
            this.label13.TabIndex = 46;
            this.label13.Text = "Computer HD";
            // 
            // txtGraphics
            // 
            this.txtGraphics.Font = new System.Drawing.Font("Arial", 12F);
            this.txtGraphics.Location = new System.Drawing.Point(627, 144);
            this.txtGraphics.Name = "txtGraphics";
            this.txtGraphics.Size = new System.Drawing.Size(237, 26);
            this.txtGraphics.TabIndex = 49;
            this.txtGraphics.TextChanged += new System.EventHandler(this.txtGraphics_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 14.25F);
            this.label14.Location = new System.Drawing.Point(446, 146);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(175, 22);
            this.label14.TabIndex = 48;
            this.label14.Text = "Computer Graphics";
            // 
            // txtWarranty
            // 
            this.txtWarranty.Font = new System.Drawing.Font("Arial", 12F);
            this.txtWarranty.Location = new System.Drawing.Point(627, 180);
            this.txtWarranty.Name = "txtWarranty";
            this.txtWarranty.Size = new System.Drawing.Size(268, 26);
            this.txtWarranty.TabIndex = 51;
            this.txtWarranty.TextChanged += new System.EventHandler(this.txtWarranty_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 14.25F);
            this.label15.Location = new System.Drawing.Point(446, 182);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(173, 22);
            this.label15.TabIndex = 50;
            this.label15.Text = "Computer Warranty";
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("Arial Narrow", 21.75F);
            this.btnPrint.Location = new System.Drawing.Point(15, 509);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(97, 57);
            this.btnPrint.TabIndex = 52;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // txtInfo
            // 
            this.txtInfo.Font = new System.Drawing.Font("Arial", 12F);
            this.txtInfo.Location = new System.Drawing.Point(596, 231);
            this.txtInfo.Multiline = true;
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.Size = new System.Drawing.Size(268, 157);
            this.txtInfo.TabIndex = 54;
            this.txtInfo.TextChanged += new System.EventHandler(this.textBox16_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial", 14.25F);
            this.label16.Location = new System.Drawing.Point(446, 230);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(132, 22);
            this.label16.TabIndex = 53;
            this.label16.Text = "Computer Info";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // txtOption
            // 
            this.txtOption.Font = new System.Drawing.Font("Arial", 12F);
            this.txtOption.Location = new System.Drawing.Point(596, 419);
            this.txtOption.Name = "txtOption";
            this.txtOption.Size = new System.Drawing.Size(268, 26);
            this.txtOption.TabIndex = 56;
            this.txtOption.TextChanged += new System.EventHandler(this.txtOption_TextChanged);
            // 
            // lblDeliveryOption
            // 
            this.lblDeliveryOption.Font = new System.Drawing.Font("Arial", 14.25F);
            this.lblDeliveryOption.Location = new System.Drawing.Point(446, 419);
            this.lblDeliveryOption.Name = "lblDeliveryOption";
            this.lblDeliveryOption.Size = new System.Drawing.Size(128, 52);
            this.lblDeliveryOption.TabIndex = 55;
            this.lblDeliveryOption.Text = "Collection Option";
            // 
            // txtTypeCost
            // 
            this.txtTypeCost.Font = new System.Drawing.Font("Arial", 12F);
            this.txtTypeCost.Location = new System.Drawing.Point(919, 70);
            this.txtTypeCost.Name = "txtTypeCost";
            this.txtTypeCost.Size = new System.Drawing.Size(75, 26);
            this.txtTypeCost.TabIndex = 57;
            this.txtTypeCost.TextChanged += new System.EventHandler(this.txtTypeCost_TextChanged);
            // 
            // txtHDCost
            // 
            this.txtHDCost.Font = new System.Drawing.Font("Arial", 12F);
            this.txtHDCost.Location = new System.Drawing.Point(919, 109);
            this.txtHDCost.Name = "txtHDCost";
            this.txtHDCost.Size = new System.Drawing.Size(75, 26);
            this.txtHDCost.TabIndex = 58;
            this.txtHDCost.TextChanged += new System.EventHandler(this.txtHDCost_TextChanged);
            // 
            // txtGraphicsCost
            // 
            this.txtGraphicsCost.Font = new System.Drawing.Font("Arial", 12F);
            this.txtGraphicsCost.Location = new System.Drawing.Point(919, 144);
            this.txtGraphicsCost.Name = "txtGraphicsCost";
            this.txtGraphicsCost.Size = new System.Drawing.Size(75, 26);
            this.txtGraphicsCost.TabIndex = 59;
            this.txtGraphicsCost.TextChanged += new System.EventHandler(this.txtGraphicsCost_TextChanged);
            // 
            // txtWarrantyCost
            // 
            this.txtWarrantyCost.Font = new System.Drawing.Font("Arial", 12F);
            this.txtWarrantyCost.Location = new System.Drawing.Point(919, 179);
            this.txtWarrantyCost.Name = "txtWarrantyCost";
            this.txtWarrantyCost.Size = new System.Drawing.Size(75, 26);
            this.txtWarrantyCost.TabIndex = 60;
            this.txtWarrantyCost.TextChanged += new System.EventHandler(this.txtWarrantyCost_TextChanged);
            // 
            // txtCost
            // 
            this.txtCost.Font = new System.Drawing.Font("Arial", 12F);
            this.txtCost.Location = new System.Drawing.Point(919, 231);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(75, 26);
            this.txtCost.TabIndex = 61;
            this.txtCost.TextChanged += new System.EventHandler(this.txtCost_TextChanged);
            // 
            // txtVat
            // 
            this.txtVat.Font = new System.Drawing.Font("Arial", 12F);
            this.txtVat.Location = new System.Drawing.Point(919, 271);
            this.txtVat.Name = "txtVat";
            this.txtVat.Size = new System.Drawing.Size(75, 26);
            this.txtVat.TabIndex = 62;
            this.txtVat.TextChanged += new System.EventHandler(this.txtVat_TextChanged);
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Arial", 12F);
            this.txtTotal.Location = new System.Drawing.Point(919, 308);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(75, 26);
            this.txtTotal.TabIndex = 63;
            this.txtTotal.TextChanged += new System.EventHandler(this.txtTotal_TextChanged);
            // 
            // txtDelivery_Cost
            // 
            this.txtDelivery_Cost.Font = new System.Drawing.Font("Arial", 12F);
            this.txtDelivery_Cost.Location = new System.Drawing.Point(919, 419);
            this.txtDelivery_Cost.Name = "txtDelivery_Cost";
            this.txtDelivery_Cost.Size = new System.Drawing.Size(75, 26);
            this.txtDelivery_Cost.TabIndex = 64;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Arial Narrow", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(897, 509);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(97, 57);
            this.btnExit.TabIndex = 96;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblHeading
            // 
            this.lblHeading.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHeading.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(15, 9);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(979, 40);
            this.lblHeading.TabIndex = 97;
            this.lblHeading.Text = "Invoice";
            this.lblHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Invoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(1007, 590);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtDelivery_Cost);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtVat);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.txtWarrantyCost);
            this.Controls.Add(this.txtGraphicsCost);
            this.Controls.Add(this.txtHDCost);
            this.Controls.Add(this.txtTypeCost);
            this.Controls.Add(this.txtOption);
            this.Controls.Add(this.lblDeliveryOption);
            this.Controls.Add(this.txtInfo);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.txtWarranty);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtGraphics);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtHD);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtMobile);
            this.Controls.Add(this.txtPostcode);
            this.Controls.Add(this.txtCounty);
            this.Controls.Add(this.txtTown_City);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtHouseNo);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.txtForename);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblPostcode);
            this.Controls.Add(this.lblCounty);
            this.Controls.Add(this.lblTown_City);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblHouseNo);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.label1);
            this.Name = "Invoice";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.TextBox txtPostcode;
        private System.Windows.Forms.TextBox txtCounty;
        private System.Windows.Forms.TextBox txtTown_City;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtHouseNo;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtForename;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblPostcode;
        private System.Windows.Forms.Label lblCounty;
        private System.Windows.Forms.Label lblTown_City;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblHouseNo;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.TextBox txtHD;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtGraphics;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtWarranty;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.TextBox txtInfo;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtOption;
        private System.Windows.Forms.Label lblDeliveryOption;
        private System.Windows.Forms.TextBox txtTypeCost;
        private System.Windows.Forms.TextBox txtHDCost;
        private System.Windows.Forms.TextBox txtGraphicsCost;
        private System.Windows.Forms.TextBox txtWarrantyCost;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.TextBox txtVat;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtDelivery_Cost;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.ToolTip toolTip2;
    }
}