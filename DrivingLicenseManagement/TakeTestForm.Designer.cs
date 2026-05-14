namespace DrivingLicenseManagement
{
    partial class TakeTestForm
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
            this.FeesL = new System.Windows.Forms.Label();
            this.DateL = new System.Windows.Forms.Label();
            this.TrialL = new System.Windows.Forms.Label();
            this.NameL = new System.Windows.Forms.Label();
            this.DClasseL = new System.Windows.Forms.Label();
            this.DLAppIDL = new System.Windows.Forms.Label();
            this.TitleL = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TestResultCB = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NotesTB = new System.Windows.Forms.TextBox();
            this.SaveB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FeesL
            // 
            this.FeesL.AutoSize = true;
            this.FeesL.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FeesL.ForeColor = System.Drawing.Color.White;
            this.FeesL.Location = new System.Drawing.Point(251, 349);
            this.FeesL.Name = "FeesL";
            this.FeesL.Size = new System.Drawing.Size(53, 23);
            this.FeesL.TabIndex = 57;
            this.FeesL.Text = "Fees";
            // 
            // DateL
            // 
            this.DateL.AutoSize = true;
            this.DateL.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateL.ForeColor = System.Drawing.Color.White;
            this.DateL.Location = new System.Drawing.Point(252, 305);
            this.DateL.Name = "DateL";
            this.DateL.Size = new System.Drawing.Size(54, 23);
            this.DateL.TabIndex = 56;
            this.DateL.Text = "Date";
            // 
            // TrialL
            // 
            this.TrialL.AutoSize = true;
            this.TrialL.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TrialL.ForeColor = System.Drawing.Color.White;
            this.TrialL.Location = new System.Drawing.Point(252, 261);
            this.TrialL.Name = "TrialL";
            this.TrialL.Size = new System.Drawing.Size(78, 23);
            this.TrialL.TabIndex = 55;
            this.TrialL.Text = "Trial: 0";
            // 
            // NameL
            // 
            this.NameL.AutoSize = true;
            this.NameL.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameL.ForeColor = System.Drawing.Color.White;
            this.NameL.Location = new System.Drawing.Point(252, 217);
            this.NameL.Name = "NameL";
            this.NameL.Size = new System.Drawing.Size(65, 23);
            this.NameL.TabIndex = 54;
            this.NameL.Text = "Name";
            // 
            // DClasseL
            // 
            this.DClasseL.AutoSize = true;
            this.DClasseL.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DClasseL.ForeColor = System.Drawing.Color.White;
            this.DClasseL.Location = new System.Drawing.Point(252, 173);
            this.DClasseL.Name = "DClasseL";
            this.DClasseL.Size = new System.Drawing.Size(97, 23);
            this.DClasseL.TabIndex = 53;
            this.DClasseL.Text = "D. Classe";
            // 
            // DLAppIDL
            // 
            this.DLAppIDL.AutoSize = true;
            this.DLAppIDL.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DLAppIDL.ForeColor = System.Drawing.Color.White;
            this.DLAppIDL.Location = new System.Drawing.Point(252, 129);
            this.DLAppIDL.Name = "DLAppIDL";
            this.DLAppIDL.Size = new System.Drawing.Size(107, 23);
            this.DLAppIDL.TabIndex = 52;
            this.DLAppIDL.Text = "D.LApp ID";
            // 
            // TitleL
            // 
            this.TitleL.AutoSize = true;
            this.TitleL.BackColor = System.Drawing.Color.Transparent;
            this.TitleL.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleL.ForeColor = System.Drawing.Color.Coral;
            this.TitleL.Location = new System.Drawing.Point(250, 46);
            this.TitleL.Name = "TitleL";
            this.TitleL.Size = new System.Drawing.Size(155, 35);
            this.TitleL.TabIndex = 51;
            this.TitleL.Text = "Take Test";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(132, 395);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 23);
            this.label1.TabIndex = 59;
            this.label1.Text = "Test Result";
            // 
            // TestResultCB
            // 
            this.TestResultCB.FormattingEnabled = true;
            this.TestResultCB.Items.AddRange(new object[] {
            "Fail",
            "Pass"});
            this.TestResultCB.Location = new System.Drawing.Point(256, 400);
            this.TestResultCB.Name = "TestResultCB";
            this.TestResultCB.Size = new System.Drawing.Size(121, 21);
            this.TestResultCB.TabIndex = 60;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(184, 439);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 23);
            this.label2.TabIndex = 61;
            this.label2.Text = "Notes";
            // 
            // NotesTB
            // 
            this.NotesTB.Location = new System.Drawing.Point(256, 439);
            this.NotesTB.Multiline = true;
            this.NotesTB.Name = "NotesTB";
            this.NotesTB.Size = new System.Drawing.Size(298, 130);
            this.NotesTB.TabIndex = 62;
            // 
            // SaveB
            // 
            this.SaveB.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveB.Location = new System.Drawing.Point(647, 562);
            this.SaveB.Name = "SaveB";
            this.SaveB.Size = new System.Drawing.Size(86, 41);
            this.SaveB.TabIndex = 63;
            this.SaveB.Text = "SAVE";
            this.SaveB.UseVisualStyleBackColor = true;
            this.SaveB.Click += new System.EventHandler(this.SaveB_Click);
            // 
            // TakeTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 615);
            this.Controls.Add(this.SaveB);
            this.Controls.Add(this.NotesTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TestResultCB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FeesL);
            this.Controls.Add(this.DateL);
            this.Controls.Add(this.TrialL);
            this.Controls.Add(this.NameL);
            this.Controls.Add(this.DClasseL);
            this.Controls.Add(this.DLAppIDL);
            this.Controls.Add(this.TitleL);
            this.Name = "TakeTestForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Take Test";
            this.Load += new System.EventHandler(this.TakeTestForm_Load);
                        // Dark Mode Injection
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.SaveB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveB.FlatAppearance.BorderSize = 0;
            this.SaveB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.SaveB.ForeColor = System.Drawing.Color.White;
            this.SaveB.UseVisualStyleBackColor = false;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label FeesL;
        private System.Windows.Forms.Label DateL;
        private System.Windows.Forms.Label TrialL;
        private System.Windows.Forms.Label NameL;
        private System.Windows.Forms.Label DClasseL;
        private System.Windows.Forms.Label DLAppIDL;
        private System.Windows.Forms.Label TitleL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox TestResultCB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NotesTB;
        private System.Windows.Forms.Button SaveB;
    }
}
