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
        public User_Info()
        {
            InitializeComponent();
        }
        public void LoadUser(User user)
        {
            UserIDL.Text = "User ID: " + user.UserID.ToString();
            UserNameL.Text = "User Name: " + user.UserName;
            IsActiveL.Text = "Is Active: " + (user.IsActive ? "Yes" : "No");
        }
    }
}