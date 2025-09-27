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
    public partial class EditApplicationType : Form
    {
        int CurrentApplicationTypeID;
        public EditApplicationType(int ApplicationTypeID)
        {
            InitializeComponent();
            ApplicationType at = MyDB.GetApplicationType(ApplicationTypeID);
            CurrentApplicationTypeID = ApplicationTypeID;
            TitleTB.Text = at.ApplicationTypeTitle;
            FeesNUD.Value = at.ApplicationFees;
        }

        private void SaveB_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TitleTB.Text))
                MessageBox.Show("Please Enter Application Type Title", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                ApplicationType at = new ApplicationType();
                at.ApplicationTypeID = CurrentApplicationTypeID;
                at.ApplicationTypeTitle = TitleTB.Text;
                at.ApplicationFees = FeesNUD.Value;
                if (MyDB.UpdateApplicationType(ref at))
                {
                    MessageBox.Show("Application Type updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Failed to update application type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}