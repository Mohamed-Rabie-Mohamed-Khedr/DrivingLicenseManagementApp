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
    public partial class IssueDriverLicense : Form
    {
        LDLApp ldlapp;
        public IssueDriverLicense(ref LDLApp l)
        {
            InitializeComponent();
            ldlapp = l;
            LDLAInfo ldl = new LDLAInfo(ref l) { Dock = DockStyle.Top };
            this.Controls.Add(ldl);
        }

        private void IssueB_Click(object sender, EventArgs e)
        {
            Driver d = new Driver();
            d.PersonID = ldlapp.ApplicantPersonID;
            d.CreatedByUserID = ldlapp.CreatedByUserID;
            d.CreatedDate = DateTime.Now;


            if (MyDB.AddDriver(ref d))
            {
                License l = new License();
                l.ApplicationID = ldlapp.ApplicationID;
                l.DriverID = d.DriverID;
                l.LicenseClass = ldlapp.LicenseClassID;
                l.IssueDate = DateTime.Now;
                l.ExpirationDate = DateTime.Now.AddYears(ldlapp.DefaultValidityLength);
                l.Notes = NotesTB.Text;
                l.PaidFees = ldlapp.PaidFees;
                l.IsActive = true;
                l.IssueReason = (byte)ldlapp.ApplicationTypeID;
                l.CreatedByUserID = DLMHelper.CurrentUser.UserID;
                if (MyDB.AddLicense(ref l) && MyDB.UpdateApplicationStatus(ldlapp.ApplicationID, 3))
                {
                    MessageBox.Show("Driver License Issued Successfully");
                    this.Close();
                }
                else MessageBox.Show("Error Adding License");
            }
            else MessageBox.Show("Error Adding License");
        }
    }
}