namespace DrivingLicenseManagement
{
    partial class ReplacementForDamagedOrLicenseForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.IssueB = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.applicationInfoForLicenseReplacement1 = new DrivingLicenseManagement.ApplicationInfoForLicenseReplacement();
            this.driverInfo1 = new DrivingLicenseManagement.DriverInfo();
            this.LicenseIDL = new System.Windows.Forms.Label();
            this.OKB = new System.Windows.Forms.Button();
            this.LicenseIDTB = new System.Windows.Forms.TextBox();
            this.ShowNewLicenseLL = new System.Windows.Forms.LinkLabel();
            this.ShowPersonLicenseHistoryLL = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(394, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(408, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Replacement For Damaged Or License";
            // 
            // IssueB
            // 
            this.IssueB.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IssueB.Location = new System.Drawing.Point(1043, 650);
            this.IssueB.Name = "IssueB";
            this.IssueB.Size = new System.Drawing.Size(86, 41);
            this.IssueB.TabIndex = 67;
            this.IssueB.Text = "Issue";
            this.IssueB.UseVisualStyleBackColor = true;
            this.IssueB.Click += new System.EventHandler(this.IssueB_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(880, 492);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(146, 27);
            this.radioButton1.TabIndex = 68;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Lost License";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(880, 525);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(194, 27);
            this.radioButton2.TabIndex = 69;
            this.radioButton2.Text = "Damaged License";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // applicationInfoForLicenseReplacement1
            // 
            this.applicationInfoForLicenseReplacement1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.applicationInfoForLicenseReplacement1.Location = new System.Drawing.Point(55, 469);
            this.applicationInfoForLicenseReplacement1.Name = "applicationInfoForLicenseReplacement1";
            this.applicationInfoForLicenseReplacement1.Size = new System.Drawing.Size(819, 170);
            this.applicationInfoForLicenseReplacement1.TabIndex = 16;
            // 
            // driverInfo1
            // 
            this.driverInfo1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.driverInfo1.Location = new System.Drawing.Point(12, 95);
            this.driverInfo1.Name = "driverInfo1";
            this.driverInfo1.Size = new System.Drawing.Size(1116, 368);
            this.driverInfo1.TabIndex = 15;
            // 
            // LicenseIDL
            // 
            this.LicenseIDL.AutoSize = true;
            this.LicenseIDL.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LicenseIDL.Location = new System.Drawing.Point(78, 58);
            this.LicenseIDL.Name = "LicenseIDL";
            this.LicenseIDL.Size = new System.Drawing.Size(110, 23);
            this.LicenseIDL.TabIndex = 72;
            this.LicenseIDL.Text = "License ID";
            // 
            // OKB
            // 
            this.OKB.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OKB.Location = new System.Drawing.Point(363, 55);
            this.OKB.Name = "OKB";
            this.OKB.Size = new System.Drawing.Size(86, 34);
            this.OKB.TabIndex = 71;
            this.OKB.Text = "OK";
            this.OKB.UseVisualStyleBackColor = true;
            this.OKB.Click += new System.EventHandler(this.OKB_Click);
            // 
            // LicenseIDTB
            // 
            this.LicenseIDTB.Location = new System.Drawing.Point(197, 61);
            this.LicenseIDTB.Name = "LicenseIDTB";
            this.LicenseIDTB.Size = new System.Drawing.Size(155, 20);
            this.LicenseIDTB.TabIndex = 70;
            this.LicenseIDTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LicenseIDTB_KeyPress);
            // 
            // ShowNewLicenseLL
            // 
            this.ShowNewLicenseLL.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ShowNewLicenseLL.AutoSize = true;
            this.ShowNewLicenseLL.Enabled = false;
            this.ShowNewLicenseLL.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowNewLicenseLL.Location = new System.Drawing.Point(400, 662);
            this.ShowNewLicenseLL.Name = "ShowNewLicenseLL";
            this.ShowNewLicenseLL.Size = new System.Drawing.Size(159, 19);
            this.ShowNewLicenseLL.TabIndex = 74;
            this.ShowNewLicenseLL.TabStop = true;
            this.ShowNewLicenseLL.Text = "Show New License";
            this.ShowNewLicenseLL.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ShowNewLicenseLL_LinkClicked);
            // 
            // ShowPersonLicenseHistoryLL
            // 
            this.ShowPersonLicenseHistoryLL.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ShowPersonLicenseHistoryLL.AutoSize = true;
            this.ShowPersonLicenseHistoryLL.Enabled = false;
            this.ShowPersonLicenseHistoryLL.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowPersonLicenseHistoryLL.Location = new System.Drawing.Point(51, 662);
            this.ShowPersonLicenseHistoryLL.Name = "ShowPersonLicenseHistoryLL";
            this.ShowPersonLicenseHistoryLL.Size = new System.Drawing.Size(242, 19);
            this.ShowPersonLicenseHistoryLL.TabIndex = 73;
            this.ShowPersonLicenseHistoryLL.TabStop = true;
            this.ShowPersonLicenseHistoryLL.Text = "Show Person License History";
            this.ShowPersonLicenseHistoryLL.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ShowPersonLicenseHistoryLL_LinkClicked);
            // 
            // ReplacementForDamagedOrLicenseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 703);
            this.Controls.Add(this.ShowNewLicenseLL);
            this.Controls.Add(this.ShowPersonLicenseHistoryLL);
            this.Controls.Add(this.LicenseIDL);
            this.Controls.Add(this.OKB);
            this.Controls.Add(this.LicenseIDTB);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.IssueB);
            this.Controls.Add(this.applicationInfoForLicenseReplacement1);
            this.Controls.Add(this.driverInfo1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReplacementForDamagedOrLicenseForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Replacement For Damaged Or License";
            this.Load += new System.EventHandler(this.ReplacementForDamagedOrLicenseForm_Load);
                        // Dark Mode Injection
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.IssueB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IssueB.FlatAppearance.BorderSize = 0;
            this.IssueB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.IssueB.ForeColor = System.Drawing.Color.White;
            this.IssueB.UseVisualStyleBackColor = false;
            this.OKB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OKB.FlatAppearance.BorderSize = 0;
            this.OKB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.OKB.ForeColor = System.Drawing.Color.White;
            this.OKB.UseVisualStyleBackColor = false;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DriverInfo driverInfo1;
        private ApplicationInfoForLicenseReplacement applicationInfoForLicenseReplacement1;
        private System.Windows.Forms.Button IssueB;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label LicenseIDL;
        private System.Windows.Forms.Button OKB;
        private System.Windows.Forms.TextBox LicenseIDTB;
        private System.Windows.Forms.LinkLabel ShowNewLicenseLL;
        private System.Windows.Forms.LinkLabel ShowPersonLicenseHistoryLL;
    }
}
