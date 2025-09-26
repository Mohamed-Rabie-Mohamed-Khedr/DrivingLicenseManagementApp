using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrivingLicenseManagement
{
    public partial class ChangePassword : UserControl
    {
        internal User CUser = null;
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void SaveB_Click(object sender, EventArgs e)
        {
            if (CUser.Password != CurrentPasswordTB.Text)
                MessageBox.Show("Wrong Current Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (string.IsNullOrEmpty(PasswordTB.Text) || string.IsNullOrEmpty(ConfirmPasswordTB.Text))
                MessageBox.Show("Please Enter Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (PasswordTB.Text != ConfirmPasswordTB.Text)
                MessageBox.Show("Password and Confirm Password Not Match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                CUser.Password = PasswordTB.Text;
                if (MyDB.UpdateUser(ref CUser))
                {
                    MessageBox.Show("Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CurrentPasswordTB.Text = PasswordTB.Text = ConfirmPasswordTB.Text = "";
                }
                else
                    MessageBox.Show("Failed to update", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}