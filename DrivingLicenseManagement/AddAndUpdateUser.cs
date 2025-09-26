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
    public partial class AddAndUpdateUser : UserControl
    {
        Status myStatus = Status.Add;
        public int CurrentPersonID;
        public AddAndUpdateUser()
        {
            InitializeComponent();
        }

        public void LoadUserAndSetUpdateMode()
        {
            myStatus = Status.Update;
            User user = MyDB.GetUser(CurrentPersonID);
            label2.Text = "Update User";
            UserIDL.Text = "User ID: " + user.UserID.ToString();
            UserNameTB.Text = user.UserName;
            PasswordTB.Text = user.Password;
            ConfirmPasswordTB.Text = user.Password;
            IsActiveCB.Checked = user.IsActive;
        }

        private void SaveB_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(UserNameTB.Text))
                MessageBox.Show("Please Enter User Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (string.IsNullOrEmpty(PasswordTB.Text) || string.IsNullOrEmpty(ConfirmPasswordTB.Text))
                MessageBox.Show("Please Enter Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (PasswordTB.Text != ConfirmPasswordTB.Text)
                MessageBox.Show("Password and Confirm Password Not Match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                User user = RaedUserFromForm();
                if (myStatus == Status.Add)
                {
                    if (MyDB.AddUser(ref user))
                    {
                        UserIDL.Text = "User ID: " + user.UserID.ToString();
                        MessageBox.Show("Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Failed to add", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (myStatus == Status.Update)
                {
                    if (MyDB.UpdateUser(ref user))
                    {
                        MessageBox.Show("Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Failed to update", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        User RaedUserFromForm()
        {
            User user = new User();
            user.PersonID = CurrentPersonID;
            user.UserName = UserNameTB.Text;
            user.Password = PasswordTB.Text;
            user.IsActive = IsActiveCB.Checked;
            return user;
        }
    }
}