namespace DrivingLicenseManagement
{
    partial class ManageLocalDrivingLicenseApplications
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.LDLAppID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DrivingClass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NationalNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FallName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApplicationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PassedTests = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showEditApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteApplicationB = new System.Windows.Forms.ToolStripMenuItem();
            this.CancelApplicationB = new System.Windows.Forms.ToolStripMenuItem();
            this.SechduleTestsB = new System.Windows.Forms.ToolStripMenuItem();
            this.issueDrivingLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showPersonLicenseHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RecordsL = new System.Windows.Forms.Label();
            this.FilterByCB = new System.Windows.Forms.ComboBox();
            this.FilterByTB = new System.Windows.Forms.TextBox();
            this.AddB = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.StatusCB = new System.Windows.Forms.ComboBox();
            this.FilterB = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Coral;
            this.label3.Location = new System.Drawing.Point(335, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(636, 35);
            this.label3.TabIndex = 41;
            this.label3.Text = "Manage Local Driving License Applications";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LDLAppID,
            this.DrivingClass,
            this.NationalNo,
            this.FallName,
            this.ApplicationDate,
            this.PassedTests,
            this.Status});
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 166);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1227, 392);
            this.dataGridView1.TabIndex = 40;
            // 
            // LDLAppID
            // 
            this.LDLAppID.HeaderText = "L.D.L App ID";
            this.LDLAppID.Name = "LDLAppID";
            this.LDLAppID.ReadOnly = true;
            // 
            // DrivingClass
            // 
            this.DrivingClass.HeaderText = "Driving Class";
            this.DrivingClass.Name = "DrivingClass";
            this.DrivingClass.ReadOnly = true;
            // 
            // NationalNo
            // 
            this.NationalNo.HeaderText = "National No";
            this.NationalNo.Name = "NationalNo";
            this.NationalNo.ReadOnly = true;
            // 
            // FallName
            // 
            this.FallName.HeaderText = "Fall Name";
            this.FallName.Name = "FallName";
            this.FallName.ReadOnly = true;
            // 
            // ApplicationDate
            // 
            this.ApplicationDate.HeaderText = "Application Date";
            this.ApplicationDate.Name = "ApplicationDate";
            this.ApplicationDate.ReadOnly = true;
            // 
            // PassedTests
            // 
            this.PassedTests.HeaderText = "Passed Tests";
            this.PassedTests.Name = "PassedTests";
            this.PassedTests.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showEditApplicationToolStripMenuItem,
            this.DeleteApplicationB,
            this.CancelApplicationB,
            this.SechduleTestsB,
            this.issueDrivingLicenseToolStripMenuItem,
            this.showLicenseToolStripMenuItem,
            this.showPersonLicenseHistoryToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(226, 180);
            // 
            // showEditApplicationToolStripMenuItem
            // 
            this.showEditApplicationToolStripMenuItem.Name = "showEditApplicationToolStripMenuItem";
            this.showEditApplicationToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.showEditApplicationToolStripMenuItem.Text = "Show / Edit Application";
            // 
            // DeleteApplicationB
            // 
            this.DeleteApplicationB.Name = "DeleteApplicationB";
            this.DeleteApplicationB.Size = new System.Drawing.Size(225, 22);
            this.DeleteApplicationB.Text = "Delete Application";
            this.DeleteApplicationB.Click += new System.EventHandler(this.DeleteApplicationB_Click);
            // 
            // CancelApplicationB
            // 
            this.CancelApplicationB.Name = "CancelApplicationB";
            this.CancelApplicationB.Size = new System.Drawing.Size(225, 22);
            this.CancelApplicationB.Text = "Cancel Application";
            this.CancelApplicationB.Click += new System.EventHandler(this.CancelApplicationB_Click);
            // 
            // SechduleTestsB
            // 
            this.SechduleTestsB.Name = "SechduleTestsB";
            this.SechduleTestsB.Size = new System.Drawing.Size(225, 22);
            this.SechduleTestsB.Text = "Sechdule Tests";
            // 
            // issueDrivingLicenseToolStripMenuItem
            // 
            this.issueDrivingLicenseToolStripMenuItem.Name = "issueDrivingLicenseToolStripMenuItem";
            this.issueDrivingLicenseToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.issueDrivingLicenseToolStripMenuItem.Text = "Issue Driving License";
            // 
            // showLicenseToolStripMenuItem
            // 
            this.showLicenseToolStripMenuItem.Name = "showLicenseToolStripMenuItem";
            this.showLicenseToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.showLicenseToolStripMenuItem.Text = "Show License";
            // 
            // showPersonLicenseHistoryToolStripMenuItem
            // 
            this.showPersonLicenseHistoryToolStripMenuItem.Name = "showPersonLicenseHistoryToolStripMenuItem";
            this.showPersonLicenseHistoryToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.showPersonLicenseHistoryToolStripMenuItem.Text = "Show Person License History";
            // 
            // RecordsL
            // 
            this.RecordsL.AutoSize = true;
            this.RecordsL.BackColor = System.Drawing.Color.Transparent;
            this.RecordsL.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecordsL.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RecordsL.Location = new System.Drawing.Point(7, 561);
            this.RecordsL.Name = "RecordsL";
            this.RecordsL.Size = new System.Drawing.Size(96, 25);
            this.RecordsL.TabIndex = 39;
            this.RecordsL.Text = "Records";
            // 
            // FilterByCB
            // 
            this.FilterByCB.FormattingEnabled = true;
            this.FilterByCB.Items.AddRange(new object[] {
            "None",
            "L.D.L AppID",
            "National No",
            "Full Name",
            "Status"});
            this.FilterByCB.Location = new System.Drawing.Point(115, 126);
            this.FilterByCB.Name = "FilterByCB";
            this.FilterByCB.Size = new System.Drawing.Size(121, 21);
            this.FilterByCB.TabIndex = 46;
            this.FilterByCB.SelectedIndexChanged += new System.EventHandler(this.FilterByCB_SelectedIndexChanged);
            // 
            // FilterByTB
            // 
            this.FilterByTB.Location = new System.Drawing.Point(253, 126);
            this.FilterByTB.Name = "FilterByTB";
            this.FilterByTB.Size = new System.Drawing.Size(155, 20);
            this.FilterByTB.TabIndex = 44;
            this.FilterByTB.Visible = false;
            // 
            // AddB
            // 
            this.AddB.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddB.Location = new System.Drawing.Point(1164, 126);
            this.AddB.Name = "AddB";
            this.AddB.Size = new System.Drawing.Size(75, 34);
            this.AddB.TabIndex = 43;
            this.AddB.Text = "ADD";
            this.AddB.UseVisualStyleBackColor = true;
            this.AddB.Click += new System.EventHandler(this.AddB_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 25);
            this.label1.TabIndex = 42;
            this.label1.Text = "Filter By";
            // 
            // StatusCB
            // 
            this.StatusCB.FormattingEnabled = true;
            this.StatusCB.Items.AddRange(new object[] {
            "All",
            "New",
            "Canceled",
            "Completed"});
            this.StatusCB.Location = new System.Drawing.Point(253, 126);
            this.StatusCB.Name = "StatusCB";
            this.StatusCB.Size = new System.Drawing.Size(121, 21);
            this.StatusCB.TabIndex = 47;
            this.StatusCB.SelectedIndexChanged += new System.EventHandler(this.StatusCB_SelectedIndexChanged);
            // 
            // FilterB
            // 
            this.FilterB.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FilterB.Location = new System.Drawing.Point(428, 115);
            this.FilterB.Name = "FilterB";
            this.FilterB.Size = new System.Drawing.Size(86, 34);
            this.FilterB.TabIndex = 48;
            this.FilterB.Text = "Filter";
            this.FilterB.UseVisualStyleBackColor = true;
            this.FilterB.Click += new System.EventHandler(this.FilterB_Click);
            // 
            // ManageLocalDrivingLicenseApplications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1251, 593);
            this.Controls.Add(this.FilterB);
            this.Controls.Add(this.StatusCB);
            this.Controls.Add(this.FilterByCB);
            this.Controls.Add(this.FilterByTB);
            this.Controls.Add(this.AddB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.RecordsL);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ManageLocalDrivingLicenseApplications";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Local Driving License Applications";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label RecordsL;
        private System.Windows.Forms.ComboBox FilterByCB;
        private System.Windows.Forms.TextBox FilterByTB;
        private System.Windows.Forms.Button AddB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn LDLAppID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DrivingClass;
        private System.Windows.Forms.DataGridViewTextBoxColumn NationalNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FallName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApplicationDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn PassedTests;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.ComboBox StatusCB;
        private System.Windows.Forms.Button FilterB;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showEditApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteApplicationB;
        private System.Windows.Forms.ToolStripMenuItem CancelApplicationB;
        private System.Windows.Forms.ToolStripMenuItem SechduleTestsB;
        private System.Windows.Forms.ToolStripMenuItem issueDrivingLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showPersonLicenseHistoryToolStripMenuItem;
    }
}