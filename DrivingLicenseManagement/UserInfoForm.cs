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
    public partial class UserInfoForm : Form
    {
        public UserInfoForm(User user)
        {
            InitializeComponent();
            personInfo1.LoadPerson(user.PersonID);
            user_Info1.LoadUser(user);
        }
    }
}