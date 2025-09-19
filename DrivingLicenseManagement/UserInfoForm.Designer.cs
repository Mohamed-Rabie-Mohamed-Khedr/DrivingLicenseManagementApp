namespace DrivingLicenseManagement
{
    partial class UserInfoForm
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
            this.SuspendLayout();
            // 
            // user_Info1
            // 
            this.user_Info1.BackColor = System.Drawing.Color.Transparent;
            this.user_Info1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.user_Info1.Location = new System.Drawing.Point(0, 432);
            this.user_Info1.Margin = new System.Windows.Forms.Padding(4);
            this.user_Info1.Name = "user_Info1";
            this.user_Info1.Size = new System.Drawing.Size(855, 150);
            this.user_Info1.TabIndex = 16;
            // 
            // personInfo1
            // 
            this.personInfo1.BackColor = System.Drawing.Color.Transparent;
            this.personInfo1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.personInfo1.Location = new System.Drawing.Point(0, 0);
            this.personInfo1.Margin = new System.Windows.Forms.Padding(4);
            this.personInfo1.Name = "personInfo1";
            this.personInfo1.Size = new System.Drawing.Size(855, 582);
            this.personInfo1.TabIndex = 15;
            // 
            // UserInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(855, 582);
            this.Controls.Add(this.user_Info1);
            this.Controls.Add(this.personInfo1);
            this.Name = "UserInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Info";
            this.ResumeLayout(false);

        }

        #endregion

        private User_Info user_Info1;
        private PersonInfo personInfo1;
    }
}