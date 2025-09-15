namespace DrivingLicenseManagement
{
    partial class ManagePeople
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
            this.label1 = new System.Windows.Forms.Label();
            this.RecordsT = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.PersonID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NationalNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SecondName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThirdName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gendor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nationalit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOfBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ShowInfoAndEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.DeletePerson = new System.Windows.Forms.ToolStripMenuItem();
            this.AddPersonB = new System.Windows.Forms.Button();
            this.FilterByTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.FilterByCB = new System.Windows.Forms.ComboBox();
            this.FilterB = new System.Windows.Forms.Button();
            this.GendorFilterCB = new System.Windows.Forms.ComboBox();
            this.CountryFilterCB = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filter By";
            // 
            // RecordsT
            // 
            this.RecordsT.AutoSize = true;
            this.RecordsT.BackColor = System.Drawing.Color.Transparent;
            this.RecordsT.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecordsT.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RecordsT.Location = new System.Drawing.Point(12, 598);
            this.RecordsT.Name = "RecordsT";
            this.RecordsT.Size = new System.Drawing.Size(96, 25);
            this.RecordsT.TabIndex = 1;
            this.RecordsT.Text = "Records";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PersonID,
            this.NationalNo,
            this.FirstName,
            this.SecondName,
            this.ThirdName,
            this.LastName,
            this.Gendor,
            this.Nationalit,
            this.DateOfBirth,
            this.Phone,
            this.Email});
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Location = new System.Drawing.Point(17, 203);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1090, 392);
            this.dataGridView1.TabIndex = 2;
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
            // FirstName
            // 
            this.FirstName.HeaderText = "First Name";
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            // 
            // SecondName
            // 
            this.SecondName.HeaderText = "Second Name";
            this.SecondName.Name = "SecondName";
            this.SecondName.ReadOnly = true;
            // 
            // ThirdName
            // 
            this.ThirdName.HeaderText = "Third Name";
            this.ThirdName.Name = "ThirdName";
            this.ThirdName.ReadOnly = true;
            // 
            // LastName
            // 
            this.LastName.HeaderText = "Last Name";
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            // 
            // Gendor
            // 
            this.Gendor.HeaderText = "Gendor";
            this.Gendor.Name = "Gendor";
            this.Gendor.ReadOnly = true;
            // 
            // Nationalit
            // 
            this.Nationalit.HeaderText = "Nationalit";
            this.Nationalit.Name = "Nationalit";
            this.Nationalit.ReadOnly = true;
            // 
            // DateOfBirth
            // 
            this.DateOfBirth.HeaderText = "Date Of Birth";
            this.DateOfBirth.Name = "DateOfBirth";
            this.DateOfBirth.ReadOnly = true;
            // 
            // Phone
            // 
            this.Phone.HeaderText = "Phone";
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShowInfoAndEdit,
            this.DeletePerson});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(159, 48);
            // 
            // ShowInfoAndEdit
            // 
            this.ShowInfoAndEdit.Name = "ShowInfoAndEdit";
            this.ShowInfoAndEdit.Size = new System.Drawing.Size(158, 22);
            this.ShowInfoAndEdit.Text = "Show / Edit Info";
            this.ShowInfoAndEdit.Click += new System.EventHandler(this.ShowInfoAndEdit_Click);
            // 
            // DeletePerson
            // 
            this.DeletePerson.Name = "DeletePerson";
            this.DeletePerson.Size = new System.Drawing.Size(158, 22);
            this.DeletePerson.Text = "Delete";
            this.DeletePerson.Click += new System.EventHandler(this.DeletePerson_Click);
            // 
            // AddPersonB
            // 
            this.AddPersonB.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPersonB.Location = new System.Drawing.Point(1032, 163);
            this.AddPersonB.Name = "AddPersonB";
            this.AddPersonB.Size = new System.Drawing.Size(75, 34);
            this.AddPersonB.TabIndex = 3;
            this.AddPersonB.Text = "ADD";
            this.AddPersonB.UseVisualStyleBackColor = true;
            this.AddPersonB.Click += new System.EventHandler(this.AddPerson_Click);
            // 
            // FilterByTB
            // 
            this.FilterByTB.Location = new System.Drawing.Point(253, 159);
            this.FilterByTB.Name = "FilterByTB";
            this.FilterByTB.Size = new System.Drawing.Size(155, 20);
            this.FilterByTB.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Coral;
            this.label3.Location = new System.Drawing.Point(466, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(236, 35);
            this.label3.TabIndex = 30;
            this.label3.Text = "Manage People";
            // 
            // FilterByCB
            // 
            this.FilterByCB.FormattingEnabled = true;
            this.FilterByCB.Items.AddRange(new object[] {
            "None",
            "Person ID",
            "National No",
            "First Name",
            "Second Name",
            "Third Name",
            "Last Name",
            "Nationality",
            "Gendor",
            "Phone",
            "Email"});
            this.FilterByCB.Location = new System.Drawing.Point(116, 159);
            this.FilterByCB.Name = "FilterByCB";
            this.FilterByCB.Size = new System.Drawing.Size(121, 21);
            this.FilterByCB.TabIndex = 31;
            this.FilterByCB.SelectedIndexChanged += new System.EventHandler(this.FilterByCB_SelectedIndexChanged);
            // 
            // FilterB
            // 
            this.FilterB.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FilterB.Location = new System.Drawing.Point(423, 154);
            this.FilterB.Name = "FilterB";
            this.FilterB.Size = new System.Drawing.Size(86, 34);
            this.FilterB.TabIndex = 32;
            this.FilterB.Text = "Filter";
            this.FilterB.UseVisualStyleBackColor = true;
            this.FilterB.Click += new System.EventHandler(this.FilterB_Click);
            // 
            // GendorFilterCB
            // 
            this.GendorFilterCB.FormattingEnabled = true;
            this.GendorFilterCB.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.GendorFilterCB.Location = new System.Drawing.Point(253, 159);
            this.GendorFilterCB.Name = "GendorFilterCB";
            this.GendorFilterCB.Size = new System.Drawing.Size(121, 21);
            this.GendorFilterCB.TabIndex = 33;
            this.GendorFilterCB.SelectedIndexChanged += new System.EventHandler(this.GendorFilterCB_SelectedIndexChanged);
            this.GendorFilterCB.Validated += new System.EventHandler(this.GendorFilterCB_Validated);
            // 
            // CountryFilterCB
            // 
            this.CountryFilterCB.FormattingEnabled = true;
            this.CountryFilterCB.Items.AddRange(new object[] {
            "None"});
            this.CountryFilterCB.Location = new System.Drawing.Point(253, 159);
            this.CountryFilterCB.Name = "CountryFilterCB";
            this.CountryFilterCB.Size = new System.Drawing.Size(121, 21);
            this.CountryFilterCB.TabIndex = 34;
            this.CountryFilterCB.SelectedIndexChanged += new System.EventHandler(this.CountryFilterCB_SelectedIndexChanged);
            // 
            // ManagePeople
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1119, 648);
            this.Controls.Add(this.CountryFilterCB);
            this.Controls.Add(this.GendorFilterCB);
            this.Controls.Add(this.FilterB);
            this.Controls.Add(this.FilterByCB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FilterByTB);
            this.Controls.Add(this.AddPersonB);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.RecordsT);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ManagePeople";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage People";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label RecordsT;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button AddPersonB;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ShowInfoAndEdit;
        private System.Windows.Forms.ToolStripMenuItem DeletePerson;
        private System.Windows.Forms.TextBox FilterByTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox FilterByCB;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NationalNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SecondName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThirdName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gendor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nationalit;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfBirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.Button FilterB;
        private System.Windows.Forms.ComboBox GendorFilterCB;
        private System.Windows.Forms.ComboBox CountryFilterCB;
    }
}