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
    public partial class AddAndUpdateAppointmentForm : Form
    {
        LDLApp ldlapp;
        int AppointmentIDToUpdate;
        public AddAndUpdateAppointmentForm(ref LDLApp ldlapp, ref string Title, int AppIDToUpdate = 0)
        {
            InitializeComponent();
            AppointmentIDToUpdate = AppIDToUpdate;
            DateDTP.MinDate = DateTime.Now;
            this.ldlapp = ldlapp;
            Text = TitleL.Text = Title;
        }

        void LoadLDLApp()
        {
            DLAppIDL.Text = "D.L App ID: " + ldlapp.LDLAppID.ToString();
            DClasseL.Text = "D. Class: " + ldlapp.LicenseClassName;
            TrialL.Text = "Trial: " + MyDB.GetTestAppointmentIsLockedCount(ldlapp.LDLAppID, ldlapp.TestTypeID).ToString();
            NameL.Text = "Name: " + ldlapp.ApplicantName;
            FeesL.Text = "Fees: " + ldlapp.TestTypeFees.ToString("0");
        }

        private void AddAppointmentForm_Load(object sender, EventArgs e)
        {
            LoadLDLApp();
        }

        private void SaveB_Click(object sender, EventArgs e)
        {
            TestAppointment ta = new TestAppointment();
            ta.TestAppointmentID = AppointmentIDToUpdate;
            ta.AppointmentDate = DateDTP.Value.Date;
            ta.PaidFees = ldlapp.PaidFees;
            ta.TestTypeID = ldlapp.TestTypeID;
            ta.LDLAppID = ldlapp.LDLAppID;
            ta.CreatedByUserID = DLMHelper.CurrentUser.UserID;
            if (AppointmentIDToUpdate == 0)
            {
                if (MyDB.AddTestAppointment(ref ta, ldlapp.ApplicantPersonID))
                {
                    MessageBox.Show("Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                    MessageBox.Show("Failed to add", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MyDB.UpdateTestAppointment(ref ta))
                {
                    MessageBox.Show("Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                    MessageBox.Show("Failed to update", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}