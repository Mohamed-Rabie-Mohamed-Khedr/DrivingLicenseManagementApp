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
    public partial class LDLAInfoForm : Form
    {
        public LDLAInfoForm(ref LDLApp ldlapp)
        {
            InitializeComponent();
            LDLAInfo l= new LDLAInfo(ref ldlapp) { Dock = DockStyle.Fill };
            this.Controls.Add(l);
        }
    }
}