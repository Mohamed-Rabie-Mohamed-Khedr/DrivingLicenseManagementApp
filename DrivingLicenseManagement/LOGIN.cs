using Microsoft.Win32;
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
    public partial class LOGIN : Form
    {
        public LOGIN()
        {
            InitializeComponent();
        }

        private void LOGIN_Load(object sender, EventArgs e)
        {
            using (RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\DrivingLicenseManagement"))
            {
                UserNameTB.Text = (string)key.GetValue("UserName", "");
                PasswordTB.Text = (string)key.GetValue("Password", "");
                RememberMeCB.Checked = ((int)key.GetValue("RememberMe", 0) == 1);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(PasswordTB.Text))
                MessageBox.Show("Please Enter Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (string.IsNullOrEmpty(UserNameTB.Text))
                MessageBox.Show("Please Enter User Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                DLMHelper.CurrentUser = MyDB.GetUserToLogIn(UserNameTB.Text, PasswordTB.Text);
                if (DLMHelper.CurrentUser == null)
                    MessageBox.Show("Wrong User Name or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    if (!DLMHelper.CurrentUser.IsActive)
                        MessageBox.Show("This User is not Active", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        using (RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\DrivingLicenseManagement", true))
                        {
                            key.SetValue("RememberMe", RememberMeCB.Checked ? 1 : 0, RegistryValueKind.DWord);
                            if (RememberMeCB.Checked)
                            {
                                key.SetValue("UserName", UserNameTB.Text, RegistryValueKind.String);
                                key.SetValue("Password", PasswordTB.Text, RegistryValueKind.String);
                            }
                            else
                            {
                                key.SetValue("UserName", "", RegistryValueKind.String);
                                key.SetValue("Password", "", RegistryValueKind.String);
                            }
                        }
                        Hide();
                        Main main = new Main();
                        main.ShowDialog();
                    }
                }
            }
        }
    }
}