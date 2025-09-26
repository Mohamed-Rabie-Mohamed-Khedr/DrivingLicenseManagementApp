namespace DrivingLicenseManagement
{
    partial class AddAndUpdateUserForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Next = new System.Windows.Forms.Button();
            this.ResearchB = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SelectPersonByIDTB = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.personInfo1 = new DrivingLicenseManagement.PersonInfo();
            this.changePassword1 = new DrivingLicenseManagement.AddAndUpdateUser();
            this.user_Info1 = new DrivingLicenseManagement.User_Info();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1438, 841);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControl1_Selecting);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.tabPage1.Controls.Add(this.user_Info1);
            this.tabPage1.Controls.Add(this.personInfo1);
            this.tabPage1.Controls.Add(this.Next);
            this.tabPage1.Controls.Add(this.ResearchB);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.SelectPersonByIDTB);
            this.tabPage1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1430, 812);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Person Info";
            // 
            // Next
            // 
            this.Next.Location = new System.Drawing.Point(1327, 767);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(86, 34);
            this.Next.TabIndex = 46;
            this.Next.Text = "Next";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // ResearchB
            // 
            this.ResearchB.Location = new System.Drawing.Point(452, 766);
            this.ResearchB.Name = "ResearchB";
            this.ResearchB.Size = new System.Drawing.Size(86, 34);
            this.ResearchB.TabIndex = 45;
            this.ResearchB.Text = "Research";
            this.ResearchB.UseVisualStyleBackColor = true;
            this.ResearchB.Click += new System.EventHandler(this.ResearchB_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(8, 767);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 25);
            this.label1.TabIndex = 44;
            this.label1.Text = "Select Person By ID";
            // 
            // SelectPersonByIDTB
            // 
            this.SelectPersonByIDTB.Location = new System.Drawing.Point(249, 772);
            this.SelectPersonByIDTB.Name = "SelectPersonByIDTB";
            this.SelectPersonByIDTB.Size = new System.Drawing.Size(155, 23);
            this.SelectPersonByIDTB.TabIndex = 41;
            this.SelectPersonByIDTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SelectPersonByIDTB_KeyPress);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.DimGray;
            this.tabPage2.Controls.Add(this.changePassword1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1430, 735);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Logn Info";
            // 
            // personInfo1
            // 
            this.personInfo1.AutoSize = true;
            this.personInfo1.BackColor = System.Drawing.Color.Transparent;
            this.personInfo1.Dock = System.Windows.Forms.DockStyle.Top;
            this.personInfo1.Location = new System.Drawing.Point(3, 3);
            this.personInfo1.Margin = new System.Windows.Forms.Padding(4);
            this.personInfo1.Name = "personInfo1";
            this.personInfo1.Size = new System.Drawing.Size(1424, 404);
            this.personInfo1.TabIndex = 48;
            // 
            // changePassword1
            // 
            this.changePassword1.BackColor = System.Drawing.Color.Transparent;
            this.changePassword1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.changePassword1.Location = new System.Drawing.Point(392, 123);
            this.changePassword1.Margin = new System.Windows.Forms.Padding(4);
            this.changePassword1.Name = "changePassword1";
            this.changePassword1.Size = new System.Drawing.Size(709, 522);
            this.changePassword1.TabIndex = 0;
            // 
            // user_Info1
            // 
            this.user_Info1.BackColor = System.Drawing.Color.Transparent;
            this.user_Info1.Location = new System.Drawing.Point(624, 415);
            this.user_Info1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.user_Info1.Name = "user_Info1";
            this.user_Info1.Size = new System.Drawing.Size(579, 293);
            this.user_Info1.TabIndex = 49;
            // 
            // AddAndUpdateUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1438, 840);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddAndUpdateUserForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add / Update User";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox SelectPersonByIDTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ResearchB;
        private System.Windows.Forms.Button Next;
        private PersonInfo personInfo1;
        private AddAndUpdateUser changePassword1;
        private User_Info user_Info1;
    }
}