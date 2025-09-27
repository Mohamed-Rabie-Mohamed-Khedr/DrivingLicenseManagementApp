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
    public partial class ManageTestTypes : Form
    {
        public ManageTestTypes()
        {
            InitializeComponent();
        }

        private void ManageTestTypes_Load(object sender, EventArgs e)
        {
            LoadTestTypes();
        }

        void LoadTestTypes()
        {
            dataGridView1.Rows.Clear();
            DataTable dataTable = MyDB.GetTestTypes();
            if (dataTable != null)
            {
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    dataGridView1.Rows.Add(dataTable.Rows[i]["TestTypeID"], dataTable.Rows[i]["TestTypeTitle"], dataTable.Rows[i]["TestTypeDescription"], dataTable.Rows[i]["TestTypeFees"]);
                }
                RecordsL.Text = "Records: " + dataTable.Rows.Count.ToString();
            }
            else MessageBox.Show("Failed to load test types", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void EditTestTypesB_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                EditTestTypes ett = new EditTestTypes((int)dataGridView1.SelectedRows[0].Cells["ID"].Value);
                ett.ShowDialog();
                LoadTestTypes();
            }
        }
    }
}