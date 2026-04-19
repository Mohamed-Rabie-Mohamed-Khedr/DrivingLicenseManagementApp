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
    public partial class ReleaseDetainedLicenseForm : Form
    {
        License l;
        int LicenseID, ApplicantPersonID;
        public ReleaseDetainedLicenseForm(int LID = 0)
        {
            InitializeComponent();
            if (LID > 0)
            {
                LicenseIDTB.Text = LID.ToString();
                OKBClick();
                LicenseIDTB.Enabled = OKB.Enabled = false;
            }
        }

        private void OKB_Click(object sender, EventArgs e)
        {
            OKBClick();
        }

        private void OKBClick()
        {
            ReleaseB.Enabled = ShowPersonLicenseHistoryLL.Enabled = ShowLicenseLL.Enabled = false;
            LicenseID = Convert.ToInt32(LicenseIDTB.Text);
            if (MyDB.LicenseIsDetained(LicenseID))
            {
                DataTable dt = MyDB.GetApplicationInfoToShowOnForm(LicenseID);
                ApplicantPersonID = Convert.ToInt32(dt.Rows[0]["ApplicantPersonID"]);
                driverInfo1.LoadDriverInfo(LicenseID);
                ReleaseB.Enabled = ShowPersonLicenseHistoryLL.Enabled = ShowLicenseLL.Enabled = true;
                l = MyDB.GetLicense(LicenseID);
                releaseDetainedLicense1.LoadInfo(LicenseID);
            }
            else
            {
                MessageBox.Show("License is not detained or The license not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowLicenseLL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DriverInfoForm driverInfoForm = new DriverInfoForm(LicenseID);
            driverInfoForm.ShowDialog();
        }

        private void ReleaseB_Click(object sender, EventArgs e)
        {
            LDLApp ld = new LDLApp();
            ld.ApplicationDate = DateTime.Now;
            ld.LastStatusDate = DateTime.Now;
            ld.ApplicationTypeID = 5;
            ld.ApplicantPersonID = ApplicantPersonID;
            ld.ApplicationStatus = "Completed";
            ld.PaidFees = releaseDetainedLicense1.TotalFees;
            ld.LicenseClassID = l.LicenseClass;
            ld.CreatedByUserID = DLMHelper.CurrentUser.UserID;

            if (MyDB.IsReleasedTrue(DateTime.Now, DLMHelper.CurrentUser.UserID, MyDB.AddLDLApp(ref ld), LicenseID))
            {
                ReleaseB.Enabled = false;
                releaseDetainedLicense1.LoadApplicationID(ld.LDLAppID);
                MessageBox.Show("License Released Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Failed, Please Try Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void LicenseIDTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar)) e.Handled = true;
        }

        private void ShowPersonLicenseHistoryLL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PersonLicenseHistory personLicenseHistory = new PersonLicenseHistory(LicenseID, ApplicantPersonID);
            personLicenseHistory.ShowDialog();
        }
    }
}