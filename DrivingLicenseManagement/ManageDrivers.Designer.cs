namespace DrivingLicenseManagement
{
    partial class ManageDrivers
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
            this.TitleL = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DriverID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PersonID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NationalNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FallName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActiveLicenses = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.RecordsL = new System.Windows.Forms.Label();
            this.FilterByCB = new System.Windows.Forms.ComboBox();
            this.FilterByTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleL
            // 
            this.TitleL.AutoSize = true;
            this.TitleL.BackColor = System.Drawing.Color.Transparent;
            this.TitleL.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleL.ForeColor = System.Drawing.Color.Coral;
            this.TitleL.Location = new System.Drawing.Point(538, 35);
            this.TitleL.Name = "TitleL";
            this.TitleL.Size = new System.Drawing.Size(244, 35);
            this.TitleL.TabIndex = 43;
            this.TitleL.Text = "Manage Drivers";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DriverID,
            this.PersonID,
            this.NationalNo,
            this.FallName,
            this.Date,
            this.ActiveLicenses});
            this.dataGridView1.Location = new System.Drawing.Point(13, 259);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1227, 392);
            this.dataGridView1.TabIndex = 45;
            // 
            // DriverID
            // 
            this.DriverID.HeaderText = "Driver ID";
            this.DriverID.Name = "DriverID";
            this.DriverID.ReadOnly = true;
            // 
            // PersonID
            // 
            this.PersonID.HeaderText = "Person ID";
            this.PersonID.Name = "PersonID";
            this.PersonID.ReadOnly = true;
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
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // ActiveLicenses
            // 
            this.ActiveLicenses.HeaderText = "Active Licenses";
            this.ActiveLicenses.Name = "ActiveLicenses";
            this.ActiveLicenses.ReadOnly = true;
            this.ActiveLicenses.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ActiveLicenses.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // RecordsL
            // 
            this.RecordsL.AutoSize = true;
            this.RecordsL.BackColor = System.Drawing.Color.Transparent;
            this.RecordsL.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecordsL.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RecordsL.Location = new System.Drawing.Point(8, 654);
            this.RecordsL.Name = "RecordsL";
            this.RecordsL.Size = new System.Drawing.Size(96, 25);
            this.RecordsL.TabIndex = 44;
            this.RecordsL.Text = "Records";
            // 
            // FilterByCB
            // 
            this.FilterByCB.FormattingEnabled = true;
            this.FilterByCB.Items.AddRange(new object[] {
            "None",
            "Driver ID",
            "Person ID",
            "National No",
            "Full Name"});
            this.FilterByCB.Location = new System.Drawing.Point(111, 229);
            this.FilterByCB.Name = "FilterByCB";
            this.FilterByCB.Size = new System.Drawing.Size(121, 21);
            this.FilterByCB.TabIndex = 50;
            this.FilterByCB.SelectedIndexChanged += new System.EventHandler(this.FilterByCB_SelectedIndexChanged);
            // 
            // FilterByTB
            // 
            this.FilterByTB.Location = new System.Drawing.Point(249, 229);
            this.FilterByTB.Name = "FilterByTB";
            this.FilterByTB.Size = new System.Drawing.Size(155, 20);
            this.FilterByTB.TabIndex = 49;
            this.FilterByTB.Visible = false;
            this.FilterByTB.TextChanged += new System.EventHandler(this.FilterByTB_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(8, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 25);
            this.label1.TabIndex = 48;
            this.label1.Text = "Filter By";
            // 
            // ManageDrivers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1251, 692);
            this.Controls.Add(this.FilterByCB);
            this.Controls.Add(this.FilterByTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.RecordsL);
            this.Controls.Add(this.TitleL);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ManageDrivers";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Drivers";
            this.Load += new System.EventHandler(this.ManageDrivers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
                        // Dark Mode Injection
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
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

        private System.Windows.Forms.Label TitleL;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label RecordsL;
        private System.Windows.Forms.ComboBox FilterByCB;
        private System.Windows.Forms.TextBox FilterByTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DriverID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NationalNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FallName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ActiveLicenses;
    }
}
