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
    public partial class ChangePasswordForm : Form
    {
        public ChangePasswordForm(User user)
        {
            InitializeComponent();
            User_Info user_Info1 = new User_Info(user.PersonID) { Dock = DockStyle.Top };
            Controls.Add(user_Info1);
            changePassword1.CUser = user;
        }
    }
}