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
            this.changePassword1 = new DrivingLicenseManagement.ChangePassword();
            this.SuspendLayout();
            // 
            // changePassword1
            // 
            this.changePassword1.BackColor = System.Drawing.Color.Transparent;
            this.changePassword1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.changePassword1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.changePassword1.Location = new System.Drawing.Point(0, 577);
            this.changePassword1.Name = "changePassword1";
            this.changePassword1.Size = new System.Drawing.Size(1119, 280);
            this.changePassword1.TabIndex = 2;
            // 
            // ChangePasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1119, 857);
            this.Controls.Add(this.changePassword1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChangePasswordForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change Password";
            this.ResumeLayout(false);

        }

        #endregion
        private ChangePassword changePassword1;
    }
}