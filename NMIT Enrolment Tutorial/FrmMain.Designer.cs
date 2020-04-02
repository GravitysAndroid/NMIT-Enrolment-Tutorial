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
            this.BtnCreateStudent = new System.Windows.Forms.Button();
            this.BtnModifyStudent = new System.Windows.Forms.Button();
            this.LblStudentDetails = new System.Windows.Forms.Label();
            this.BtnClose = new System.Windows.Forms.Button();
            this.CboStudentType = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // BtnCreateStudent
            // 
            this.BtnCreateStudent.Location = new System.Drawing.Point(13, 13);
            this.BtnCreateStudent.Name = "BtnCreateStudent";
            this.BtnCreateStudent.Size = new System.Drawing.Size(75, 23);
            this.BtnCreateStudent.TabIndex = 0;
            this.BtnCreateStudent.Text = "Create";
            this.BtnCreateStudent.UseVisualStyleBackColor = true;
            this.BtnCreateStudent.Click += new System.EventHandler(this.BtnCreateStudent_Click);
            // 
            // BtnModifyStudent
            // 
            this.BtnModifyStudent.Location = new System.Drawing.Point(13, 43);
            this.BtnModifyStudent.Name = "BtnModifyStudent";
            this.BtnModifyStudent.Size = new System.Drawing.Size(75, 23);
            this.BtnModifyStudent.TabIndex = 1;
            this.BtnModifyStudent.Text = "Modify";
            this.BtnModifyStudent.UseVisualStyleBackColor = true;
            // 
            // LblStudentDetails
            // 
            this.LblStudentDetails.AutoSize = true;
            this.LblStudentDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblStudentDetails.Location = new System.Drawing.Point(13, 73);
            this.LblStudentDetails.Name = "LblStudentDetails";
            this.LblStudentDetails.Size = new System.Drawing.Size(84, 15);
            this.LblStudentDetails.TabIndex = 2;
            this.LblStudentDetails.Text = "Student Details:";
            // 
            // BtnClose
            // 
            this.BtnClose.Location = new System.Drawing.Point(311, 211);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(75, 23);
            this.BtnClose.TabIndex = 3;
            this.BtnClose.Text = "Close";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // CboStudentType
            // 
            this.CboStudentType.FormattingEnabled = true;
            this.CboStudentType.Location = new System.Drawing.Point(265, 13);
            this.CboStudentType.Name = "CboStudentType";
            this.CboStudentType.Size = new System.Drawing.Size(121, 21);
            this.CboStudentType.TabIndex = 4;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 246);
            this.Controls.Add(this.CboStudentType);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.LblStudentDetails);
            this.Controls.Add(this.BtnModifyStudent);
            this.Controls.Add(this.BtnCreateStudent);
            this.Name = "FrmMain";
            this.Text = "NMIT Enrolment System";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCreateStudent;
        private System.Windows.Forms.Button BtnModifyStudent;
        private System.Windows.Forms.Label LblStudentDetails;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.ComboBox CboStudentType;
    }
}

