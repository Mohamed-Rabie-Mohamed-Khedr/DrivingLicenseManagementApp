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
    public partial class AddAndUpdatePersonForm : Form
    {
        public AddAndUpdatePersonForm(string nationalNo = "")
        {
            InitializeComponent();
            AddAndUpdatePerson up = new AddAndUpdatePerson(ref nationalNo)
            {
                Dock = DockStyle.Fill
            };
            Controls.Add(up);
        }
    }
}