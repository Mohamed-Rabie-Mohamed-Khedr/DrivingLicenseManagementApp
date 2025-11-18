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
    public partial class DriverLicenseInfoForm : Form
    {
        public DriverLicenseInfoForm(int LDLAID)
        {
            InitializeComponent();
            DriverLicenseInfo driverLicenseInfo = new DriverLicenseInfo(LDLAID)
            {
                Dock = DockStyle.Fill
            };
            this.Controls.Add(driverLicenseInfo);
        }
    }
}