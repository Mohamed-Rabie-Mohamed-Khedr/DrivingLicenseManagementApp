namespace DrivingLicenseManagement
{
    partial class ManageDetainedLicenses
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
            this.FilterByCB = new System.Windows.Forms.ComboBox();
            this.FilterByTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsReleased = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.FineFees = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReleaseDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NationalNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FallName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReleaseApplicationID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ShowPersonB = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowLicenseB = new System.Windows.Forms.ToolStripMenuItem();
            this.PersonLicenseHistoryB = new System.Windows.Forms.ToolStripMenuItem();
            this.releaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RecordsL = new System.Windows.Forms.Label();
            this.TitleL = new System.Windows.Forms.Label();
            this.IsReleasedCB = new System.Windows.Forms.ComboBox();
            this.DetainB = new System.Windows.Forms.Button();
            this.ReleaseB = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FilterByCB
            // 
            this.FilterByCB.FormattingEnabled = true;
            this.FilterByCB.Items.AddRange(new object[] {
            "None",
            "Detain ID",
            "Is Released",
            "National No",
            "Full Name",
            "Release Application ID"});
            this.FilterByCB.Location = new System.Drawing.Point(134, 216);
            this.FilterByCB.Name = "FilterByCB";
            this.FilterByCB.Size = new System.Drawing.Size(121, 21);
            this.FilterByCB.TabIndex = 56;
            this.FilterByCB.SelectedIndexChanged += new System.EventHandler(this.FilterByCB_SelectedIndexChanged);
            // 
            // FilterByTB
            // 
            this.FilterByTB.Location = new System.Drawing.Point(272, 216);
            this.FilterByTB.Name = "FilterByTB";
            this.FilterByTB.Size = new System.Drawing.Size(155, 20);
            this.FilterByTB.TabIndex = 55;
            this.FilterByTB.Visible = false;
            this.FilterByTB.TextChanged += new System.EventHandler(this.FilterByTB_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(31, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 25);
            this.label1.TabIndex = 54;
            this.label1.Text = "Filter By";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DID,
            this.LID,
            this.DDate,
            this.IsReleased,
            this.FineFees,
            this.ReleaseDate,
            this.NationalNo,
            this.FallName,
            this.ReleaseApplicationID});
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Location = new System.Drawing.Point(36, 246);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1227, 392);
            this.dataGridView1.TabIndex = 53;
            // 
            // DID
            // 
            this.DID.HeaderText = "D.ID";
            this.DID.Name = "DID";
            this.DID.ReadOnly = true;
            // 
            // LID
            // 
            this.LID.HeaderText = "L.ID";
            this.LID.Name = "LID";
            this.LID.ReadOnly = true;
            // 
            // DDate
            // 
            this.DDate.HeaderText = "D.Date";
            this.DDate.Name = "DDate";
            this.DDate.ReadOnly = true;
            // 
            // IsReleased
            // 
            this.IsReleased.HeaderText = "Is Released";
            this.IsReleased.Name = "IsReleased";
            this.IsReleased.ReadOnly = true;
            this.IsReleased.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IsReleased.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // FineFees
            // 
            this.FineFees.HeaderText = "Fine Fees";
            this.FineFees.Name = "FineFees";
            this.FineFees.ReadOnly = true;
            // 
            // ReleaseDate
            // 
            this.ReleaseDate.HeaderText = "Release Date";
            this.ReleaseDate.Name = "ReleaseDate";
            this.ReleaseDate.ReadOnly = true;
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
            // ReleaseApplicationID
            // 
            this.ReleaseApplicationID.HeaderText = "Release Application ID";
            this.ReleaseApplicationID.Name = "ReleaseApplicationID";
            this.ReleaseApplicationID.ReadOnly = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShowPersonB,
            this.ShowLicenseB,
            this.PersonLicenseHistoryB,
            this.releaseToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(226, 114);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // ShowPersonB
            // 
            this.ShowPersonB.Name = "ShowPersonB";
            this.ShowPersonB.Size = new System.Drawing.Size(225, 22);
            this.ShowPersonB.Text = "Show Person";
            this.ShowPersonB.Click += new System.EventHandler(this.ShowPersonB_Click);
            // 
            // ShowLicenseB
            // 
            this.ShowLicenseB.Name = "ShowLicenseB";
            this.ShowLicenseB.Size = new System.Drawing.Size(225, 22);
            this.ShowLicenseB.Text = "Show License";
            this.ShowLicenseB.Click += new System.EventHandler(this.ShowLicenseB_Click);
            // 
            // PersonLicenseHistoryB
            // 
            this.PersonLicenseHistoryB.Name = "PersonLicenseHistoryB";
            this.PersonLicenseHistoryB.Size = new System.Drawing.Size(225, 22);
            this.PersonLicenseHistoryB.Text = "Show Person License History";
            this.PersonLicenseHistoryB.Click += new System.EventHandler(this.PersonLicenseHistoryB_Click);
            // 
            // releaseToolStripMenuItem
            // 
            this.releaseToolStripMenuItem.Name = "releaseToolStripMenuItem";
            this.releaseToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.releaseToolStripMenuItem.Text = "Release";
            this.releaseToolStripMenuItem.Click += new System.EventHandler(this.releaseToolStripMenuItem_Click);
            // 
            // RecordsL
            // 
            this.RecordsL.AutoSize = true;
            this.RecordsL.BackColor = System.Drawing.Color.Transparent;
            this.RecordsL.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecordsL.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RecordsL.Location = new System.Drawing.Point(31, 641);
            this.RecordsL.Name = "RecordsL";
            this.RecordsL.Size = new System.Drawing.Size(96, 25);
            this.RecordsL.TabIndex = 52;
            this.RecordsL.Text = "Records";
            // 
            // TitleL
            // 
            this.TitleL.AutoSize = true;
            this.TitleL.BackColor = System.Drawing.Color.Transparent;
            this.TitleL.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleL.ForeColor = System.Drawing.Color.Coral;
            this.TitleL.Location = new System.Drawing.Point(495, 22);
            this.TitleL.Name = "TitleL";
            this.TitleL.Size = new System.Drawing.Size(402, 35);
            this.TitleL.TabIndex = 51;
            this.TitleL.Text = "Manage Detained Licenses";
            // 
            // IsReleasedCB
            // 
            this.IsReleasedCB.FormattingEnabled = true;
            this.IsReleasedCB.Items.AddRange(new object[] {
            "No",
            "Yas"});
            this.IsReleasedCB.Location = new System.Drawing.Point(272, 215);
            this.IsReleasedCB.Name = "IsReleasedCB";
            this.IsReleasedCB.Size = new System.Drawing.Size(121, 21);
            this.IsReleasedCB.TabIndex = 57;
            this.IsReleasedCB.SelectedIndexChanged += new System.EventHandler(this.IsReleasedCB_SelectedIndexChanged);
            // 
            // DetainB
            // 
            this.DetainB.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DetainB.Location = new System.Drawing.Point(957, 207);
            this.DetainB.Name = "DetainB";
            this.DetainB.Size = new System.Drawing.Size(163, 34);
            this.DetainB.TabIndex = 72;
            this.DetainB.Text = "Detain License";
            this.DetainB.UseVisualStyleBackColor = true;
            this.DetainB.Click += new System.EventHandler(this.DetainB_Click);
            // 
            // ReleaseB
            // 
            this.ReleaseB.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReleaseB.Location = new System.Drawing.Point(1166, 207);
            this.ReleaseB.Name = "ReleaseB";
            this.ReleaseB.Size = new System.Drawing.Size(97, 34);
            this.ReleaseB.TabIndex = 81;
            this.ReleaseB.Text = "Release";
            this.ReleaseB.UseVisualStyleBackColor = true;
            this.ReleaseB.Click += new System.EventHandler(this.ReleaseB_Click);
            // 
            // ManageDetainedLicenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1295, 670);
            this.Controls.Add(this.ReleaseB);
            this.Controls.Add(this.DetainB);
            this.Controls.Add(this.IsReleasedCB);
            this.Controls.Add(this.FilterByCB);
            this.Controls.Add(this.FilterByTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.RecordsL);
            this.Controls.Add(this.TitleL);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ManageDetainedLicenses";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Detained Licenses";
            this.Load += new System.EventHandler(this.ManageDetainedLicenses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
                        // Dark Mode Injection
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DetainB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DetainB.FlatAppearance.BorderSize = 0;
            this.DetainB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.DetainB.ForeColor = System.Drawing.Color.White;
            this.DetainB.UseVisualStyleBackColor = false;
            this.ReleaseB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReleaseB.FlatAppearance.BorderSize = 0;
            this.ReleaseB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.ReleaseB.ForeColor = System.Drawing.Color.White;
            this.ReleaseB.UseVisualStyleBackColor = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.dataGridView1.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.dataGridView1.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox FilterByCB;
        private System.Windows.Forms.TextBox FilterByTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label RecordsL;
        private System.Windows.Forms.Label TitleL;
        private System.Windows.Forms.DataGridViewTextBoxColumn DID;
        private System.Windows.Forms.DataGridViewTextBoxColumn LID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DDate;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsReleased;
        private System.Windows.Forms.DataGridViewTextBoxColumn FineFees;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReleaseDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn NationalNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FallName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReleaseApplicationID;
        private System.Windows.Forms.ComboBox IsReleasedCB;
        private System.Windows.Forms.Button DetainB;
        private System.Windows.Forms.Button ReleaseB;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ShowPersonB;
        private System.Windows.Forms.ToolStripMenuItem ShowLicenseB;
        private System.Windows.Forms.ToolStripMenuItem PersonLicenseHistoryB;
        private System.Windows.Forms.ToolStripMenuItem releaseToolStripMenuItem;
    }
}
