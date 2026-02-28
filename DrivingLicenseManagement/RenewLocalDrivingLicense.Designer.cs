namespace DrivingLicenseManagement
{
    partial class RenewLocalDrivingLicense
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
            this.ShowNewLicenseLL = new System.Windows.Forms.LinkLabel();
            this.IssueB = new System.Windows.Forms.Button();
            this.newLicenseApplicationInfo1 = new DrivingLicenseManagement.NewLicenseApplicationInfo();
            this.driverInfo1 = new DrivingLicenseManagement.DriverInfo();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Coral;
            this.label3.Location = new System.Drawing.Point(372, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(434, 35);
            this.label3.TabIndex = 43;
            this.label3.Text = "Renew Local Driving License";
            // 
            // OKB
            // 
            this.OKB.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OKB.Location = new System.Drawing.Point(244, 50);
            this.OKB.Name = "OKB";
            this.OKB.Size = new System.Drawing.Size(86, 34);
            this.OKB.TabIndex = 56;
            this.OKB.Text = "OK";
            this.OKB.UseVisualStyleBackColor = true;
            this.OKB.Click += new System.EventHandler(this.OKB_Click);
            // 
            // LicenseIDTB
            // 
            this.LicenseIDTB.Location = new System.Drawing.Point(78, 56);
            this.LicenseIDTB.Name = "LicenseIDTB";
            this.LicenseIDTB.Size = new System.Drawing.Size(155, 20);
            this.LicenseIDTB.TabIndex = 55;
            this.LicenseIDTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LicenseIDTB_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(73, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 25);
            this.label1.TabIndex = 54;
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
            this.ShowPersonLicenseHistoryLL.Location = new System.Drawing.Point(12, 807);
            this.ShowPersonLicenseHistoryLL.Name = "ShowPersonLicenseHistoryLL";
            this.ShowPersonLicenseHistoryLL.Size = new System.Drawing.Size(242, 19);
            this.ShowPersonLicenseHistoryLL.TabIndex = 58;
            this.ShowPersonLicenseHistoryLL.TabStop = true;
            this.ShowPersonLicenseHistoryLL.Text = "Show Person License History";
            this.ShowPersonLicenseHistoryLL.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ShowPersonLicenseHistoryLL_LinkClicked);
            // 
            // ShowNewLicenseLL
            // 
            this.ShowNewLicenseLL.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ShowNewLicenseLL.AutoSize = true;
            this.ShowNewLicenseLL.Enabled = false;
            this.ShowNewLicenseLL.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowNewLicenseLL.Location = new System.Drawing.Point(361, 807);
            this.ShowNewLicenseLL.Name = "ShowNewLicenseLL";
            this.ShowNewLicenseLL.Size = new System.Drawing.Size(159, 19);
            this.ShowNewLicenseLL.TabIndex = 60;
            this.ShowNewLicenseLL.TabStop = true;
            this.ShowNewLicenseLL.Text = "Show New License";
            this.ShowNewLicenseLL.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ShowNewLicenseLL_LinkClicked);
            // 
            // IssueB
            // 
            this.IssueB.Enabled = false;
            this.IssueB.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IssueB.Location = new System.Drawing.Point(1042, 798);
            this.IssueB.Name = "IssueB";
            this.IssueB.Size = new System.Drawing.Size(86, 34);
            this.IssueB.TabIndex = 61;
            this.IssueB.Text = "Issue";
            this.IssueB.UseVisualStyleBackColor = true;
            this.IssueB.Click += new System.EventHandler(this.IssueB_Click);
            // 
            // newLicenseApplicationInfo1
            // 
            this.newLicenseApplicationInfo1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.newLicenseApplicationInfo1.Location = new System.Drawing.Point(16, 462);
            this.newLicenseApplicationInfo1.Name = "newLicenseApplicationInfo1";
            this.newLicenseApplicationInfo1.Size = new System.Drawing.Size(1074, 304);
            this.newLicenseApplicationInfo1.TabIndex = 59;
            // 
            // driverInfo1
            // 
            this.driverInfo1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.driverInfo1.Location = new System.Drawing.Point(12, 88);
            this.driverInfo1.Name = "driverInfo1";
            this.driverInfo1.Size = new System.Drawing.Size(1116, 368);
            this.driverInfo1.TabIndex = 57;
            // 
            // RenewLocalDrivingLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 835);
            this.Controls.Add(this.IssueB);
            this.Controls.Add(this.ShowNewLicenseLL);
            this.Controls.Add(this.newLicenseApplicationInfo1);
            this.Controls.Add(this.ShowPersonLicenseHistoryLL);
            this.Controls.Add(this.driverInfo1);
            this.Controls.Add(this.OKB);
            this.Controls.Add(this.LicenseIDTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RenewLocalDrivingLicense";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Renew Local Driving License";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button OKB;
        private System.Windows.Forms.TextBox LicenseIDTB;
        private System.Windows.Forms.Label label1;
        private DriverInfo driverInfo1;
        private System.Windows.Forms.LinkLabel ShowPersonLicenseHistoryLL;
        private NewLicenseApplicationInfo newLicenseApplicationInfo1;
        private System.Windows.Forms.LinkLabel ShowNewLicenseLL;
        private System.Windows.Forms.Button IssueB;
    }
}