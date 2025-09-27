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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            DLMHelper.IsAppExit = true;
        }

        private void peopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManagePeople managePeople = new ManagePeople();
            managePeople.ShowDialog();
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DLMHelper.IsAppExit = false;
            Close();
            Application.OpenForms[0].Show();
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (DLMHelper.IsAppExit) Application.Exit();
        }

        private void Users_Click(object sender, EventArgs e)
        {
            ManageUsers manageUsers = new ManageUsers();
            manageUsers.ShowDialog();
        }

        private void ChangePassword_Click(object sender, EventArgs e)
        {
            ChangePasswordForm cp = new ChangePasswordForm(DLMHelper.CurrentUser);
            cp.ShowDialog();
        }

        private void CurrentUserInfo_Click(object sender, EventArgs e)
        {
            UserInfoForm userInfoForm = new UserInfoForm(DLMHelper.CurrentUser);
            userInfoForm.ShowDialog();
        }

        private void ManageApplicationTypes_Click(object sender, EventArgs e)
        {
            ManageApplicationTypes mat = new ManageApplicationTypes();
            mat.ShowDialog();
        }

        private void ManageTestTypes_Click(object sender, EventArgs e)
        {
            ManageTestTypes mtt = new ManageTestTypes();
            mtt.ShowDialog();
        }
    }
}