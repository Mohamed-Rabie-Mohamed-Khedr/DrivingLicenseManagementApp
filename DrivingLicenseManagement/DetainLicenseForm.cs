using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace DrivingLicenseManagement
{
    public partial class DetainLicenseForm : Form
    {
        private DataTable dt;
        int LicenseID, ApplicantPersonID;
        public DetainLicenseForm()
        {
            InitializeComponent();
        }

        private void OKB_Click(object sender, EventArgs e)
        {
            DetainB.Enabled = ShowPersonLicenseHistoryLL.Enabled = ShowLicenseLL.Enabled = false;
            LicenseID = Convert.ToInt32(LicenseIDTB.Text);
            if (!MyDB.LicenseIsDetained(LicenseID))
            {
                dt = MyDB.GetApplicationInfoToShowOnForm(LicenseID);
                ApplicantPersonID = Convert.ToInt32(dt.Rows[0]["ApplicantPersonID"]);
                driverInfo1.LoadDriverInfo(LicenseID);
                DetainB.Enabled = ShowPersonLicenseHistoryLL.Enabled = ShowLicenseLL.Enabled = true;
            }
            else
            {
                MessageBox.Show("License is already detained or The license not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowPersonLicenseHistoryLL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PersonLicenseHistory personLicenseHistory = new PersonLicenseHistory(LicenseID, ApplicantPersonID);
            personLicenseHistory.ShowDialog();
        }

        private void LicenseIDTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar)) e.Handled = true;
        }

        private void DetainB_Click(object sender, EventArgs e)
        {
            DetainedLicense detainedLicense = new DetainedLicense();
            detainedLicense.LicenseID = LicenseID;
            detainedLicense.DetainDate = DateTime.Now;
            detainedLicense.FineFees = detainInfo1.GetFineFees();
            detainedLicense.CreatedByUserID = DLMHelper.CurrentUser.UserID;
            detainedLicense.IsReleased = false;
            if (MyDB.AddDetainedLicense(ref detainedLicense))
            {
                DetainB.Enabled = false;
                detainInfo1.LoadDetainInfo(LicenseID);
                MessageBox.Show("License Detained Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Failed, Please Try Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ShowLicenseLL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DriverInfoForm driverInfoForm = new DriverInfoForm(LicenseID);
            driverInfoForm.ShowDialog();
        }
    }
}