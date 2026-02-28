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
    public partial class NewLicenseApplicationInfo : UserControl
    {
        public NewLicenseApplicationInfo()
        {
            InitializeComponent();
        }
        public void LoadInfo(int LicenseID)
        {
            DataTable dt = MyDB.GetNewLicenseApplicationInfo(LicenseID);
            RLApplicationIDL.Text = "Application ID: " + dt.Rows[0]["ApplicationID"].ToString();
            OldLicenseIDL.Text = "Old License ID: " + LicenseID.ToString();
            ApplicationDateL.Text = "Application Date: " + dt.Rows[0]["ApplicationDate"].ToString();
            ExpirationDateL.Text = "Expiration Date: " + dt.Rows[0]["ExpirationDate"].ToString();
            IssueDateL.Text = "Issue Date: " + dt.Rows[0]["IssueDate"].ToString();
            CreatedByL.Text = "Created By: " + dt.Rows[0]["UserName"].ToString();
        }
        public void LoadFeesInfo(DataTable dt)
        {
            int ApplicationFees = Convert.ToInt32(dt.Rows[0]["ApplicationFees"]);
            int ClassFees = Convert.ToInt32(dt.Rows[0]["ClassFees"]);
            ApplicationFeesL.Text = "Application Fees: " + ApplicationFees.ToString();
            LicenseFeesL.Text = "Class Fees: " + ClassFees.ToString();
            TotalFeesL.Text = "Total Fees: " + (ApplicationFees + ClassFees).ToString();
        }
    }
}