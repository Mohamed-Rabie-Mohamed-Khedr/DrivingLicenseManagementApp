namespace DrivingLicenseManagement
{
    partial class InternationalLicenseApplication
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
            this.label3 = new System.Windows.Forms.Label();
            this.OKB = new System.Windows.Forms.Button();
            this.LicenseIDTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ShowPersonLicenseHistoryLL = new System.Windows.Forms.LinkLabel();
            this.ShowInternationalLicenseLL = new System.Windows.Forms.LinkLabel();
            this.IssueB = new System.Windows.Forms.Button();
            this.driverLicenseInfo1 = new DrivingLicenseManagement.DriverInfo();
            this.applicationInfo1 = new DrivingLicenseManagement.ApplicationInfo();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Coral;
            this.label3.Location = new System.Drawing.Point(394, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(501, 35);
            this.label3.TabIndex = 39;
            this.label3.Text = "International License Application";
            // 
            // OKB
            // 
            this.OKB.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OKB.Location = new System.Drawing.Point(319, 92);
            this.OKB.Name = "OKB";
            this.OKB.Size = new System.Drawing.Size(86, 34);
            this.OKB.TabIndex = 53;
            this.OKB.Text = "OK";
            this.OKB.UseVisualStyleBackColor = true;
            this.OKB.Click += new System.EventHandler(this.OKB_Click);
            // 
            // LicenseIDTB
            // 
            this.LicenseIDTB.Location = new System.Drawing.Point(153, 98);
            this.LicenseIDTB.Name = "LicenseIDTB";
            this.LicenseIDTB.Size = new System.Drawing.Size(155, 20);
            this.LicenseIDTB.TabIndex = 50;
            this.LicenseIDTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LicenseIDTB_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(22, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 25);
            this.label1.TabIndex = 49;
            this.label1.Text = "License ID";
            // 
            // ShowPersonLicenseHistoryLL
            // 
            this.ShowPersonLicenseHistoryLL.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ShowPersonLicenseHistoryLL.AutoSize = true;
            this.ShowPersonLicenseHistoryLL.Enabled = false;
            this.ShowPersonLicenseHistoryLL.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowPersonLicenseHistoryLL.Location = new System.Drawing.Point(78, 775);
            this.ShowPersonLicenseHistoryLL.Name = "ShowPersonLicenseHistoryLL";
            this.ShowPersonLicenseHistoryLL.Size = new System.Drawing.Size(242, 19);
            this.ShowPersonLicenseHistoryLL.TabIndex = 56;
            this.ShowPersonLicenseHistoryLL.TabStop = true;
            this.ShowPersonLicenseHistoryLL.Text = "Show Person License History";
            this.ShowPersonLicenseHistoryLL.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ShowPersonLicenseHistoryLL_LinkClicked);
            // 
            // ShowInternationalLicenseLL
            // 
            this.ShowInternationalLicenseLL.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ShowInternationalLicenseLL.AutoSize = true;
            this.ShowInternationalLicenseLL.Enabled = false;
            this.ShowInternationalLicenseLL.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowInternationalLicenseLL.Location = new System.Drawing.Point(350, 775);
            this.ShowInternationalLicenseLL.Name = "ShowInternationalLicenseLL";
            this.ShowInternationalLicenseLL.Size = new System.Drawing.Size(231, 19);
            this.ShowInternationalLicenseLL.TabIndex = 57;
            this.ShowInternationalLicenseLL.TabStop = true;
            this.ShowInternationalLicenseLL.Text = "Show International License";
            this.ShowInternationalLicenseLL.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ShowInternationalLicenseLL_LinkClicked);
            // 
            // IssueB
            // 
            this.IssueB.Enabled = false;
            this.IssueB.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IssueB.Location = new System.Drawing.Point(1099, 778);
            this.IssueB.Name = "IssueB";
            this.IssueB.Size = new System.Drawing.Size(86, 34);
            this.IssueB.TabIndex = 58;
            this.IssueB.Text = "Issue";
            this.IssueB.UseVisualStyleBackColor = true;
            this.IssueB.Click += new System.EventHandler(this.IssueB_Click);
            // 
            // driverLicenseInfo1
            // 
            this.driverLicenseInfo1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.driverLicenseInfo1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.driverLicenseInfo1.Location = new System.Drawing.Point(27, 135);
            this.driverLicenseInfo1.Name = "driverLicenseInfo1";
            this.driverLicenseInfo1.Size = new System.Drawing.Size(1116, 313);
            this.driverLicenseInfo1.TabIndex = 54;
            // 
            // applicationInfo1
            // 
            this.applicationInfo1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.applicationInfo1.Location = new System.Drawing.Point(27, 466);
            this.applicationInfo1.Name = "applicationInfo1";
            this.applicationInfo1.Size = new System.Drawing.Size(1039, 225);
            this.applicationInfo1.TabIndex = 59;
            // 
            // InternationalLicenseApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1207, 824);
            this.Controls.Add(this.applicationInfo1);
            this.Controls.Add(this.IssueB);
            this.Controls.Add(this.ShowInternationalLicenseLL);
            this.Controls.Add(this.ShowPersonLicenseHistoryLL);
            this.Controls.Add(this.driverLicenseInfo1);
            this.Controls.Add(this.OKB);
            this.Controls.Add(this.LicenseIDTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InternationalLicenseApplication";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "International License Application";
                        // Dark Mode Injection
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.OKB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OKB.FlatAppearance.BorderSize = 0;
            this.OKB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.OKB.ForeColor = System.Drawing.Color.White;
            this.OKB.UseVisualStyleBackColor = false;
            this.IssueB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IssueB.FlatAppearance.BorderSize = 0;
            this.IssueB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.IssueB.ForeColor = System.Drawing.Color.White;
            this.IssueB.UseVisualStyleBackColor = false;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button OKB;
        private System.Windows.Forms.TextBox LicenseIDTB;
        private System.Windows.Forms.Label label1;
        private DriverInfo driverLicenseInfo1;
        private System.Windows.Forms.LinkLabel ShowPersonLicenseHistoryLL;
        private System.Windows.Forms.LinkLabel ShowInternationalLicenseLL;
        private System.Windows.Forms.Button IssueB;
        private ApplicationInfo applicationInfo1;
    }
}
