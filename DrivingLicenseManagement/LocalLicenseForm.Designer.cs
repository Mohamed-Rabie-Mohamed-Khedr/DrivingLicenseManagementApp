namespace DrivingLicenseManagement
{
    partial class LocalLicenseForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Next = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.SaveB = new System.Windows.Forms.Button();
            this.LicenseClassCB = new System.Windows.Forms.ComboBox();
            this.CreatedByL = new System.Windows.Forms.Label();
            this.ApplicationFeesL = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ApplicationDateL = new System.Windows.Forms.Label();
            this.ApplicationIDL = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1185, 736);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControl1_Selecting);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.DimGray;
            this.tabPage1.Controls.Add(this.Next);
            this.tabPage1.ForeColor = System.Drawing.Color.Black;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1177, 710);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Person Info";
            // 
            // Next
            // 
            this.Next.ForeColor = System.Drawing.Color.Black;
            this.Next.Location = new System.Drawing.Point(1073, 659);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(86, 34);
            this.Next.TabIndex = 47;
            this.Next.Text = "Next";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.DimGray;
            this.tabPage2.Controls.Add(this.SaveB);
            this.tabPage2.Controls.Add(this.LicenseClassCB);
            this.tabPage2.Controls.Add(this.CreatedByL);
            this.tabPage2.Controls.Add(this.ApplicationFeesL);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.ApplicationDateL);
            this.tabPage2.Controls.Add(this.ApplicationIDL);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1177, 710);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Application Info";
            // 
            // SaveB
            // 
            this.SaveB.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveB.Location = new System.Drawing.Point(1073, 661);
            this.SaveB.Name = "SaveB";
            this.SaveB.Size = new System.Drawing.Size(86, 41);
            this.SaveB.TabIndex = 36;
            this.SaveB.Text = "SAVE";
            this.SaveB.UseVisualStyleBackColor = true;
            this.SaveB.Click += new System.EventHandler(this.Save_Click);
            // 
            // LicenseClassCB
            // 
            this.LicenseClassCB.FormattingEnabled = true;
            this.LicenseClassCB.Location = new System.Drawing.Point(452, 305);
            this.LicenseClassCB.Name = "LicenseClassCB";
            this.LicenseClassCB.Size = new System.Drawing.Size(220, 21);
            this.LicenseClassCB.TabIndex = 35;
            // 
            // CreatedByL
            // 
            this.CreatedByL.AutoSize = true;
            this.CreatedByL.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreatedByL.ForeColor = System.Drawing.Color.White;
            this.CreatedByL.Location = new System.Drawing.Point(205, 388);
            this.CreatedByL.Name = "CreatedByL";
            this.CreatedByL.Size = new System.Drawing.Size(114, 23);
            this.CreatedByL.TabIndex = 5;
            this.CreatedByL.Text = "Created By";
            // 
            // ApplicationFeesL
            // 
            this.ApplicationFeesL.AutoSize = true;
            this.ApplicationFeesL.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApplicationFeesL.ForeColor = System.Drawing.Color.White;
            this.ApplicationFeesL.Location = new System.Drawing.Point(205, 344);
            this.ApplicationFeesL.Name = "ApplicationFeesL";
            this.ApplicationFeesL.Size = new System.Drawing.Size(198, 23);
            this.ApplicationFeesL.TabIndex = 4;
            this.ApplicationFeesL.Text = "ApplicationFees: 15";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(205, 300);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "License Class";
            // 
            // ApplicationDateL
            // 
            this.ApplicationDateL.AutoSize = true;
            this.ApplicationDateL.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApplicationDateL.ForeColor = System.Drawing.Color.White;
            this.ApplicationDateL.Location = new System.Drawing.Point(205, 256);
            this.ApplicationDateL.Name = "ApplicationDateL";
            this.ApplicationDateL.Size = new System.Drawing.Size(168, 23);
            this.ApplicationDateL.TabIndex = 2;
            this.ApplicationDateL.Text = "Application Date";
            // 
            // ApplicationIDL
            // 
            this.ApplicationIDL.AutoSize = true;
            this.ApplicationIDL.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApplicationIDL.ForeColor = System.Drawing.Color.White;
            this.ApplicationIDL.Location = new System.Drawing.Point(205, 209);
            this.ApplicationIDL.Name = "ApplicationIDL";
            this.ApplicationIDL.Size = new System.Drawing.Size(195, 23);
            this.ApplicationIDL.TabIndex = 1;
            this.ApplicationIDL.Text = "LDL. Application ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Coral;
            this.label1.Location = new System.Drawing.Point(447, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(371, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "New Local Driving Application";
            // 
            // LocalLicenseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1185, 736);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LocalLicenseForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Local License Form";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ApplicationIDL;
        private System.Windows.Forms.Label ApplicationDateL;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label ApplicationFeesL;
        private System.Windows.Forms.Label CreatedByL;
        private System.Windows.Forms.ComboBox LicenseClassCB;
        private System.Windows.Forms.Button SaveB;
    }
}