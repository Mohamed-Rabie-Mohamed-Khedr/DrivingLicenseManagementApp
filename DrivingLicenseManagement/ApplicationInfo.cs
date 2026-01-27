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
    public partial class ApplicationInfo : UserControl
    {
        public ApplicationInfo()
        {
            InitializeComponent();
        }
        public int LoadApplicationInfo(int LicenseID)
        {
            DataTable dt = MyDB.GetApplicationInfo(LicenseID);
            if (dt == null || dt.Rows.Count == 0) return 0;
            ApplicationIDL.Text = "Application ID: " + dt.Rows[0]["ApplicationID"].ToString();
            IssueReasonL.Text = "Issue Reason: " + dt.Rows[0]["ApplicationTypeTitle"].ToString();
            PaidFeesL.Text = "Paid Fees: " + dt.Rows[0]["PaidFees"].ToString();
            ApplicationDateL.Text = "Application Date: " + dt.Rows[0]["ApplicationDate"].ToString();
            LicenseIDL.Text = "License ID: " + dt.Rows[0]["LicenseID"].ToString();
            ExpirationDateL.Text = "Expiration Date: " + dt.Rows[0]["ExpirationDate"].ToString();
            UserNameL.Text = "User Name: " + dt.Rows[0]["UserName"].ToString();
            return int.Parse(dt.Rows[0]["ApplicantPersonID"].ToString());
        }
    }
}