namespace DrivingLicenseManagement
{
    partial class User_Info
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
            this.IsActiveL = new System.Windows.Forms.Label();
            this.UserNameL = new System.Windows.Forms.Label();
            this.UserIDL = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // IsActiveL
            // 
            this.IsActiveL.AutoSize = true;
            this.IsActiveL.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsActiveL.ForeColor = System.Drawing.Color.White;
            this.IsActiveL.Location = new System.Drawing.Point(17, 199);
            this.IsActiveL.Name = "IsActiveL";
            this.IsActiveL.Size = new System.Drawing.Size(94, 23);
            this.IsActiveL.TabIndex = 7;
            this.IsActiveL.Text = "Is Active";
            // 
            // UserNameL
            // 
            this.UserNameL.AutoSize = true;
            this.UserNameL.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameL.ForeColor = System.Drawing.Color.White;
            this.UserNameL.Location = new System.Drawing.Point(17, 144);
            this.UserNameL.Name = "UserNameL";
            this.UserNameL.Size = new System.Drawing.Size(114, 23);
            this.UserNameL.TabIndex = 6;
            this.UserNameL.Text = "User Name";
            // 
            // UserIDL
            // 
            this.UserIDL.AutoSize = true;
            this.UserIDL.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserIDL.ForeColor = System.Drawing.Color.White;
            this.UserIDL.Location = new System.Drawing.Point(17, 89);
            this.UserIDL.Name = "UserIDL";
            this.UserIDL.Size = new System.Drawing.Size(82, 23);
            this.UserIDL.TabIndex = 5;
            this.UserIDL.Text = "User ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Coral;
            this.label1.Location = new System.Drawing.Point(17, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "User Info";
            // 
            // User_Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.IsActiveL);
            this.Controls.Add(this.UserNameL);
            this.Controls.Add(this.UserIDL);
            this.Controls.Add(this.label1);
            this.Name = "User_Info";
            this.Size = new System.Drawing.Size(577, 291);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IsActiveL;
        private System.Windows.Forms.Label UserNameL;
        private System.Windows.Forms.Label UserIDL;
        private System.Windows.Forms.Label label1;
    }
}
