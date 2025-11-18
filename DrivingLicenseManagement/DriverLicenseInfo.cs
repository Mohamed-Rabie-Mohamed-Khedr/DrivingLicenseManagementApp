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
    public partial class DriverLicenseInfo : UserControl
    {
        public DriverLicenseInfo(int LDLAID)
        {
            InitializeComponent();
            DataTable dt = MyDB.GetLicenseInfo(LDLAID);
            ClassL.Text = "Class: " + dt.Rows[0]["ClassName"].ToString();
            NameL.Text = "Name: " + dt.Rows[0]["FullName"].ToString();
            LicenseIDL.Text = "License ID: " + dt.Rows[0]["LicenseID"].ToString();
            NationalNoL.Text = "National No: " + dt.Rows[0]["NationalNo"].ToString();
            GendorL.Text = "Gendor: " + dt.Rows[0]["Gendor"].ToString();
            IssueDateL.Text = "Issue Date: " + dt.Rows[0]["IssueDate"].ToString();
            IssueReasonL.Text = "Issue Reason: " + dt.Rows[0]["ApplicationTypeTitle"].ToString();
            NotesL.Text = "Notes: " + dt.Rows[0]["Notes"].ToString();
            IsActiveL.Text = "Is Active: " + dt.Rows[0]["IsActive"].ToString();
            DateOfBirthL.Text = "Date Of Birth: " + dt.Rows[0]["DateOfBirth"].ToString();
            DriverIDL.Text = "Driver ID: " + dt.Rows[0]["DriverID"].ToString();
            ExpirationDateL.Text = "Expiration Date: " + dt.Rows[0]["ExpirationDate"].ToString();
        }
    }
}