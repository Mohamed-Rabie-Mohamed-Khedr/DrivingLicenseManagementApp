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
    public partial class DetainInfo : UserControl
    {
        public DetainInfo()
        {
            InitializeComponent();
        }
        public void LoadDetainInfo(int LicenseID)
        {
            (DetainedLicense dl, string UserName) d = MyDB.GetDetainedLicense(LicenseID);

            DetainIDL.Text = "Detain ID: " + d.dl.DetainID.ToString();
            DetainDateL.Text = "Detain Date: " + d.dl.DetainDate.ToShortDateString();
            LicenseIDL.Text = "License ID: " + LicenseID.ToString();
            CreatedByL.Text = "Created By: " + d.UserName;
        }
        public decimal GetFineFees()
        {
            return FineFeeNUD.Value;
        }
    }
}