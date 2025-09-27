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
    public partial class ManageApplicationTypes : Form
    {
        public ManageApplicationTypes()
        {
            InitializeComponent();
        }

        private void ManageApplicationTypes_Load(object sender, EventArgs e)
        {
            LoadApplicationTypes();
        }

        void LoadApplicationTypes()
        {
            dataGridView1.Rows.Clear();
            DataTable dataTable = MyDB.GetApplicationTypes();
            if (dataTable != null)
            {
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    dataGridView1.Rows.Add(dataTable.Rows[i]["ApplicationTypeID"], dataTable.Rows[i]["ApplicationTypeTitle"], dataTable.Rows[i]["ApplicationFees"]);
                }
                RecordsL.Text = "Records: " + dataTable.Rows.Count.ToString();
            }
            else
                MessageBox.Show("Failed to load application types", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void EditApplicationType_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0) return;
            EditApplicationType eat = new EditApplicationType((int)dataGridView1.SelectedRows[0].Cells["ID"].Value);
            eat.ShowDialog();
            LoadApplicationTypes();
        }
    }
}