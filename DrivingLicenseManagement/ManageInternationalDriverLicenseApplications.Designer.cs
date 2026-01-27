namespace DrivingLicenseManagement
{
    partial class ManageInternationalDriverLicenseApplications
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
            this.ILID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DriverID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApplicationID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LLicenseID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IssueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpirationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsActive = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showPersonLicenseHistoryB = new System.Windows.Forms.ToolStripMenuItem();
            this.showInternationalLicenseInfoB = new System.Windows.Forms.ToolStripMenuItem();
            this.showPersonInfoB = new System.Windows.Forms.ToolStripMenuItem();
            this.RecordsL = new System.Windows.Forms.Label();
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
            this.label3.Location = new System.Drawing.Point(269, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(739, 35);
            this.label3.TabIndex = 42;
            this.label3.Text = "Manage International Driver License Applications";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ILID,
            this.DriverID,
            this.ApplicationID,
            this.LLicenseID,
            this.IssueDate,
            this.ExpirationDate,
            this.IsActive});
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 338);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1227, 392);
            this.dataGridView1.TabIndex = 50;
            // 
            // ILID
            // 
            this.ILID.HeaderText = "I L ID";
            this.ILID.Name = "ILID";
            this.ILID.ReadOnly = true;
            // 
            // DriverID
            // 
            this.DriverID.HeaderText = "Driver ID";
            this.DriverID.Name = "DriverID";
            this.DriverID.ReadOnly = true;
            // 
            // ApplicationID
            // 
            this.ApplicationID.HeaderText = "Application ID";
            this.ApplicationID.Name = "ApplicationID";
            this.ApplicationID.ReadOnly = true;
            // 
            // LLicenseID
            // 
            this.LLicenseID.HeaderText = "L LicenseID";
            this.LLicenseID.Name = "LLicenseID";
            this.LLicenseID.ReadOnly = true;
            // 
            // IssueDate
            // 
            this.IssueDate.HeaderText = "Issue Date";
            this.IssueDate.Name = "IssueDate";
            this.IssueDate.ReadOnly = true;
            // 
            // ExpirationDate
            // 
            this.ExpirationDate.HeaderText = "Expiration Date";
            this.ExpirationDate.Name = "ExpirationDate";
            this.ExpirationDate.ReadOnly = true;
            // 
            // IsActive
            // 
            this.IsActive.HeaderText = "Is Active";
            this.IsActive.Name = "IsActive";
            this.IsActive.ReadOnly = true;
            this.IsActive.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IsActive.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showPersonLicenseHistoryB,
            this.showInternationalLicenseInfoB,
            this.showPersonInfoB});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(240, 92);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // showPersonLicenseHistoryB
            // 
            this.showPersonLicenseHistoryB.Name = "showPersonLicenseHistoryB";
            this.showPersonLicenseHistoryB.Size = new System.Drawing.Size(239, 22);
            this.showPersonLicenseHistoryB.Text = "Show Person License History";
            this.showPersonLicenseHistoryB.Click += new System.EventHandler(this.showPersonLicenseHistoryB_Click);
            // 
            // showInternationalLicenseInfoB
            // 
            this.showInternationalLicenseInfoB.Name = "showInternationalLicenseInfoB";
            this.showInternationalLicenseInfoB.Size = new System.Drawing.Size(239, 22);
            this.showInternationalLicenseInfoB.Text = "Show International License Info";
            this.showInternationalLicenseInfoB.Click += new System.EventHandler(this.showInternationalLicenseInfoB_Click);
            // 
            // showPersonInfoB
            // 
            this.showPersonInfoB.Name = "showPersonInfoB";
            this.showPersonInfoB.Size = new System.Drawing.Size(239, 22);
            this.showPersonInfoB.Text = "Show Person Info";
            this.showPersonInfoB.Click += new System.EventHandler(this.showPersonInfoB_Click);
            // 
            // RecordsL
            // 
            this.RecordsL.AutoSize = true;
            this.RecordsL.BackColor = System.Drawing.Color.Transparent;
            this.RecordsL.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecordsL.ForeColor = System.Drawing.Color.Black;
            this.RecordsL.Location = new System.Drawing.Point(7, 733);
            this.RecordsL.Name = "RecordsL";
            this.RecordsL.Size = new System.Drawing.Size(96, 25);
            this.RecordsL.TabIndex = 49;
            this.RecordsL.Text = "Records";
            // 
            // ManageInternationalDriverLicenseApplications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 758);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.RecordsL);
            this.Controls.Add(this.label3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ManageInternationalDriverLicenseApplications";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "International Driver License Applications";
            this.Load += new System.EventHandler(this.ManageInternationalDriverLicenseApplications_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label RecordsL;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showPersonLicenseHistoryB;
        private System.Windows.Forms.ToolStripMenuItem showInternationalLicenseInfoB;
        private System.Windows.Forms.ToolStripMenuItem showPersonInfoB;
        private System.Windows.Forms.DataGridViewTextBoxColumn ILID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DriverID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApplicationID;
        private System.Windows.Forms.DataGridViewTextBoxColumn LLicenseID;
        private System.Windows.Forms.DataGridViewTextBoxColumn IssueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpirationDate;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsActive;
    }
}