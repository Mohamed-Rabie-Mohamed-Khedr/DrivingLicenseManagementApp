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
    public partial class ReplacementForDamagedOrLicenseForm : Form
    {
        License license;
        int LicenseID = 0, NewLicenseID = 0, ApplicantPersonID = 0;
        decimal applicationFees = 0;
        byte applicationTypeID = 0;
        DataTable dt;
        public ReplacementForDamagedOrLicenseForm()
        {
            InitializeComponent();
        }
        void ApplicationFeesUpdate()
        {
            applicationTypeID = (byte)(radioButton1.Checked ? 3 : 4);
            applicationFees = MyDB.GetApplicationTypesFees(applicationTypeID);
            applicationInfoForLicenseReplacement1.LoadApplicationTypeFees(applicationTypeID);
        }

        private void ReplacementForDamagedOrLicenseForm_Load(object sender, EventArgs e)
        {
            ApplicationFeesUpdate();
        }

        private void ShowPersonLicenseHistoryLL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PersonLicenseHistory personLicenseHistory = new PersonLicenseHistory(LicenseID, ApplicantPersonID);
            personLicenseHistory.ShowDialog();
        }

        private void ShowNewLicenseLL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DriverInfoForm driverInfoForm = new DriverInfoForm(NewLicenseID);
            driverInfoForm.ShowDialog();
        }

        private void IssueB_Click(object sender, EventArgs e)
        {
            int IssueDate = int.Parse(license.IssueDate.ToString("yyyy"));
            int ExpirationDate = int.Parse(license.ExpirationDate.ToString("yyyy"));
            int DefaultValidityLength = ExpirationDate - IssueDate;
            license.IssueDate = DateTime.Now;
            license.ExpirationDate = DateTime.Now.AddYears(DefaultValidityLength);
            license.IsActive = true;
            LDLApp lDLApp = new LDLApp(MyDB.GetLDLApps("Application ID", license.ApplicationID).Rows[0]);
            lDLApp.ApplicationTypeID = applicationTypeID;
            lDLApp.ApplicationDate = DateTime.Now;
            lDLApp.LastStatusDate = DateTime.Now;
            lDLApp.PaidFees = applicationFees;
            if (MyDB.AddLDLApp(ref lDLApp) > 0)
            {
                license.ApplicationID = lDLApp.ApplicationID;
                if (MyDB.AddLicense(ref license))
                {
                    IssueB.Enabled = false;
                    NewLicenseID = license.LicenseID;
                    ApplicantPersonID = lDLApp.ApplicantPersonID;
                    applicationInfoForLicenseReplacement1.LoadInfo(LicenseID, NewLicenseID);
                    ShowNewLicenseLL.Enabled = true;
                    MyDB.UpdateLicenseIsActive(LicenseID, false);
                    MessageBox.Show("New License Issued Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MyDB.DeleteLDLApp(lDLApp.LDLAppID);
                    MessageBox.Show("failed to Replacement license", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("failed to add new license application", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LicenseIDTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar)) e.Handled = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            ApplicationFeesUpdate();
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
                    if (MyDB.LicenseIsActive(LicenseID))
                    {
                        license = MyDB.GetLicense(LicenseID);
                        license.IssueReason = applicationTypeID;
                        dt = MyDB.GetApplicationInfoToShowOnForm(LicenseID);
                        ApplicantPersonID = Convert.ToInt32(dt.Rows[0]["ApplicantPersonID"]);
                        IssueB.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("This License is Not Active, You Can't Renew It For Renew Local Driving License Window", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid License ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}