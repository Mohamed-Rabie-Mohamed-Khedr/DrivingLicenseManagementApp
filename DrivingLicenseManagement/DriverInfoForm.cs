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
    public partial class DriverInfoForm : Form
    {
        public DriverInfoForm(int LicenseID)
        {
            InitializeComponent();
            DriverInfo driverLicenseInfo = new DriverInfo()
            {
                Dock = DockStyle.Fill
            };
            driverLicenseInfo.LoadDriverInfo(LicenseID);
            this.Controls.Add(driverLicenseInfo);
        }
    }
}