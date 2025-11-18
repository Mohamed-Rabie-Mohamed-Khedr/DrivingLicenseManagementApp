using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IdentityModel.Protocols.WSTrust;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrivingLicenseManagement
{
    public partial class TakeTestForm : Form
    {
        TestAppointment testAppointment;
        public TakeTestForm(ref TestAppointment ta, ref LDLApp ldlapp)
        {
            InitializeComponent();
            testAppointment = ta;
            DLAppIDL.Text = "D.L App ID: " + ldlapp.LDLAppID.ToString();
            DClasseL.Text = "D. Class: " + ldlapp.LicenseClassName;
            DateL.Text = "Date: " + ta.AppointmentDate.ToString();
            TrialL.Text = "Trial: " + MyDB.GetTestAppointmentIsLockedCount(ldlapp.LDLAppID, ldlapp.TestTypeID).ToString();
            NameL.Text = "Name: " + ldlapp.ApplicantName;
            FeesL.Text = "Fees: " + ldlapp.TestTypeFees.ToString("0");
        }

        private void TakeTestForm_Load(object sender, EventArgs e)
        {
            TestResultCB.SelectedIndex = 0;
        }

        private void SaveB_Click(object sender, EventArgs e)
        {
            Test test = new Test();
            test.TestAppointmentID = testAppointment.TestAppointmentID;
            test.TestResult = (byte)TestResultCB.SelectedIndex;
            test.Notes = NotesTB.Text;
            test.CreatedByUserID = DLMHelper.CurrentUser.UserID;
            testAppointment.IsLocked = 1;
            
            if (MyDB.AddTest(ref test) && MyDB.UpdateTestAppointment(ref testAppointment))
            {
                MessageBox.Show("Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
                MessageBox.Show("Failed to add", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}