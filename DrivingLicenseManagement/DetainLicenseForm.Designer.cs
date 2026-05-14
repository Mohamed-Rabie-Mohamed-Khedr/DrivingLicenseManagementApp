namespace DrivingLicenseManagement
{
    partial class DetainLicenseForm
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
            this.LicenseIDL = new System.Windows.Forms.Label();
            this.OKB = new System.Windows.Forms.Button();
            this.LicenseIDTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DetainB = new System.Windows.Forms.Button();
            this.ShowLicenseLL = new System.Windows.Forms.LinkLabel();
            this.ShowPersonLicenseHistoryLL = new System.Windows.Forms.LinkLabel();
            this.detainInfo1 = new DrivingLicenseManagement.DetainInfo();
            this.driverInfo1 = new DrivingLicenseManagement.DriverInfo();
            this.SuspendLayout();
            // 
            // LicenseIDL
            // 
            this.LicenseIDL.AutoSize = true;
            this.LicenseIDL.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LicenseIDL.Location = new System.Drawing.Point(9, 42);
            this.LicenseIDL.Name = "LicenseIDL";
            this.LicenseIDL.Size = new System.Drawing.Size(110, 23);
            this.LicenseIDL.TabIndex = 67;
            this.LicenseIDL.Text = "License ID";
            // 
            // OKB
            // 
            this.OKB.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OKB.Location = new System.Drawing.Point(294, 39);
            this.OKB.Name = "OKB";
            this.OKB.Size = new System.Drawing.Size(86, 34);
            this.OKB.TabIndex = 65;
            this.OKB.Text = "OK";
            this.OKB.UseVisualStyleBackColor = true;
            this.OKB.Click += new System.EventHandler(this.OKB_Click);
            // 
            // LicenseIDTB
            // 
            this.LicenseIDTB.Location = new System.Drawing.Point(128, 45);
            this.LicenseIDTB.Name = "LicenseIDTB";
            this.LicenseIDTB.Size = new System.Drawing.Size(155, 20);
            this.LicenseIDTB.TabIndex = 64;
            this.LicenseIDTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LicenseIDTB_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Coral;
            this.label3.Location = new System.Drawing.Point(468, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(229, 35);
            this.label3.TabIndex = 63;
            this.label3.Text = "Detain License";
            // 
            // DetainB
            // 
            this.DetainB.Enabled = false;
            this.DetainB.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DetainB.Location = new System.Drawing.Point(1037, 637);
            this.DetainB.Name = "DetainB";
            this.DetainB.Size = new System.Drawing.Size(86, 34);
            this.DetainB.TabIndex = 71;
            this.DetainB.Text = "Detain";
            this.DetainB.UseVisualStyleBackColor = true;
            this.DetainB.Click += new System.EventHandler(this.DetainB_Click);
            // 
            // ShowLicenseLL
            // 
            this.ShowLicenseLL.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ShowLicenseLL.AutoSize = true;
            this.ShowLicenseLL.Enabled = false;
            this.ShowLicenseLL.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowLicenseLL.Location = new System.Drawing.Point(356, 646);
            this.ShowLicenseLL.Name = "ShowLicenseLL";
            this.ShowLicenseLL.Size = new System.Drawing.Size(118, 19);
            this.ShowLicenseLL.TabIndex = 70;
            this.ShowLicenseLL.TabStop = true;
            this.ShowLicenseLL.Text = "Show License";
            this.ShowLicenseLL.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ShowLicenseLL_LinkClicked);
            // 
            // ShowPersonLicenseHistoryLL
            // 
            this.ShowPersonLicenseHistoryLL.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ShowPersonLicenseHistoryLL.AutoSize = true;
            this.ShowPersonLicenseHistoryLL.Enabled = false;
            this.ShowPersonLicenseHistoryLL.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowPersonLicenseHistoryLL.Location = new System.Drawing.Point(7, 646);
            this.ShowPersonLicenseHistoryLL.Name = "ShowPersonLicenseHistoryLL";
            this.ShowPersonLicenseHistoryLL.Size = new System.Drawing.Size(242, 19);
            this.ShowPersonLicenseHistoryLL.TabIndex = 69;
            this.ShowPersonLicenseHistoryLL.TabStop = true;
            this.ShowPersonLicenseHistoryLL.Text = "Show Person License History";
            this.ShowPersonLicenseHistoryLL.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ShowPersonLicenseHistoryLL_LinkClicked);
            // 
            // detainInfo1
            // 
            this.detainInfo1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.detainInfo1.Location = new System.Drawing.Point(319, 455);
            this.detainInfo1.Name = "detainInfo1";
            this.detainInfo1.Size = new System.Drawing.Size(577, 170);
            this.detainInfo1.TabIndex = 68;
            // 
            // driverInfo1
            // 
            this.driverInfo1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.driverInfo1.Location = new System.Drawing.Point(7, 81);
            this.driverInfo1.Name = "driverInfo1";
            this.driverInfo1.Size = new System.Drawing.Size(1116, 368);
            this.driverInfo1.TabIndex = 66;
            // 
            // DetainLicenseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 681);
            this.Controls.Add(this.DetainB);
            this.Controls.Add(this.ShowLicenseLL);
            this.Controls.Add(this.ShowPersonLicenseHistoryLL);
            this.Controls.Add(this.detainInfo1);
            this.Controls.Add(this.LicenseIDL);
            this.Controls.Add(this.driverInfo1);
            this.Controls.Add(this.OKB);
            this.Controls.Add(this.LicenseIDTB);
            this.Controls.Add(this.label3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DetainLicenseForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detain License";
                        // Dark Mode Injection
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.OKB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OKB.FlatAppearance.BorderSize = 0;
            this.OKB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.OKB.ForeColor = System.Drawing.Color.White;
            this.OKB.UseVisualStyleBackColor = false;
            this.DetainB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DetainB.FlatAppearance.BorderSize = 0;
            this.DetainB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.DetainB.ForeColor = System.Drawing.Color.White;
            this.DetainB.UseVisualStyleBackColor = false;
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label LicenseIDL;
        private DriverInfo driverInfo1;
        private System.Windows.Forms.Button OKB;
        private System.Windows.Forms.TextBox LicenseIDTB;
        private System.Windows.Forms.Label label3;
        private DetainInfo detainInfo1;
        private System.Windows.Forms.Button DetainB;
        private System.Windows.Forms.LinkLabel ShowLicenseLL;
        private System.Windows.Forms.LinkLabel ShowPersonLicenseHistoryLL;
    }
}
