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
        User_Info user_Info1 = new User_Info() { Dock = DockStyle.Fill };
        public AddAndUpdateUserForm(int personIDToUpdate = 0)
        {
            InitializeComponent();
            if (personIDToUpdate > 0)
            {
                user_Info1 = new User_Info(personIDToUpdate) { Dock = DockStyle.Fill };
                changePassword1.CurrentPersonID = personIDToUpdate;
                changePassword1.LoadUserAndSetUpdateMode();
            }
            tabControl1.TabPages[0].Controls.Add(user_Info1);
        }
        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (user_Info1.PersonIDToUpdate == 0)
            {
                e.Cancel = true;
                MessageBox.Show("Please Select Person First", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                changePassword1.CurrentPersonID = user_Info1.PersonIDToUpdate;
            }
        }
        private void Next_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(1);
        }
    }
}