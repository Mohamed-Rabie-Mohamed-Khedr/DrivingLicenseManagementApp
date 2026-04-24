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
    public partial class RenewLocalDrivingLicense : Form
    {
        License license;
        int LicenseID = 0, NewLicenseID = 0, ApplicantPersonID = 0;
        DataTable dt;
        public RenewLocalDrivingLicense()
        {
            InitializeComponent();
        }

        private void LicenseIDTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar)) e.Handled = true;
        }

        private void OKB_Click(object sender, EventArgs e)
        {
            ShowPersonLicenseHistoryLL.Enabled = false;
            if (!string.IsNullOrEmpty(LicenseIDTB.Text))
            {
                LicenseID = Convert.ToInt32(LicenseIDTB.Text);
                if (MyDB.LicenseIsExists(LicenseID))
                {
                    ShowPersonLicenseHistoryLL.Enabled = true;
                    driverInfo1.LoadDriverInfo(LicenseID);
                    if (!MyDB.LicenseIsActive(LicenseID))
                    {
                        license = MyDB.GetLicense(LicenseID);
                        license.IssueReason = 2;
                        dt = MyDB.GetApplicationInfoToShowOnForm(LicenseID);
                        ApplicantPersonID = Convert.ToInt32(dt.Rows[0]["ApplicantPersonID"]);
                        dt = MyDB.GetApplicationTypesFeesAndLicenseFees(license.IssueReason,license.LicenseClass);
                        newLicenseApplicationInfo1.LoadFeesInfo(dt);
                        IssueB.Enabled = true;
                    }
                    else
                    {
                        IssueB.Enabled = false;
                        LicenseID = ApplicantPersonID = 0;
                        MessageBox.Show("This License Already Active", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    IssueB.Enabled = false;
                    LicenseID = ApplicantPersonID = 0;
                    MessageBox.Show("Invalid License ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ShowNewLicenseLL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DriverInfoForm driverInfoForm = new DriverInfoForm(NewLicenseID);
            driverInfoForm.ShowDialog();
        }

        private void ShowPersonLicenseHistoryLL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PersonLicenseHistory personLicenseHistory = new PersonLicenseHistory(LicenseID, ApplicantPersonID);
            personLicenseHistory.ShowDialog();
        }

        private void IssueB_Click(object sender, EventArgs e)
        {
            int IssueDate =  int.Parse(license.IssueDate.ToString("yyyy"));
            int ExpirationDate = int.Parse(license.ExpirationDate.ToString("yyyy"));
            int DefaultValidityLength = ExpirationDate - IssueDate;
            license.IssueDate = DateTime.Now;
            license.ExpirationDate = DateTime.Now.AddYears(DefaultValidityLength);
            license.IsActive = true;
            LDLApp lDLApp = new LDLApp(MyDB.GetLDLApps("Application ID", license.ApplicationID).Rows[0]);
            lDLApp.ApplicationTypeID = 2;
            lDLApp.PaidFees = MyDB.GetLicenseClasseFees(lDLApp.ApplicationTypeID);
            lDLApp.ApplicationDate = DateTime.Now;
            lDLApp.LastStatusDate = DateTime.Now;
            lDLApp.PaidFees = Convert.ToDecimal(dt.Rows[0]["ApplicationFees"]);
            if (MyDB.AddApplication(ref lDLApp) > 0)
            {
                license.ApplicationID = lDLApp.ApplicationID;
                if (MyDB.AddLicense(ref license))
                {
                    IssueB.Enabled = false;
                    NewLicenseID = license.LicenseID;
                    ApplicantPersonID = lDLApp.ApplicantPersonID;
                    newLicenseApplicationInfo1.LoadInfo(LicenseID, NewLicenseID);
                    ShowNewLicenseLL.Enabled = true;
                    MessageBox.Show("New License Issued Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MyDB.DeleteLDLApp(lDLApp.LDLAppID);
                    MessageBox.Show("Error Adding License", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Error Adding Application", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}