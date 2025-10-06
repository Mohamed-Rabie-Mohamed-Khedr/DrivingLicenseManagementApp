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
                    dt.Rows[i]["DrivingClass"],dt.Rows[i]["NationalNo"], dt.Rows[i]["FullName"],
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
                LDLApp ldlApp = MyDB.GetLDLApp((int)dataGridView1.SelectedRows[0].Cells["LDLAppID"].Value);
                ldlApp.ApplicationStatus = 2;
                ldlApp.LastStatusDate = DateTime.Now;
                if (MyDB.UpdateLDLApp(ref ldlApp))
                {
                    LoadLDLApps();
                }
                else
                    MessageBox.Show("Failed to cancel", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}