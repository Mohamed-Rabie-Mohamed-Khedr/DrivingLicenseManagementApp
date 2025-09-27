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
    public partial class EditTestTypes : Form
    {
        int CurrentTestTypeID;
        public EditTestTypes(int currentTestTypeID)
        {
            InitializeComponent();
            CurrentTestTypeID = currentTestTypeID;
        }

        private void EditTestTypes_Load(object sender, EventArgs e)
        {
            LoadTestType();
        }

        void LoadTestType()
        {
            TestType tt = MyDB.GetTestType(ref CurrentTestTypeID);
            IDL.Text = "ID: " + tt.TestTypeID.ToString();
            TitleTB.Text = tt.TestTypeTitle;
            DescriptionTB.Text = tt.TestTypeDescription;
            FeesNUD.Value = tt.TestTypeFees;
        }

        private void SaveB_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TitleTB.Text))
                MessageBox.Show("Please Enter Test Type Title", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (string.IsNullOrEmpty(DescriptionTB.Text))
                MessageBox.Show("Please Enter Test Type Description", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                TestType tt = new TestType();
                tt.TestTypeID = CurrentTestTypeID;
                tt.TestTypeTitle = TitleTB.Text;
                tt.TestTypeDescription = DescriptionTB.Text;
                tt.TestTypeFees = FeesNUD.Value;
                if (MyDB.UpdateTestType(ref tt))
                {
                    MessageBox.Show("Test Type updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Failed to update test type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}