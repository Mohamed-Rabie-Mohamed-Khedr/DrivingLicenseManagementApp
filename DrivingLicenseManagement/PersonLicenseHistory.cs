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
        public PersonLicenseHistory(int LDLAID, int PersonID)
        {
            InitializeComponent();
            DriverLicenseInfo driverLicenseInfo = new DriverLicenseInfo(LDLAID)
            {
                Dock = DockStyle.Top
            };
            this.Controls.Add(driverLicenseInfo);

            DataTable d = MyDB.GetPersonLicenseHistory(PersonID);
            for (int i = 0; i < d.Rows.Count; i++)
            {
                dataGridView1.Rows.Add(d.Rows[i]["LicenseID"], d.Rows[i]["ApplicationID"],
                d.Rows[i]["ClassName"], d.Rows[i]["IssueDate"], d.Rows[i]["ExpirationDate"],
                d.Rows[i]["IsActive"]);
            }
        }
    }
}