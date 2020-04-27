namespace NMIT_Enrolment_Tutorial
{
    partial class FrmMain
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
            this.LblStudentDetails = new System.Windows.Forms.Label();
            this.BtnClose = new System.Windows.Forms.Button();
            this.BtnManageStudents = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblStudentDetails
            // 
            this.LblStudentDetails.AutoSize = true;
            this.LblStudentDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblStudentDetails.Location = new System.Drawing.Point(12, 39);
            this.LblStudentDetails.Name = "LblStudentDetails";
            this.LblStudentDetails.Size = new System.Drawing.Size(84, 15);
            this.LblStudentDetails.TabIndex = 2;
            this.LblStudentDetails.Text = "Student Details:";
            // 
            // BtnClose
            // 
            this.BtnClose.Location = new System.Drawing.Point(190, 131);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(75, 23);
            this.BtnClose.TabIndex = 3;
            this.BtnClose.Text = "Close";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BtnManageStudents
            // 
            this.BtnManageStudents.Location = new System.Drawing.Point(13, 13);
            this.BtnManageStudents.Name = "BtnManageStudents";
            this.BtnManageStudents.Size = new System.Drawing.Size(100, 23);
            this.BtnManageStudents.TabIndex = 4;
            this.BtnManageStudents.Text = "Manage Students";
            this.BtnManageStudents.UseVisualStyleBackColor = true;
            this.BtnManageStudents.Click += new System.EventHandler(this.BtnManageStudents_Click_1);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 156);
            this.Controls.Add(this.BtnManageStudents);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.LblStudentDetails);
            this.Name = "FrmMain";
            this.Text = "NMIT Enrolment System";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LblStudentDetails;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Button BtnManageStudents;
    }
}

