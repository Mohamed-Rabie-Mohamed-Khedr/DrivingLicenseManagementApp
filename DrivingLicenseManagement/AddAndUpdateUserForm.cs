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
    public partial class AddAndUpdateUserForm : Form
    {
        int PersonIDToUpdate = 0;
        public AddAndUpdateUserForm(int PersonIDToUpdate = 0)
        {
            InitializeComponent();

            if (PersonIDToUpdate == 0)
                user_Info1.Visible = false;
            else
            {
                this.PersonIDToUpdate = PersonIDToUpdate;
                label1.Visible
                = SelectPersonByIDTB.Visible
                = ResearchB.Visible = false;
                personInfo1.LoadPerson(PersonIDToUpdate);
                user_Info1.LoadUser(MyDB.GetUser(PersonIDToUpdate));
                changePassword1.CurrentPersonID = PersonIDToUpdate;
                changePassword1.LoadUserAndSetUpdateMode();
            }
        }
        private void ResearchB_Click(object sender, EventArgs e)
        {
            int PersonID = int.Parse(SelectPersonByIDTB.Text);
            bool UserIsExists = MyDB.UserIsExists(PersonID);
            if (MyDB.PersonIsExists(PersonID) && !UserIsExists)
            {
                PersonIDToUpdate = PersonID;
                changePassword1.CurrentPersonID = PersonID;
                personInfo1.LoadPerson(PersonID);
            }
            else if (UserIsExists)
                MessageBox.Show("this User is Exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MessageBox.Show("this Person is not Exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void SelectPersonByIDTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (PersonIDToUpdate == 0)
            {
                e.Cancel = true;
                MessageBox.Show("Please Select Person First", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Next_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(1);
        }
    }
}