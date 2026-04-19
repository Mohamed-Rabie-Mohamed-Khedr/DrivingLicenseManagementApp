namespace DrivingLicenseManagement
{
    partial class ReleaseDetainedLicenseForm
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
            this.ReleaseB = new System.Windows.Forms.Button();
            this.ShowLicenseLL = new System.Windows.Forms.LinkLabel();
            this.ShowPersonLicenseHistoryLL = new System.Windows.Forms.LinkLabel();
            this.LicenseIDL = new System.Windows.Forms.Label();
            this.driverInfo1 = new DrivingLicenseManagement.DriverInfo();
            this.OKB = new System.Windows.Forms.Button();
            this.LicenseIDTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.releaseDetainedLicense1 = new DrivingLicenseManagement.ReleaseDetainedLicense();
            this.SuspendLayout();
            // 
            // ReleaseB
            // 
            this.ReleaseB.Enabled = false;
            this.ReleaseB.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReleaseB.Location = new System.Drawing.Point(1026, 674);
            this.ReleaseB.Name = "ReleaseB";
            this.ReleaseB.Size = new System.Drawing.Size(97, 34);
            this.ReleaseB.TabIndex = 80;
            this.ReleaseB.Text = "Release";
            this.ReleaseB.UseVisualStyleBackColor = true;
            this.ReleaseB.Click += new System.EventHandler(this.ReleaseB_Click);
            // 
            // ShowLicenseLL
            // 
            this.ShowLicenseLL.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ShowLicenseLL.AutoSize = true;
            this.ShowLicenseLL.Enabled = false;
            this.ShowLicenseLL.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowLicenseLL.Location = new System.Drawing.Point(356, 683);
            this.ShowLicenseLL.Name = "ShowLicenseLL";
            this.ShowLicenseLL.Size = new System.Drawing.Size(118, 19);
            this.ShowLicenseLL.TabIndex = 79;
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
            this.ShowPersonLicenseHistoryLL.Location = new System.Drawing.Point(7, 683);
            this.ShowPersonLicenseHistoryLL.Name = "ShowPersonLicenseHistoryLL";
            this.ShowPersonLicenseHistoryLL.Size = new System.Drawing.Size(242, 19);
            this.ShowPersonLicenseHistoryLL.TabIndex = 78;
            this.ShowPersonLicenseHistoryLL.TabStop = true;
            this.ShowPersonLicenseHistoryLL.Text = "Show Person License History";
            this.ShowPersonLicenseHistoryLL.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ShowPersonLicenseHistoryLL_LinkClicked);
            // 
            // LicenseIDL
            // 
            this.LicenseIDL.AutoSize = true;
            this.LicenseIDL.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LicenseIDL.Location = new System.Drawing.Point(9, 42);
            this.LicenseIDL.Name = "LicenseIDL";
            this.LicenseIDL.Size = new System.Drawing.Size(110, 23);
            this.LicenseIDL.TabIndex = 76;
            this.LicenseIDL.Text = "License ID";
            // 
            // driverInfo1
            // 
            this.driverInfo1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.driverInfo1.Location = new System.Drawing.Point(7, 81);
            this.driverInfo1.Name = "driverInfo1";
            this.driverInfo1.Size = new System.Drawing.Size(1116, 368);
            this.driverInfo1.TabIndex = 75;
            // 
            // OKB
            // 
            this.OKB.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OKB.Location = new System.Drawing.Point(294, 39);
            this.OKB.Name = "OKB";
            this.OKB.Size = new System.Drawing.Size(86, 34);
            this.OKB.TabIndex = 74;
            this.OKB.Text = "OK";
            this.OKB.UseVisualStyleBackColor = true;
            this.OKB.Click += new System.EventHandler(this.OKB_Click);
            // 
            // LicenseIDTB
            // 
            this.LicenseIDTB.Location = new System.Drawing.Point(128, 45);
            this.LicenseIDTB.Name = "LicenseIDTB";
            this.LicenseIDTB.Size = new System.Drawing.Size(155, 20);
            this.LicenseIDTB.TabIndex = 73;
            this.LicenseIDTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LicenseIDTB_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Coral;
            this.label3.Location = new System.Drawing.Point(435, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(386, 35);
            this.label3.TabIndex = 72;
            this.label3.Text = "Release Detained License";
            // 
            // releaseDetainedLicense1
            // 
            this.releaseDetainedLicense1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.releaseDetainedLicense1.Location = new System.Drawing.Point(7, 455);
            this.releaseDetainedLicense1.Name = "releaseDetainedLicense1";
            this.releaseDetainedLicense1.Size = new System.Drawing.Size(579, 188);
            this.releaseDetainedLicense1.TabIndex = 81;
            // 
            // ReleaseDetainedLicenseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 714);
            this.Controls.Add(this.releaseDetainedLicense1);
            this.Controls.Add(this.ReleaseB);
            this.Controls.Add(this.ShowLicenseLL);
            this.Controls.Add(this.ShowPersonLicenseHistoryLL);
            this.Controls.Add(this.LicenseIDL);
            this.Controls.Add(this.driverInfo1);
            this.Controls.Add(this.OKB);
            this.Controls.Add(this.LicenseIDTB);
            this.Controls.Add(this.label3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReleaseDetainedLicenseForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Release Detained License";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ReleaseB;
        private System.Windows.Forms.LinkLabel ShowLicenseLL;
        private System.Windows.Forms.LinkLabel ShowPersonLicenseHistoryLL;
        private System.Windows.Forms.Label LicenseIDL;
        private DriverInfo driverInfo1;
        private System.Windows.Forms.Button OKB;
        private System.Windows.Forms.TextBox LicenseIDTB;
        private System.Windows.Forms.Label label3;
        private ReleaseDetainedLicense releaseDetainedLicense1;
    }
}