namespace assignment02
{
    partial class frmDelivery
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
            this.rboLondon = new System.Windows.Forms.RadioButton();
            this.rboEngland = new System.Windows.Forms.RadioButton();
            this.rboWales = new System.Windows.Forms.RadioButton();
            this.rboScotland = new System.Windows.Forms.RadioButton();
            this.rboNI = new System.Windows.Forms.RadioButton();
            this.rboCollect = new System.Windows.Forms.RadioButton();
            this.btnSelectWarranty = new System.Windows.Forms.Button();
            this.lblDelivery = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rboLondon
            // 
            this.rboLondon.AutoSize = true;
            this.rboLondon.Font = new System.Drawing.Font("Arial", 12F);
            this.rboLondon.Location = new System.Drawing.Point(181, 157);
            this.rboLondon.Name = "rboLondon";
            this.rboLondon.Size = new System.Drawing.Size(78, 22);
            this.rboLondon.TabIndex = 0;
            this.rboLondon.TabStop = true;
            this.rboLondon.Text = "London";
            this.rboLondon.UseVisualStyleBackColor = true;
            this.rboLondon.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rboEngland
            // 
            this.rboEngland.AutoSize = true;
            this.rboEngland.Font = new System.Drawing.Font("Arial", 12F);
            this.rboEngland.Location = new System.Drawing.Point(181, 223);
            this.rboEngland.Name = "rboEngland";
            this.rboEngland.Size = new System.Drawing.Size(83, 22);
            this.rboEngland.TabIndex = 1;
            this.rboEngland.TabStop = true;
            this.rboEngland.Text = "England";
            this.rboEngland.UseVisualStyleBackColor = true;
            this.rboEngland.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rboWales
            // 
            this.rboWales.AutoSize = true;
            this.rboWales.Font = new System.Drawing.Font("Arial", 12F);
            this.rboWales.Location = new System.Drawing.Point(442, 94);
            this.rboWales.Name = "rboWales";
            this.rboWales.Size = new System.Drawing.Size(69, 22);
            this.rboWales.TabIndex = 2;
            this.rboWales.TabStop = true;
            this.rboWales.Text = "Wales";
            this.rboWales.UseVisualStyleBackColor = true;
            this.rboWales.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // rboScotland
            // 
            this.rboScotland.AutoSize = true;
            this.rboScotland.Font = new System.Drawing.Font("Arial", 12F);
            this.rboScotland.Location = new System.Drawing.Point(442, 157);
            this.rboScotland.Name = "rboScotland";
            this.rboScotland.Size = new System.Drawing.Size(87, 22);
            this.rboScotland.TabIndex = 3;
            this.rboScotland.TabStop = true;
            this.rboScotland.Text = "Scotland";
            this.rboScotland.UseVisualStyleBackColor = true;
            this.rboScotland.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // rboNI
            // 
            this.rboNI.AutoSize = true;
            this.rboNI.Font = new System.Drawing.Font("Arial", 12F);
            this.rboNI.Location = new System.Drawing.Point(442, 223);
            this.rboNI.Name = "rboNI";
            this.rboNI.Size = new System.Drawing.Size(135, 22);
            this.rboNI.TabIndex = 4;
            this.rboNI.TabStop = true;
            this.rboNI.Text = "Northern Ireland";
            this.rboNI.UseVisualStyleBackColor = true;
            this.rboNI.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // rboCollect
            // 
            this.rboCollect.AutoSize = true;
            this.rboCollect.Font = new System.Drawing.Font("Arial", 12F);
            this.rboCollect.Location = new System.Drawing.Point(181, 94);
            this.rboCollect.Name = "rboCollect";
            this.rboCollect.Size = new System.Drawing.Size(74, 22);
            this.rboCollect.TabIndex = 5;
            this.rboCollect.TabStop = true;
            this.rboCollect.Text = "Collect";
            this.rboCollect.UseVisualStyleBackColor = true;
            this.rboCollect.CheckedChanged += new System.EventHandler(this.radioButton6_CheckedChanged);
            // 
            // btnSelectWarranty
            // 
            this.btnSelectWarranty.Font = new System.Drawing.Font("Arial Narrow", 21.75F);
            this.btnSelectWarranty.Location = new System.Drawing.Point(301, 302);
            this.btnSelectWarranty.Name = "btnSelectWarranty";
            this.btnSelectWarranty.Size = new System.Drawing.Size(114, 88);
            this.btnSelectWarranty.TabIndex = 29;
            this.btnSelectWarranty.Text = "Display Invoice";
            this.btnSelectWarranty.UseVisualStyleBackColor = true;
            this.btnSelectWarranty.Click += new System.EventHandler(this.btnSelectWarranty_Click);
            // 
            // lblDelivery
            // 
            this.lblDelivery.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDelivery.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDelivery.Location = new System.Drawing.Point(12, 9);
            this.lblDelivery.Name = "lblDelivery";
            this.lblDelivery.Size = new System.Drawing.Size(689, 40);
            this.lblDelivery.TabIndex = 62;
            this.lblDelivery.Text = "Delivery";
            this.lblDelivery.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmDelivery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(713, 419);
            this.Controls.Add(this.lblDelivery);
            this.Controls.Add(this.btnSelectWarranty);
            this.Controls.Add(this.rboCollect);
            this.Controls.Add(this.rboNI);
            this.Controls.Add(this.rboScotland);
            this.Controls.Add(this.rboWales);
            this.Controls.Add(this.rboEngland);
            this.Controls.Add(this.rboLondon);
            this.MaximumSize = new System.Drawing.Size(729, 458);
            this.MinimumSize = new System.Drawing.Size(729, 458);
            this.Name = "frmDelivery";
            this.Text = "Delivery";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rboLondon;
        private System.Windows.Forms.RadioButton rboEngland;
        private System.Windows.Forms.RadioButton rboWales;
        private System.Windows.Forms.RadioButton rboScotland;
        private System.Windows.Forms.RadioButton rboNI;
        private System.Windows.Forms.RadioButton rboCollect;
        private System.Windows.Forms.Button btnSelectWarranty;
        private System.Windows.Forms.Label lblDelivery;
    }
}