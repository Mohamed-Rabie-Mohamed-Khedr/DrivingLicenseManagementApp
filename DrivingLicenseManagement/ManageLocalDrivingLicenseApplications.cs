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
    public partial class ManageLocalDrivingLicenseApplications : Form
    {
        LDLApp ldlApp;
        public ManageLocalDrivingLicenseApplications()
        {
            InitializeComponent();
            FilterByCB.SelectedIndex = 0;
        }

        private void FilterByCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FilterByCB.Text == "None")
            {
                StatusCB.Visible
                = FilterByTB.Visible
                = FilterB.Visible = false;
            }
            else if (FilterByCB.Text == "Status")
            {
                StatusCB.Visible = true;
                StatusCB.SelectedIndex = 0;
                FilterByTB.Visible
                = FilterB.Visible = false;
                return;
            }
            else
            {
                StatusCB.Visible = false;
                FilterByTB.Visible
                = FilterB.Visible = true;
                FilterByTB.Text = "";
            }
            LoadLDLApps();
        }

        void LoadLDLApps(string filterMode = "", object filterValue = null)
        {
            dataGridView1.Rows.Clear();
            DataTable dt = MyDB.GetLDLApps(filterMode, filterValue);
            if (dt != null)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dataGridView1.Rows.Add(dt.Rows[i]["LDLAppID"],
                    dt.Rows[i]["ClassName"],dt.Rows[i]["NationalNo"], dt.Rows[i]["FullName"],
                    dt.Rows[i]["ApplicationDate"], dt.Rows[i]["PassedTests"], dt.Rows[i]["Status"]);
                }
                RecordsL.Text = "Records: " + dt.Rows.Count.ToString();
            }
        }

        private void AddB_Click(object sender, EventArgs e)
        {
            LocalLicenseForm llf = new LocalLicenseForm();
            llf.ShowDialog();
            FilterByCB.SelectedIndex = 0;
            LoadLDLApps();
        }

        private void StatusCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (StatusCB.SelectedIndex == 0)
                LoadLDLApps();
            else
                LoadLDLApps("Status", (byte)StatusCB.SelectedIndex);
        }

        private void FilterB_Click(object sender, EventArgs e)
        {
            LoadLDLApps(FilterByCB.Text, FilterByTB.Text);
        }

        private void DeleteApplicationB_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (MyDB.DeleteLDLApp((int)dataGridView1.SelectedRows[0].Cells["LDLAppID"].Value))
                {
                    LoadLDLApps();
                    MessageBox.Show("Deleted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Failed to delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CancelApplicationB_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                ldlApp.ApplicationStatus = "Canceled";
                ldlApp.LastStatusDate = DateTime.Now;
                if (MyDB.UpdateLDLApp(ref ldlApp))
                {
                    LoadLDLApps();
                }
                else
                    MessageBox.Show("Failed to cancel", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowAndEditApplicationB_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                LDLAInfoForm lDLAInfoForm = new LDLAInfoForm(ref ldlApp);
                lDLAInfoForm.ShowDialog();
                LoadLDLApps();
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                ldlApp = MyDB.GetLDLApp((int)dataGridView1.SelectedRows[0].Cells["LDLAppID"].Value);
                if (ldlApp.PassedTests == 0)
                    SechduleTestsB.DropDownItems[0].Enabled = true;
                else if (ldlApp.PassedTests == 1)
                    SechduleTestsB.DropDownItems[1].Enabled = true;
                else if (ldlApp.PassedTests == 2)
                    SechduleTestsB.DropDownItems[2].Enabled = true;
                else if (!MyDB.LicenseIsExists(ldlApp.LicenseClassID, ldlApp.ApplicantPersonID))
                    IssueDrivingLicenseB.Enabled = true;
                else
                {
                    DeleteApplicationB.Enabled = false;
                    CancelApplicationB.Enabled = false;
                    SechduleTestsB.Enabled = false;

                    ShowLicenseB.Enabled = true;
                }
            }
        }

        private void TestB_Click(object sender, EventArgs e)
        {
            TestsForm testsForm = new TestsForm(ref ldlApp);
            testsForm.ShowDialog();
            LoadLDLApps();
        }

        private void IssueDrivingLicenseB_Click(object sender, EventArgs e)
        {
            IssueDriverLicense issueDriverLicense = new IssueDriverLicense(ref ldlApp);
            issueDriverLicense.ShowDialog();
            LoadLDLApps();
        }

        private void ShowLicenseB_Click(object sender, EventArgs e)
        {
            DriverInfoForm driverLicenseInfoForm = new DriverInfoForm(ldlApp.LicenseID);
            driverLicenseInfoForm.ShowDialog();
        }

        private void PersonLicenseHistoryB_Click(object sender, EventArgs e)
        {
            PersonLicenseHistory personLicenseHistory = new PersonLicenseHistory(ldlApp.LicenseID,
            ldlApp.ApplicantPersonID);
            personLicenseHistory.ShowDialog();
        }
    }
}