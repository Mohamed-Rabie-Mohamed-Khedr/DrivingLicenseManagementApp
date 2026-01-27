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
    public partial class PersonLicenseHistory : Form
    {
        public PersonLicenseHistory(int LicenseID, int PersonID, bool  tab1IsActive = true)
        {
            InitializeComponent();
            if (!tab1IsActive) tabControl1.SelectedIndex = 1;
            DriverInfo driverLicenseInfo = new DriverInfo()
            {
                Dock = DockStyle.Top
            };
            driverLicenseInfo.LoadDriverInfo(LicenseID);
            this.Controls.Add(driverLicenseInfo);

            DataTable d = MyDB.GetPersonLicenseHistory(PersonID);
            for (int i = 0; i < d.Rows.Count; i++)
            {
                dataGridView1.Rows.Add(d.Rows[i]["LicenseID"], d.Rows[i]["ApplicationID"],
                d.Rows[i]["ClassName"], d.Rows[i]["IssueDate"], d.Rows[i]["ExpirationDate"],
                d.Rows[i]["IsActive"]);
            }
            InternationalLicense il = MyDB.GetInternationalLicense(LicenseID);
            if (il != null)
                dataGridView2.Rows.Add(il.InternationalLicenseID, il.ApplicationID, il.ClassName, il.IssueDate, il.ExpirationDate, il.IsActive);
        }
    }
}