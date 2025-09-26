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
    public partial class ManageUsers : Form
    {
        public ManageUsers()
        {
            InitializeComponent();
        }

        private void ManageUsers_Load(object sender, EventArgs e)
        {
            FilterBy.SelectedIndex = 0;
        }

        void LoadUsers(string FilterMode = "", object FilterValue = null)
        {
            dataGridView1.Rows.Clear();

            DataTable dt = MyDB.GetUsers(ref FilterMode, ref FilterValue);

            if (dt != null)
            {
                Person person;
                string FullName;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    person = MyDB.GetPerson((int)dt.Rows[i]["PersonID"]);
                    FullName = person.FirstName + " " + person.SecondName + " " + person.ThirdName + " " + person.LastName;

                    dataGridView1.Rows.Add(dt.Rows[i]["PersonID"], dt.Rows[i]["UserID"],
                    FullName, dt.Rows[i]["UserName"], dt.Rows[i]["IsActive"]);
                }
                RecordsT.Text = "Records: " + dt.Rows.Count.ToString();
            }
            else RecordsT.Text = "Records: 0";
        }

        private void FilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FilterBy.Text == "None")
            {
                FilterByIsActiveCB.Visible
                = FilterByTB.Visible = false;
                LoadUsers();
            }
            else if (FilterBy.Text == "Is Active")
            {
                FilterByIsActiveCB.Visible = true;
                FilterByIsActiveCB.SelectedIndex = 0;
                FilterByTB.Visible = false;
            }
            else
            {
                FilterByIsActiveCB.Visible = false;
                FilterByTB.Visible = true;
                LoadUsers(FilterBy.Text, FilterByTB.Text);
            }
        }

        private void FilterByTB_TextChanged(object sender, EventArgs e)
        {
            LoadUsers(FilterBy.Text, FilterByTB.Text);
        }

        private void FilterByIsActiveCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadUsers(FilterBy.Text, FilterByIsActiveCB.SelectedIndex == 0);
        }

        private void AddB_Click(object sender, EventArgs e)
        {
            AddAndUpdateUserForm aau = new AddAndUpdateUserForm();
            aau.ShowDialog();
            LoadUsers();
        }

        private void ShowAndEditInfo_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                AddAndUpdateUserForm aau = new AddAndUpdateUserForm
                ((int)dataGridView1.SelectedRows[0].Cells["PersonID"].Value);
                aau.ShowDialog();
                LoadUsers();
            }
        }

        private void DeleteUser_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (MyDB.DeleteUser((int)dataGridView1.SelectedRows[0].Cells["UserID"].Value))
                {
                    LoadUsers();
                    MessageBox.Show("Deleted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed to delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ChangePassword_Click(object sender, EventArgs e)
        {
            ChangePasswordForm cp = new ChangePasswordForm(MyDB.GetUser((int)dataGridView1.SelectedRows[0].Cells["PersonID"].Value));
            cp.ShowDialog();
        }
    }
}