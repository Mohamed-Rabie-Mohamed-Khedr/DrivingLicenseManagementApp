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
    public partial class ManageDetainedLicenses : Form
    {
        public ManageDetainedLicenses()
        {
            InitializeComponent();
        }

        void LoadInfo(object FilterValue)
        {
            dataGridView1.Rows.Clear();
            DataTable dt = MyDB.GetDetainedLicenses(FilterByCB.Text, FilterValue);
            if (dt != null)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    dataGridView1.Rows.Add(dr["DetainID"], dr["LicenseID"], dr["DetainDate"], dr["IsReleased"],
                    dr["FineFees"], dr["ReleaseDate"], dr["NationalNo"], dr["FullName"], dr["ReleaseApplicationID"]);
                }
                RecordsL.Text = "Records: " + dt.Rows.Count.ToString();
            }
        }

        private void FilterByCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterSelectedIndexChanged();
        }

        private void FilterSelectedIndexChanged()
        {
            if (FilterByCB.Text == "None")
            {
                IsReleasedCB.Visible = FilterByTB.Visible = false;
                LoadInfo(null);
            }
            else if (FilterByCB.Text == "Is Released")
            {
                IsReleasedCB.Visible = true;
                LoadInfo(IsReleasedCB.SelectedIndex);
                FilterByTB.Visible = false;
            }
            else
            {
                FilterByTB.Visible = true;
                LoadInfo(FilterByTB.Text);
                IsReleasedCB.Visible = false;
            }
        }

        private void ManageDetainedLicenses_Load(object sender, EventArgs e)
        {
            FilterByCB.SelectedIndex = IsReleasedCB.SelectedIndex = 0;
        }

        private void IsReleasedCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadInfo(IsReleasedCB.SelectedIndex);
        }

        private void FilterByTB_TextChanged(object sender, EventArgs e)
        {
            LoadInfo(FilterByTB.Text);
        }

        private void DetainB_Click(object sender, EventArgs e)
        {
            DetainLicenseForm detainLicenseForm = new DetainLicenseForm();
            detainLicenseForm.ShowDialog();
            FilterSelectedIndexChanged();
        }

        private void ReleaseB_Click(object sender, EventArgs e)
        {
            ReleaseDetainedLicenseForm releaseDetainedLicenseForm = new ReleaseDetainedLicenseForm();
            releaseDetainedLicenseForm.ShowDialog();
            FilterSelectedIndexChanged();
        }

        private void ShowPersonB_Click(object sender, EventArgs e)
        {
            PersonInfoForm personInfoForm = new PersonInfoForm(
            MyDB.GetPersonIDByNationalNo(dataGridView1.SelectedRows[0].Cells["NationalNo"].Value.ToString()));
            personInfoForm.ShowDialog();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            releaseToolStripMenuItem.Enabled = !Convert.ToBoolean(dataGridView1.SelectedRows[0].Cells["IsReleased"].Value);
            if (dataGridView1.SelectedRows.Count == 0) e.Cancel = true;
        }

        private void ShowLicenseB_Click(object sender, EventArgs e)
        {
            DriverInfoForm driverLicenseInfoForm = new DriverInfoForm(
            Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["LID"].Value));
            driverLicenseInfoForm.ShowDialog();
        }

        private void PersonLicenseHistoryB_Click(object sender, EventArgs e)
        {
            PersonLicenseHistory personLicenseHistory = new PersonLicenseHistory(
            Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["LID"].Value),
            MyDB.GetPersonIDByNationalNo(dataGridView1.SelectedRows[0].Cells["NationalNo"].Value.ToString()));
            personLicenseHistory.ShowDialog();
        }

        private void releaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReleaseDetainedLicenseForm releaseDetainedLicenseForm = new ReleaseDetainedLicenseForm(
            Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["LID"].Value));
            releaseDetainedLicenseForm.ShowDialog();
            FilterSelectedIndexChanged();
        }
    }
}