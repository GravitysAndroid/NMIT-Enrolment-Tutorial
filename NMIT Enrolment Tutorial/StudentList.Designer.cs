namespace NMIT_Enrolment_Tutorial
{
    partial class FrmStudentList
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
            this.lstStudents = new System.Windows.Forms.ListBox();
            this.CboStudentType = new System.Windows.Forms.ComboBox();
            this.btnCreateStudent = new System.Windows.Forms.Button();
            this.btnModStudent = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstStudents
            // 
            this.lstStudents.FormattingEnabled = true;
            this.lstStudents.Location = new System.Drawing.Point(12, 12);
            this.lstStudents.Name = "lstStudents";
            this.lstStudents.Size = new System.Drawing.Size(384, 199);
            this.lstStudents.TabIndex = 0;
            // 
            // CboStudentType
            // 
            this.CboStudentType.FormattingEnabled = true;
            this.CboStudentType.Location = new System.Drawing.Point(275, 219);
            this.CboStudentType.Name = "CboStudentType";
            this.CboStudentType.Size = new System.Drawing.Size(121, 21);
            this.CboStudentType.TabIndex = 1;
            // 
            // btnCreateStudent
            // 
            this.btnCreateStudent.Location = new System.Drawing.Point(12, 217);
            this.btnCreateStudent.Name = "btnCreateStudent";
            this.btnCreateStudent.Size = new System.Drawing.Size(95, 23);
            this.btnCreateStudent.TabIndex = 2;
            this.btnCreateStudent.Text = "Create Student";
            this.btnCreateStudent.UseVisualStyleBackColor = true;
            this.btnCreateStudent.Click += new System.EventHandler(this.btnCreateStudent_Click);
            // 
            // btnModStudent
            // 
            this.btnModStudent.Location = new System.Drawing.Point(12, 246);
            this.btnModStudent.Name = "btnModStudent";
            this.btnModStudent.Size = new System.Drawing.Size(95, 23);
            this.btnModStudent.TabIndex = 3;
            this.btnModStudent.Text = "Modify Student";
            this.btnModStudent.UseVisualStyleBackColor = true;
            this.btnModStudent.Click += new System.EventHandler(this.btnModStudent_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(321, 246);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FrmStudentList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 273);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnModStudent);
            this.Controls.Add(this.btnCreateStudent);
            this.Controls.Add(this.CboStudentType);
            this.Controls.Add(this.lstStudents);
            this.Name = "FrmStudentList";
            this.Text = "Student List";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstStudents;
        private System.Windows.Forms.ComboBox CboStudentType;
        private System.Windows.Forms.Button btnCreateStudent;
        private System.Windows.Forms.Button btnModStudent;
        private System.Windows.Forms.Button btnClose;
    }
}