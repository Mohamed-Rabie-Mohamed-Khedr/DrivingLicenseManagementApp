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
    public partial class TestsForm : Form
    {
        enum TestType { Schedule_Vision_Test = 1, Schedule_Written_Test, Schedule_Street_Test };
        TestType testType;
        LDLApp ldlapp;
        string MyTitle;
        public TestsForm(ref LDLApp l)
        {
            InitializeComponent();

            testType = (TestType)l.PassedTests+1;
            MyTitle = testType.ToString().Replace("_", " ");
            Text = TitleL.Text = MyTitle;

            ldlapp = l;
            LDLAInfo ldl = new LDLAInfo(ref l) { Location = new Point(0, 36) };
            this.Controls.Add(ldl);
        }
        void LoadAppointments()
        {
            dataGridView1.Rows.Clear();
            DataTable dt = MyDB.GetTestAppointments(ldlapp.LDLAppID, (byte)testType);
            if (dt != null)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dataGridView1.Rows.Add(dt.Rows[i]["TestAppointmentID"],
                    dt.Rows[i]["AppointmentDate"], ldlapp.TestTypeFees,
                    dt.Rows[i]["IsLocked"]);
                }
                RecordsL.Text = "Records: " + dt.Rows.Count.ToString();
            }
        }

        private void TestsForm_Load(object sender, EventArgs e)
        {
            LoadAppointments();
        }

        private void AddB_Click(object sender, EventArgs e)
        {
            if (MyDB.TestAppointmentIsExists(ldlapp.LDLAppID, ldlapp.TestTypeID))
                MessageBox.Show("This Person Already Has " + MyTitle + " Appointment", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (MyDB.TestIsPassed(ldlapp.LDLAppID, ldlapp.TestTypeID))
                MessageBox.Show("This Person Has Already Passed " + MyTitle, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                AddAndUpdateAppointmentForm aaf = new AddAndUpdateAppointmentForm(ref ldlapp, ref MyTitle, 0);
                aaf.ShowDialog();
                LoadAppointments();
            }
        }

        private void EditB_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                AddAndUpdateAppointmentForm aaf = new AddAndUpdateAppointmentForm(ref ldlapp, ref MyTitle, (int)dataGridView1.SelectedRows[0].Cells["AppointmentID"].Value);
                aaf.ShowDialog();
                LoadAppointments();
            }
        }

        private void takeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                int appointmentID = (int)dataGridView1.SelectedRows[0].Cells["AppointmentID"].Value;
                TestAppointment ta = MyDB.GetTestAppointment(appointmentID);
                TakeTestForm ttf = new TakeTestForm(ref ta, ref ldlapp);
                ttf.ShowDialog();
                LoadAppointments();
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                EditB.Enabled = TakeTestB.Enabled = !((bool)dataGridView1.SelectedRows[0].Cells["IsLocked"].Value);
            }
        }
    }
}