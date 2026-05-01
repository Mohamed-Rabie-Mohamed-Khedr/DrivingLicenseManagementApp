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
    public partial class ApplicationInfoForLicenseReplacement : UserControl
    {
        public ApplicationInfoForLicenseReplacement()
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
            CreatedByL.Text = "Created By: " + dt.Rows[0]["UserName"].ToString();
        }
        public void LoadApplicationTypeFees(int ApplicationTypeID)
        {
            int Fees = MyDB.GetApplicationTypesFees(ApplicationTypeID);
            ApplicationFeesL.Text = "Application Fees: " + Fees.ToString();
        }
    }
}