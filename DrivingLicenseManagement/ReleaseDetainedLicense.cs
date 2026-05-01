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
    public partial class ReleaseDetainedLicense : UserControl
    {
        public decimal ApplicationFees { get; private set; }
        public ReleaseDetainedLicense()
        {
            InitializeComponent();
        }
        public void LoadInfo(int LicenseID)
        {
            DataTable dt = MyDB.GetReleaseDetainedLicenseInfo(LicenseID);
            DetainIDL.Text = "Detain ID: " + dt.Rows[0]["DetainID"].ToString();
            DetainDateL.Text = "Detain Date: " + Convert.ToDateTime(dt.Rows[0]["DetainDate"]).ToShortDateString();
            LicenseIDL.Text = "License ID: " + dt.Rows[0]["LicenseID"].ToString();
            CreatedByL.Text = "Created By: " + dt.Rows[0]["UserName"].ToString();
            FineFeesL.Text = "Fine Fees: " + dt.Rows[0]["FineFees"].ToString();
            ApplicationFees = Convert.ToDecimal(dt.Rows[0]["ApplicationFees"]);
            ApplicationFeesL.Text = ApplicationFees.ToString();
            TotalFeesL.Text = "Total Fees: " + (Convert.ToDecimal(dt.Rows[0]["FineFees"]) + Convert.ToDecimal(dt.Rows[0]["ApplicationFees"])).ToString();
        }
        public void LoadApplicationID(int ApplicationID)
        {
            ApplicationIDL.Text = "Application ID: " + ApplicationID.ToString();
        }
    }
}