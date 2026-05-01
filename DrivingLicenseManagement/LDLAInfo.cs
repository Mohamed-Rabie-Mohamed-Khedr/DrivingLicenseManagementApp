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
    public partial class LDLAInfo : UserControl
    {
        LDLApp ldlapp;
        public LDLAInfo(ref LDLApp l)
        {
            InitializeComponent();
            ldlapp = l;
        }

        void LoadLDLApp()
        {
            DLAppIDL.Text = "D.L. App ID: " + ldlapp.LDLAppID.ToString();
            AppliedForLicenseL.Text = "Applied For License: " + ldlapp.LicenseClassName;
            PassedTestsL.Text = "Passed Tests: " + ldlapp.PassedTests.ToString() + "/3";
            IDL.Text = "ID: " + ldlapp.ApplicationID.ToString();
            StatusL.Text = "Status: " + ldlapp.ApplicationStatus;
            FeesL.Text = "Fees: " + ldlapp.PaidFees.ToString("0");
            TypeL.Text = "Type: " + ldlapp.ApplicationTypeTitle;
            ApplicantL.Text = "Applicant: " + ldlapp.ApplicantName;
            DateL.Text = "Date: " + ldlapp.ApplicationDate.ToShortDateString();
            StatusDateL.Text = "Status Date: " + ldlapp.LastStatusDate.ToShortDateString();
            CreatedByL.Text = "Created By: " + ldlapp.CreatedName;
        }

        private void ShowPersonInfoLL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PersonInfoForm personInfoForm = new PersonInfoForm(ldlapp.ApplicantPersonID);
            personInfoForm.ShowDialog();
            ldlapp = MyDB.GetLDLApp(ldlapp.LDLAppID);
            LoadLDLApp();
        }

        private void LDLAInfo_Load(object sender, EventArgs e)
        {
            ShowLicenseLL.Enabled = ldlapp.LicenseID > 0;
            LoadLDLApp();
        }

        private void ShowLicenseLL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DriverInfoForm driverInfoForm = new DriverInfoForm(ldlapp.LicenseID);
            driverInfoForm.ShowDialog();
        }
    }
}