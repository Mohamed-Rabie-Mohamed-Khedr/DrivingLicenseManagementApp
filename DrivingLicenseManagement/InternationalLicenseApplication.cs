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
    public partial class InternationalLicenseApplication : Form
    {
        int ApplicantPersonID = 0, LicenseID = 0;
        public InternationalLicenseApplication()
        {
            InitializeComponent();
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

        private void IssueB_Click(object sender, EventArgs e)
        {
            if (ShowInternationalLicenseLL.Enabled)
                MessageBox.Show("This License Has Already Been Issued", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                License license = MyDB.GetLicense(LicenseID);
                InternationalLicense internationalLicense = new InternationalLicense();
                internationalLicense.IssuedUsingLocalLicenseID = license.LicenseID;
                internationalLicense.DriverID = license.DriverID;
                internationalLicense.ClassName = license.ClassName;
                internationalLicense.IssueDate = license.IssueDate;
                internationalLicense.ExpirationDate = license.ExpirationDate;
                internationalLicense.IsActive = license.IsActive;
                internationalLicense.CreatedByUserID = license.CreatedByUserID;
                ShowInternationalLicenseLL.Enabled = MyDB.AddInternationalLicense(ref internationalLicense);
                if (ShowInternationalLicenseLL.Enabled)
                {
                    IssueB.Enabled = false;
                    MessageBox.Show("License Issued Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Failed, Please Try Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowInternationalLicenseLL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PersonLicenseHistory personLicenseHistory = new PersonLicenseHistory(LicenseID, ApplicantPersonID, false);
            personLicenseHistory.ShowDialog();
        }

        private void OKB_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(LicenseIDTB.Text))
            {
                LicenseID = Convert.ToInt32(LicenseIDTB.Text);
                ApplicantPersonID = applicationInfo1.LoadApplicationInfo(LicenseID);
                ShowPersonLicenseHistoryLL.Enabled = driverLicenseInfo1.LoadDriverInfo(LicenseID);
                ShowInternationalLicenseLL.Enabled = MyDB.InternationalLicenseIsExists(LicenseID);
                if (!ShowPersonLicenseHistoryLL.Enabled)
                {
                    IssueB.Enabled = false;
                    MessageBox.Show("Invalid License ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!ShowInternationalLicenseLL.Enabled) IssueB.Enabled = true;
            }
        }
    }
}