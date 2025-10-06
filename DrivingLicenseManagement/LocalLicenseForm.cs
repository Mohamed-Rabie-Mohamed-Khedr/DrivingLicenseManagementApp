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
    public partial class LocalLicenseForm : Form
    {
        DataTable dt;
        User_Info user_Info1 = new User_Info() { Dock = DockStyle.Fill };
        public LocalLicenseForm(int personIDToUpdate = 0)
        {
            InitializeComponent();
            if (personIDToUpdate > 0)
            {
                user_Info1 = new User_Info(personIDToUpdate) { Dock = DockStyle.Fill };
            }
            tabControl1.TabPages[0].Controls.Add(user_Info1);

            ApplicationDateL.Text += " " + DateTime.Now.ToString();
            CreatedByL.Text += " " + DLMHelper.CurrentUser.UserName;

            dt = MyDB.GetLicenseClasses();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                LicenseClassCB.Items.Add(dt.Rows[i]["ClassName"]);
            }
            LicenseClassCB.SelectedIndex = 0;
        }

        private void Next_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(1);
        }

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (user_Info1.PersonIDToUpdate == 0)
            {
                e.Cancel = true;
                MessageBox.Show("Please Select Person First", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            LDLApp ldlApp = RaedLDLAppFromForm();
            if (MyDB.AddLDLApp(ref ldlApp))
            {
                ApplicationIDL.Text = "LDL. Application ID: " + ldlApp.ApplicationID.ToString();
                MessageBox.Show("Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Failed to add", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        LDLApp RaedLDLAppFromForm()
        {
            LDLApp ldlApp = new LDLApp();
            ldlApp.ApplicantPersonID = user_Info1.PersonIDToUpdate;
            ldlApp.LicenseClassID = LicenseClassCB.SelectedIndex + 1;
            ldlApp.ApplicationDate = DateTime.Now;
            ldlApp.ApplicationTypeID = 1;
            ldlApp.ApplicationStatus = 1;
            ldlApp.LastStatusDate = DateTime.Now;
            ldlApp.PaidFees = 15;
            ldlApp.CreatedByUserID = DLMHelper.CurrentUser.UserID;
            return ldlApp;
        }
    }
}