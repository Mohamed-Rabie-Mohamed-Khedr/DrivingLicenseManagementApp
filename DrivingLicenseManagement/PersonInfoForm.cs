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
    public partial class PersonInfoForm : Form
    {
        public PersonInfoForm(int PersonID = 0)
        {
            InitializeComponent();
            PersonInfo pi = new PersonInfo() { Dock = DockStyle.Fill };
            Controls.Add(pi);
            if (PersonID > 0) pi.SetPersonInfo(ref PersonID);
        }
    }
}
