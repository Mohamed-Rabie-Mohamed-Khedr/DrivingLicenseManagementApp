namespace DrivingLicenseManagement
{
    partial class User_Info
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.IsActiveL = new System.Windows.Forms.Label();
            this.UserNameL = new System.Windows.Forms.Label();
            this.UserIDL = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ResearchB = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SelectPersonByIDTB = new System.Windows.Forms.TextBox();
            this.personInfo1 = new DrivingLicenseManagement.PersonInfo();
            this.SuspendLayout();
            // 
            // IsActiveL
            // 
            this.IsActiveL.AutoSize = true;
            this.IsActiveL.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsActiveL.ForeColor = System.Drawing.Color.White;
            this.IsActiveL.Location = new System.Drawing.Point(735, 518);
            this.IsActiveL.Name = "IsActiveL";
            this.IsActiveL.Size = new System.Drawing.Size(80, 19);
            this.IsActiveL.TabIndex = 7;
            this.IsActiveL.Text = "Is Active";
            // 
            // UserNameL
            // 
            this.UserNameL.AutoSize = true;
            this.UserNameL.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameL.ForeColor = System.Drawing.Color.White;
            this.UserNameL.Location = new System.Drawing.Point(473, 518);
            this.UserNameL.Name = "UserNameL";
            this.UserNameL.Size = new System.Drawing.Size(98, 19);
            this.UserNameL.TabIndex = 6;
            this.UserNameL.Text = "User Name";
            // 
            // UserIDL
            // 
            this.UserIDL.AutoSize = true;
            this.UserIDL.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserIDL.ForeColor = System.Drawing.Color.White;
            this.UserIDL.Location = new System.Drawing.Point(237, 518);
            this.UserIDL.Name = "UserIDL";
            this.UserIDL.Size = new System.Drawing.Size(70, 19);
            this.UserIDL.TabIndex = 5;
            this.UserIDL.Text = "User ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Coral;
            this.label1.Location = new System.Drawing.Point(473, 463);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "User Info";
            // 
            // ResearchB
            // 
            this.ResearchB.Location = new System.Drawing.Point(647, 408);
            this.ResearchB.Name = "ResearchB";
            this.ResearchB.Size = new System.Drawing.Size(86, 34);
            this.ResearchB.TabIndex = 48;
            this.ResearchB.Text = "Research";
            this.ResearchB.UseVisualStyleBackColor = true;
            this.ResearchB.Click += new System.EventHandler(this.ResearchB_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(236, 409);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 25);
            this.label2.TabIndex = 47;
            this.label2.Text = "Select Person By ID";
            // 
            // SelectPersonByIDTB
            // 
            this.SelectPersonByIDTB.Location = new System.Drawing.Point(477, 414);
            this.SelectPersonByIDTB.Name = "SelectPersonByIDTB";
            this.SelectPersonByIDTB.Size = new System.Drawing.Size(155, 20);
            this.SelectPersonByIDTB.TabIndex = 46;
            this.SelectPersonByIDTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SelectPersonByIDTB_KeyPress);
            // 
            // personInfo1
            // 
            this.personInfo1.BackColor = System.Drawing.Color.Transparent;
            this.personInfo1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.personInfo1.Location = new System.Drawing.Point(21, -1);
            this.personInfo1.Name = "personInfo1";
            this.personInfo1.Size = new System.Drawing.Size(918, 368);
            this.personInfo1.TabIndex = 49;
            // 
            // User_Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.personInfo1);
            this.Controls.Add(this.ResearchB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SelectPersonByIDTB);
            this.Controls.Add(this.IsActiveL);
            this.Controls.Add(this.UserNameL);
            this.Controls.Add(this.UserIDL);
            this.Controls.Add(this.label1);
            this.Name = "User_Info";
            this.Size = new System.Drawing.Size(951, 555);
            this.Load += new System.EventHandler(this.User_Info_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IsActiveL;
        private System.Windows.Forms.Label UserNameL;
        private System.Windows.Forms.Label UserIDL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ResearchB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SelectPersonByIDTB;
        private PersonInfo personInfo1;
    }
}
