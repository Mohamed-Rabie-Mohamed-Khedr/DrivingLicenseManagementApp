namespace DrivingLicenseManagement
{
    partial class AddAndUpdateAppointmentForm
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
            this.TitleL = new System.Windows.Forms.Label();
            this.DLAppIDL = new System.Windows.Forms.Label();
            this.DClasseL = new System.Windows.Forms.Label();
            this.NameL = new System.Windows.Forms.Label();
            this.TrialL = new System.Windows.Forms.Label();
            this.DateL = new System.Windows.Forms.Label();
            this.FeesL = new System.Windows.Forms.Label();
            this.DateDTP = new System.Windows.Forms.DateTimePicker();
            this.SaveB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TitleL
            // 
            this.TitleL.AutoSize = true;
            this.TitleL.BackColor = System.Drawing.Color.Transparent;
            this.TitleL.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleL.ForeColor = System.Drawing.Color.Coral;
            this.TitleL.Location = new System.Drawing.Point(244, 32);
            this.TitleL.Name = "TitleL";
            this.TitleL.Size = new System.Drawing.Size(270, 35);
            this.TitleL.TabIndex = 43;
            this.TitleL.Text = "Add Appointment";
            // 
            // DLAppIDL
            // 
            this.DLAppIDL.AutoSize = true;
            this.DLAppIDL.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DLAppIDL.ForeColor = System.Drawing.Color.White;
            this.DLAppIDL.Location = new System.Drawing.Point(246, 115);
            this.DLAppIDL.Name = "DLAppIDL";
            this.DLAppIDL.Size = new System.Drawing.Size(107, 23);
            this.DLAppIDL.TabIndex = 44;
            this.DLAppIDL.Text = "D.LApp ID";
            // 
            // DClasseL
            // 
            this.DClasseL.AutoSize = true;
            this.DClasseL.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DClasseL.ForeColor = System.Drawing.Color.White;
            this.DClasseL.Location = new System.Drawing.Point(246, 159);
            this.DClasseL.Name = "DClasseL";
            this.DClasseL.Size = new System.Drawing.Size(97, 23);
            this.DClasseL.TabIndex = 45;
            this.DClasseL.Text = "D. Classe";
            // 
            // NameL
            // 
            this.NameL.AutoSize = true;
            this.NameL.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameL.ForeColor = System.Drawing.Color.White;
            this.NameL.Location = new System.Drawing.Point(246, 203);
            this.NameL.Name = "NameL";
            this.NameL.Size = new System.Drawing.Size(65, 23);
            this.NameL.TabIndex = 46;
            this.NameL.Text = "Name";
            // 
            // TrialL
            // 
            this.TrialL.AutoSize = true;
            this.TrialL.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TrialL.ForeColor = System.Drawing.Color.White;
            this.TrialL.Location = new System.Drawing.Point(246, 247);
            this.TrialL.Name = "TrialL";
            this.TrialL.Size = new System.Drawing.Size(78, 23);
            this.TrialL.TabIndex = 47;
            this.TrialL.Text = "Trial: 0";
            // 
            // DateL
            // 
            this.DateL.AutoSize = true;
            this.DateL.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateL.ForeColor = System.Drawing.Color.White;
            this.DateL.Location = new System.Drawing.Point(246, 291);
            this.DateL.Name = "DateL";
            this.DateL.Size = new System.Drawing.Size(54, 23);
            this.DateL.TabIndex = 48;
            this.DateL.Text = "Date";
            // 
            // FeesL
            // 
            this.FeesL.AutoSize = true;
            this.FeesL.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FeesL.ForeColor = System.Drawing.Color.White;
            this.FeesL.Location = new System.Drawing.Point(245, 335);
            this.FeesL.Name = "FeesL";
            this.FeesL.Size = new System.Drawing.Size(53, 23);
            this.FeesL.TabIndex = 49;
            this.FeesL.Text = "Fees";
            // 
            // DateDTP
            // 
            this.DateDTP.Location = new System.Drawing.Point(306, 293);
            this.DateDTP.Name = "DateDTP";
            this.DateDTP.Size = new System.Drawing.Size(200, 20);
            this.DateDTP.TabIndex = 50;
            // 
            // SaveB
            // 
            this.SaveB.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveB.Location = new System.Drawing.Point(647, 405);
            this.SaveB.Name = "SaveB";
            this.SaveB.Size = new System.Drawing.Size(86, 41);
            this.SaveB.TabIndex = 52;
            this.SaveB.Text = "SAVE";
            this.SaveB.UseVisualStyleBackColor = true;
            this.SaveB.Click += new System.EventHandler(this.SaveB_Click);
            // 
            // AddAndUpdateAppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 461);
            this.Controls.Add(this.SaveB);
            this.Controls.Add(this.DateDTP);
            this.Controls.Add(this.FeesL);
            this.Controls.Add(this.DateL);
            this.Controls.Add(this.TrialL);
            this.Controls.Add(this.NameL);
            this.Controls.Add(this.DClasseL);
            this.Controls.Add(this.DLAppIDL);
            this.Controls.Add(this.TitleL);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddAndUpdateAppointmentForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Appointment";
            this.Load += new System.EventHandler(this.AddAppointmentForm_Load);
                        // Dark Mode Injection
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.SaveB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveB.FlatAppearance.BorderSize = 0;
            this.SaveB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.SaveB.ForeColor = System.Drawing.Color.White;
            this.SaveB.UseVisualStyleBackColor = false;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleL;
        private System.Windows.Forms.Label DLAppIDL;
        private System.Windows.Forms.Label DClasseL;
        private System.Windows.Forms.Label NameL;
        private System.Windows.Forms.Label TrialL;
        private System.Windows.Forms.Label DateL;
        private System.Windows.Forms.Label FeesL;
        private System.Windows.Forms.DateTimePicker DateDTP;
        private System.Windows.Forms.Button SaveB;
    }
}
