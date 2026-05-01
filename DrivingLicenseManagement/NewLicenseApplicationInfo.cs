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
        public void LoadInfo(int OldLicenseID, int NewLicenseID)
        {
            DataTable dt = MyDB.GetNewLicenseApplicationInfo(NewLicenseID);
            RLApplicationIDL.Text = "Application ID: " + dt.Rows[0]["ApplicationID"].ToString();
            RenewedLicenseIDL.Text = "Renewed License ID: " + NewLicenseID.ToString();
            OldLicenseIDL.Text = "Old License ID: " + OldLicenseID.ToString();
            ApplicationDateL.Text = "Application Date: " + Convert.ToDateTime(dt.Rows[0]["ApplicationDate"]).ToShortDateString();
            ExpirationDateL.Text = "Expiration Date: " + Convert.ToDateTime(dt.Rows[0]["ExpirationDate"]).ToShortDateString();
            IssueDateL.Text = "Issue Date: " + Convert.ToDateTime(dt.Rows[0]["IssueDate"]).ToShortDateString();
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