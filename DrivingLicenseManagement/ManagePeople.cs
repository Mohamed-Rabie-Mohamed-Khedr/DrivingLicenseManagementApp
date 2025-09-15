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
    public partial class ManagePeople : Form
    {
        public ManagePeople()
        {
            InitializeComponent();
            CountryFilterCB.Items.AddRange(MyDB.GetCountries());
            FilterByCB.SelectedIndex = 0;
            GendorFilterCB.SelectedIndex = 0;
            CountryFilterCB.SelectedIndex = 0;
            LoadPeople();
        }

        private void AddPerson_Click(object sender, EventArgs e)
        {
            AddAndUpdatePersonForm addAndUpdatePersonForm = new AddAndUpdatePersonForm();
            addAndUpdatePersonForm.ShowDialog();
            FilterByCB.SelectedIndex = 0;
            LoadPeople();
        }

        private void DeletePerson_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (MyDB.DeletePerson((int)dataGridView1.SelectedRows[0].Cells["PersonID"].Value))
                {
                    DLMHelper.RemoveFile("Images\\" + dataGridView1.SelectedRows[0].Cells["NationalNo"].Value.ToString() + ".jpg");
                    LoadPeople();
                    MessageBox.Show("Deleted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed to delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ShowInfoAndEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                AddAndUpdatePersonForm up
                = new AddAndUpdatePersonForm(dataGridView1.SelectedRows[0].Cells[1].Value.ToString());
                up.ShowDialog();
                LoadPeople();
            }
        }

        void LoadPeople(string FilterMode = "", object FilterValue = null)
        {
            dataGridView1.Rows.Clear();

            DataTable dt = MyDB.GetPeople(ref FilterMode, ref FilterValue);
            string[] countryNames = MyDB.GetCountries();
            string gendor, country;

            if (dt != null)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    gendor = Convert.ToSByte(dt.Rows[i]["Gendor"]) == 0 ? "Male" : "Female";
                    country = countryNames[(int)dt.Rows[i]["NationalityCountryID"] - 1];

                    dataGridView1.Rows.Add(dt.Rows[i]["PersonID"], dt.Rows[i]["NationalNo"],
                    dt.Rows[i]["FirstName"], dt.Rows[i]["SecondName"], dt.Rows[i]["ThirdName"],
                    dt.Rows[i]["LastName"], gendor, country,
                    dt.Rows[i]["DateOfBirth"], dt.Rows[i]["Phone"], dt.Rows[i]["Email"]);
                }

                RecordsT.Text = "Records: " + dt.Rows.Count.ToString();
            }
            else MessageBox.Show("Failed to load people", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void FilterByCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FilterByCB.SelectedIndex > 0 && FilterByCB.Text != "Gendor" && FilterByCB.Text != "Nationality")
            {
                FilterByTB.Visible
                = FilterB.Visible = true;
                GendorFilterCB.Visible
                = CountryFilterCB.Visible = false;
                FilterByTB.Text = "";
            }
            else if (FilterByCB.Text == "Gendor")
            {
                FilterByTB.Visible
                = FilterB.Visible
                = CountryFilterCB.Visible = false;
                GendorFilterCB.Visible = true;
            }
            else if (FilterByCB.Text == "Nationality")
            {
                FilterByTB.Visible
                = FilterB.Visible
                = GendorFilterCB.Visible = false;
                CountryFilterCB.Visible = true;
            }
            else
            {
                FilterByTB.Visible
                = FilterB.Visible
                = GendorFilterCB.Visible
                = CountryFilterCB.Visible = false;
            }
            LoadPeople();
        }

        private void FilterB_Click(object sender, EventArgs e)
        {
            LoadPeople(FilterByCB.Text, FilterByTB.Text);
        }

        private void GendorFilterCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadPeople(FilterByCB.Text, (byte)GendorFilterCB.SelectedIndex);
        }

        private void GendorFilterCB_Validated(object sender, EventArgs e)
        {
            LoadPeople(FilterByCB.Text, (byte)GendorFilterCB.SelectedIndex);
        }

        private void CountryFilterCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CountryFilterCB.SelectedIndex > 0)
                LoadPeople(FilterByCB.Text, CountryFilterCB.SelectedIndex);
            else LoadPeople();
        }
    }
}