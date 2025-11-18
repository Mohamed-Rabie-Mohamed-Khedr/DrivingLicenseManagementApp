namespace DrivingLicenseManagement
{
    partial class IssueDriverLicense
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
            this.IssueB = new System.Windows.Forms.Button();
            this.NotesTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // IssueB
            // 
            this.IssueB.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IssueB.Location = new System.Drawing.Point(901, 740);
            this.IssueB.Name = "IssueB";
            this.IssueB.Size = new System.Drawing.Size(86, 41);
            this.IssueB.TabIndex = 66;
            this.IssueB.Text = "Issue";
            this.IssueB.UseVisualStyleBackColor = true;
            this.IssueB.Click += new System.EventHandler(this.IssueB_Click);
            // 
            // NotesTB
            // 
            this.NotesTB.Location = new System.Drawing.Point(298, 648);
            this.NotesTB.Multiline = true;
            this.NotesTB.Name = "NotesTB";
            this.NotesTB.Size = new System.Drawing.Size(452, 130);
            this.NotesTB.TabIndex = 65;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(226, 648);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 23);
            this.label2.TabIndex = 64;
            this.label2.Text = "Notes";
            // 
            // IssueDriverLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 791);
            this.Controls.Add(this.IssueB);
            this.Controls.Add(this.NotesTB);
            this.Controls.Add(this.label2);
            this.Name = "IssueDriverLicense";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Issue Driver License";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button IssueB;
        private System.Windows.Forms.TextBox NotesTB;
        private System.Windows.Forms.Label label2;
    }
}