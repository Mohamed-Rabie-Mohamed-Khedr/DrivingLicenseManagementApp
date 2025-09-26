namespace DrivingLicenseManagement
{
    partial class ManageUsers
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
            this.FilterByTB = new System.Windows.Forms.TextBox();
            this.AddB = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.PersonID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isActive = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ShowAndEditInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteUser = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangePassword = new System.Windows.Forms.ToolStripMenuItem();
            this.RecordsT = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.FilterByIsActiveCB = new System.Windows.Forms.ComboBox();
            this.FilterBy = new System.Windows.Forms.ComboBox();
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
            this.label3.Location = new System.Drawing.Point(466, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(219, 35);
            this.label3.TabIndex = 37;
            this.label3.Text = "Manage Users";
            // 
            // FilterByTB
            // 
            this.FilterByTB.Location = new System.Drawing.Point(253, 153);
            this.FilterByTB.Name = "FilterByTB";
            this.FilterByTB.Size = new System.Drawing.Size(155, 20);
            this.FilterByTB.TabIndex = 36;
            this.FilterByTB.Visible = false;
            this.FilterByTB.TextChanged += new System.EventHandler(this.FilterByTB_TextChanged);
            // 
            // AddB
            // 
            this.AddB.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddB.Location = new System.Drawing.Point(1032, 157);
            this.AddB.Name = "AddB";
            this.AddB.Size = new System.Drawing.Size(75, 34);
            this.AddB.TabIndex = 34;
            this.AddB.Text = "ADD";
            this.AddB.UseVisualStyleBackColor = true;
            this.AddB.Click += new System.EventHandler(this.AddB_Click);
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
            this.UserID,
            this.FullName,
            this.UserName,
            this.isActive});
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Location = new System.Drawing.Point(17, 197);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1090, 392);
            this.dataGridView1.TabIndex = 33;
            // 
            // PersonID
            // 
            this.PersonID.HeaderText = "Person ID";
            this.PersonID.Name = "PersonID";
            this.PersonID.ReadOnly = true;
            // 
            // UserID
            // 
            this.UserID.HeaderText = "User ID";
            this.UserID.Name = "UserID";
            this.UserID.ReadOnly = true;
            // 
            // FullName
            // 
            this.FullName.HeaderText = "Full Name";
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
            // 
            // UserName
            // 
            this.UserName.HeaderText = "User Name";
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            // 
            // isActive
            // 
            this.isActive.HeaderText = "Is Active";
            this.isActive.Name = "isActive";
            this.isActive.ReadOnly = true;
            this.isActive.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.isActive.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShowAndEditInfo,
            this.DeleteUser,
            this.ChangePassword});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(185, 92);
            // 
            // ShowAndEditInfo
            // 
            this.ShowAndEditInfo.Name = "ShowAndEditInfo";
            this.ShowAndEditInfo.Size = new System.Drawing.Size(184, 22);
            this.ShowAndEditInfo.Text = "Show / Edit User Info";
            this.ShowAndEditInfo.Click += new System.EventHandler(this.ShowAndEditInfo_Click);
            // 
            // DeleteUser
            // 
            this.DeleteUser.Name = "DeleteUser";
            this.DeleteUser.Size = new System.Drawing.Size(184, 22);
            this.DeleteUser.Text = "Delete";
            this.DeleteUser.Click += new System.EventHandler(this.DeleteUser_Click);
            // 
            // ChangePassword
            // 
            this.ChangePassword.Name = "ChangePassword";
            this.ChangePassword.Size = new System.Drawing.Size(184, 22);
            this.ChangePassword.Text = "Change Password";
            this.ChangePassword.Click += new System.EventHandler(this.ChangePassword_Click);
            // 
            // RecordsT
            // 
            this.RecordsT.AutoSize = true;
            this.RecordsT.BackColor = System.Drawing.Color.Transparent;
            this.RecordsT.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecordsT.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RecordsT.Location = new System.Drawing.Point(12, 592);
            this.RecordsT.Name = "RecordsT";
            this.RecordsT.Size = new System.Drawing.Size(96, 25);
            this.RecordsT.TabIndex = 32;
            this.RecordsT.Text = "Records";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 25);
            this.label1.TabIndex = 31;
            this.label1.Text = "Filter By";
            // 
            // FilterByIsActiveCB
            // 
            this.FilterByIsActiveCB.FormattingEnabled = true;
            this.FilterByIsActiveCB.Items.AddRange(new object[] {
            "Yas",
            "No"});
            this.FilterByIsActiveCB.Location = new System.Drawing.Point(253, 154);
            this.FilterByIsActiveCB.Name = "FilterByIsActiveCB";
            this.FilterByIsActiveCB.Size = new System.Drawing.Size(121, 21);
            this.FilterByIsActiveCB.TabIndex = 39;
            this.FilterByIsActiveCB.SelectedIndexChanged += new System.EventHandler(this.FilterByIsActiveCB_SelectedIndexChanged);
            // 
            // FilterBy
            // 
            this.FilterBy.FormattingEnabled = true;
            this.FilterBy.Items.AddRange(new object[] {
            "None",
            "Person ID",
            "User ID",
            "User Name",
            "Is Active"});
            this.FilterBy.Location = new System.Drawing.Point(115, 153);
            this.FilterBy.Name = "FilterBy";
            this.FilterBy.Size = new System.Drawing.Size(121, 21);
            this.FilterBy.TabIndex = 40;
            this.FilterBy.SelectedIndexChanged += new System.EventHandler(this.FilterBy_SelectedIndexChanged);
            // 
            // ManageUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1119, 648);
            this.Controls.Add(this.FilterBy);
            this.Controls.Add(this.FilterByIsActiveCB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FilterByTB);
            this.Controls.Add(this.AddB);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.RecordsT);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ManageUsers";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageUsers";
            this.Load += new System.EventHandler(this.ManageUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox FilterByTB;
        private System.Windows.Forms.Button AddB;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label RecordsT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonID;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isActive;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ShowAndEditInfo;
        private System.Windows.Forms.ToolStripMenuItem DeleteUser;
        private System.Windows.Forms.ToolStripMenuItem ChangePassword;
        private System.Windows.Forms.ComboBox FilterByIsActiveCB;
        private System.Windows.Forms.ComboBox FilterBy;
    }
}