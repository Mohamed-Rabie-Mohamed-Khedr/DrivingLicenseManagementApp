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
    public partial class User_Info : UserControl
    {
        public int PersonIDToUpdate { get; set; }
        public User_Info(int PersonID = 0)
        {
            PersonIDToUpdate = PersonID;
            InitializeComponent();
        }

        private void ResearchB_Click(object sender, EventArgs e)
        {
            int PersonID = int.Parse(SelectPersonByIDTB.Text);
            bool UserIsExists = MyDB.UserIsExists(PersonID);
            if (MyDB.PersonIsExists(PersonID) && !UserIsExists)
            {
                PersonIDToUpdate = PersonID;
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

        private void User_Info_Load(object sender, EventArgs e)
        {
            if (PersonIDToUpdate > 0)
            {
                label2.Visible
                = SelectPersonByIDTB.Visible
                = ResearchB.Visible = false;
                User user = MyDB.GetUser(PersonIDToUpdate);
                UserIDL.Text = "User ID: " + user.UserID.ToString();
                UserNameL.Text = "User Name: " + user.UserName;
                IsActiveL.Text = "Is Active: " + (user.IsActive ? "Yes" : "No");
                personInfo1.LoadPerson(user.PersonID);
            }
        }
    }
}