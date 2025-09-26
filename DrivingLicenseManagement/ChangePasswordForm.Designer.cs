namespace DrivingLicenseManagement
{
    partial class ChangePasswordForm
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
            this.user_Info1 = new DrivingLicenseManagement.User_Info();
            this.personInfo1 = new DrivingLicenseManagement.PersonInfo();
            this.changePassword1 = new DrivingLicenseManagement.ChangePassword();
            this.SuspendLayout();
            // 
            // user_Info1
            // 
            this.user_Info1.BackColor = System.Drawing.Color.Transparent;
            this.user_Info1.Location = new System.Drawing.Point(12, 388);
            this.user_Info1.Name = "user_Info1";
            this.user_Info1.Size = new System.Drawing.Size(579, 293);
            this.user_Info1.TabIndex = 1;
            // 
            // personInfo1
            // 
            this.personInfo1.BackColor = System.Drawing.Color.Transparent;
            this.personInfo1.Location = new System.Drawing.Point(1, 12);
            this.personInfo1.Name = "personInfo1";
            this.personInfo1.Size = new System.Drawing.Size(921, 370);
            this.personInfo1.TabIndex = 0;
            // 
            // changePassword1
            // 
            this.changePassword1.BackColor = System.Drawing.Color.Transparent;
            this.changePassword1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.changePassword1.Location = new System.Drawing.Point(616, 388);
            this.changePassword1.Name = "changePassword1";
            this.changePassword1.Size = new System.Drawing.Size(489, 379);
            this.changePassword1.TabIndex = 2;
            // 
            // ChangePasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1119, 791);
            this.Controls.Add(this.changePassword1);
            this.Controls.Add(this.user_Info1);
            this.Controls.Add(this.personInfo1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChangePasswordForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change Password";
            this.ResumeLayout(false);

        }

        #endregion

        private PersonInfo personInfo1;
        private User_Info user_Info1;
        private ChangePassword changePassword1;
    }
}