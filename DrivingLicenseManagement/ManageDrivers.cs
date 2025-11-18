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
    public partial class ManageDrivers : Form
    {
        public ManageDrivers()
        {
            InitializeComponent();
        }
        void LoadDrivers(string FilterMode = "", object FilterValue = null)
        {
            dataGridView1.Rows.Clear();
            DataTable dataTable = MyDB.GetDrivers(FilterMode, FilterValue);
            if (dataTable != null)
            {
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    dataGridView1.Rows.Add(dataTable.Rows[i]["DriverID"],
                    dataTable.Rows[i]["PersonID"], dataTable.Rows[i]["NationalNo"],
                    dataTable.Rows[i]["FullName"], dataTable.Rows[i]["CreatedDate"],
                    dataTable.Rows[i]["ActiveLicenses"]);
                }
                RecordsL.Text = "Records: " + dataTable.Rows.Count.ToString();
            }
        }

        private void ManageDrivers_Load(object sender, EventArgs e)
        {
            FilterByCB.SelectedIndex = 0;
        }

        private void FilterByCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FilterByCB.Text == "None")
            {
                FilterByTB.Visible = false;
                LoadDrivers();
            }
            else
            {
                FilterByTB.Visible = true;
                FilterByTB.Text = "";
            }
        }

        private void FilterByTB_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(FilterByTB.Text) && FilterByCB.Text != "None")
                LoadDrivers();
            else LoadDrivers(FilterByCB.Text, FilterByTB.Text);
        }
    }
}