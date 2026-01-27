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
    public partial class ManageInternationalDriverLicenseApplications : Form
    {
        int PersonID, LicenseID;
        public ManageInternationalDriverLicenseApplications()
        {
            InitializeComponent();
        }

        private void ManageInternationalDriverLicenseApplications_Load(object sender, EventArgs e)
        {
            DataTable dt = MyDB.GetInternationalLicenses();
            if (dt != null)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dataGridView1.Rows.Add(dt.Rows[i]["InternationalLicenseID"],
                    dt.Rows[i]["DriverID"], dt.Rows[i]["ApplicationID"],
                    dt.Rows[i]["IssuedUsingLocalLicenseID"], dt.Rows[i]["IssueDate"],
                    dt.Rows[i]["ExpirationDate"], dt.Rows[i]["IsActive"]);
                }
                RecordsL.Text = "Records: " + dt.Rows.Count.ToString();
            }
            else
                MessageBox.Show("Failed to load data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0) e.Cancel = true;
            else
            {
                LicenseID = int.Parse(dataGridView1.SelectedRows[0].Cells["LLicenseID"].Value.ToString());
                PersonID = MyDB.GetPersonIDByDriver(int.Parse(dataGridView1.SelectedRows[0].Cells["DriverID"].Value.ToString()));
            }
        }

        private void showInternationalLicenseInfoB_Click(object sender, EventArgs e)
        {
            PersonLicenseHistory personLicenseHistory = new PersonLicenseHistory(LicenseID, PersonID, false);
            personLicenseHistory.ShowDialog();
        }

        private void showPersonInfoB_Click(object sender, EventArgs e)
        {
            PersonInfoForm personInfoForm = new PersonInfoForm(PersonID);
            personInfoForm.ShowDialog();
        }

        private void showPersonLicenseHistoryB_Click(object sender, EventArgs e)
        {
            PersonLicenseHistory personLicenseHistory = new PersonLicenseHistory(LicenseID, PersonID);
            personLicenseHistory.ShowDialog();
        }
    }
}