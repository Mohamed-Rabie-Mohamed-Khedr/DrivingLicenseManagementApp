namespace DrivingLicenseManagement
{
    partial class DetainInfo
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label3 = new System.Windows.Forms.Label();
            this.DetainIDL = new System.Windows.Forms.Label();
            this.DetainDateL = new System.Windows.Forms.Label();
            this.FineFeesL = new System.Windows.Forms.Label();
            this.CreatedByL = new System.Windows.Forms.Label();
            this.LicenseIDL = new System.Windows.Forms.Label();
            this.FineFeeNUD = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.FineFeeNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Coral;
            this.label3.Location = new System.Drawing.Point(25, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 23);
            this.label3.TabIndex = 44;
            this.label3.Text = "Detain Info";
            // 
            // DetainIDL
            // 
            this.DetainIDL.AutoSize = true;
            this.DetainIDL.BackColor = System.Drawing.Color.Transparent;
            this.DetainIDL.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DetainIDL.ForeColor = System.Drawing.Color.Black;
            this.DetainIDL.Location = new System.Drawing.Point(36, 52);
            this.DetainIDL.Name = "DetainIDL";
            this.DetainIDL.Size = new System.Drawing.Size(87, 19);
            this.DetainIDL.TabIndex = 45;
            this.DetainIDL.Text = "Detain ID";
            // 
            // DetainDateL
            // 
            this.DetainDateL.AutoSize = true;
            this.DetainDateL.BackColor = System.Drawing.Color.Transparent;
            this.DetainDateL.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DetainDateL.ForeColor = System.Drawing.Color.Black;
            this.DetainDateL.Location = new System.Drawing.Point(36, 87);
            this.DetainDateL.Name = "DetainDateL";
            this.DetainDateL.Size = new System.Drawing.Size(107, 19);
            this.DetainDateL.TabIndex = 46;
            this.DetainDateL.Text = "Detain Date";
            // 
            // FineFeesL
            // 
            this.FineFeesL.AutoSize = true;
            this.FineFeesL.BackColor = System.Drawing.Color.Transparent;
            this.FineFeesL.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FineFeesL.ForeColor = System.Drawing.Color.Black;
            this.FineFeesL.Location = new System.Drawing.Point(36, 120);
            this.FineFeesL.Name = "FineFeesL";
            this.FineFeesL.Size = new System.Drawing.Size(85, 19);
            this.FineFeesL.TabIndex = 47;
            this.FineFeesL.Text = "Fine Fees";
            // 
            // CreatedByL
            // 
            this.CreatedByL.AutoSize = true;
            this.CreatedByL.BackColor = System.Drawing.Color.Transparent;
            this.CreatedByL.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreatedByL.ForeColor = System.Drawing.Color.Black;
            this.CreatedByL.Location = new System.Drawing.Point(333, 87);
            this.CreatedByL.Name = "CreatedByL";
            this.CreatedByL.Size = new System.Drawing.Size(99, 19);
            this.CreatedByL.TabIndex = 49;
            this.CreatedByL.Text = "Created By";
            // 
            // LicenseIDL
            // 
            this.LicenseIDL.AutoSize = true;
            this.LicenseIDL.BackColor = System.Drawing.Color.Transparent;
            this.LicenseIDL.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LicenseIDL.ForeColor = System.Drawing.Color.Black;
            this.LicenseIDL.Location = new System.Drawing.Point(333, 52);
            this.LicenseIDL.Name = "LicenseIDL";
            this.LicenseIDL.Size = new System.Drawing.Size(93, 19);
            this.LicenseIDL.TabIndex = 48;
            this.LicenseIDL.Text = "License ID";
            // 
            // FineFeeNUD
            // 
            this.FineFeeNUD.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FineFeeNUD.Location = new System.Drawing.Point(139, 122);
            this.FineFeeNUD.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.FineFeeNUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.FineFeeNUD.Name = "FineFeeNUD";
            this.FineFeeNUD.Size = new System.Drawing.Size(120, 22);
            this.FineFeeNUD.TabIndex = 50;
            this.FineFeeNUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // DetainInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.FineFeeNUD);
            this.Controls.Add(this.CreatedByL);
            this.Controls.Add(this.LicenseIDL);
            this.Controls.Add(this.FineFeesL);
            this.Controls.Add(this.DetainDateL);
            this.Controls.Add(this.DetainIDL);
            this.Controls.Add(this.label3);
            this.Name = "DetainInfo";
            this.Size = new System.Drawing.Size(577, 170);
            ((System.ComponentModel.ISupportInitialize)(this.FineFeeNUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label DetainIDL;
        private System.Windows.Forms.Label DetainDateL;
        private System.Windows.Forms.Label FineFeesL;
        private System.Windows.Forms.Label CreatedByL;
        private System.Windows.Forms.Label LicenseIDL;
        private System.Windows.Forms.NumericUpDown FineFeeNUD;
    }
}
