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
            UserInfoForm userInfoForm = new UserInfoForm(DLMHelper.CurrentUser.PersonID);
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

        private void LocalLicenseB_Click(object sender, EventArgs e)
        {
            LocalLicenseForm localLicenseForm = new LocalLicenseForm();
            localLicenseForm.ShowDialog();
        }

        private void LocalDrivingLicenseApplicationsB_Click(object sender, EventArgs e)
        {
            ManageLocalDrivingLicenseApplications mldlp = new ManageLocalDrivingLicenseApplications();
            mldlp.ShowDialog();
        }

        private void DriversB_Click(object sender, EventArgs e)
        {
            ManageDrivers md = new ManageDrivers();
            md.ShowDialog();
        }

        private void InternationalLicenseB_Click(object sender, EventArgs e)
        {
            InternationalLicenseApplication ilp = new InternationalLicenseApplication();
            ilp.ShowDialog();
        }

        private void internationalDriverLicenseApplicationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageInternationalDriverLicenseApplications m = new ManageInternationalDriverLicenseApplications();
            m.ShowDialog();
        }

        private void newDrivingLicenseToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RenewLocalDrivingLicense renewLocalDrivingLicense = new RenewLocalDrivingLicense();
            renewLocalDrivingLicense.ShowDialog();
        }

        private void replace4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReplacementForDamagedOrLicenseForm replacementForDamagedOrLicenseForm = new ReplacementForDamagedOrLicenseForm();
            replacementForDamagedOrLicenseForm.ShowDialog();
        }

        private void detainLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DetainLicenseForm detainLicenseForm = new DetainLicenseForm();
            detainLicenseForm.ShowDialog();
        }

        private void manageDetainedLicensesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageDetainedLicenses manageDetainedLicenses = new ManageDetainedLicenses();
            manageDetainedLicenses.ShowDialog();
        }

        private void releaseDetainedLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReleaseDetainedLicenseForm releaseDetainedLicenseForm = new ReleaseDetainedLicenseForm();
            releaseDetainedLicenseForm.ShowDialog();
        }
    }
}