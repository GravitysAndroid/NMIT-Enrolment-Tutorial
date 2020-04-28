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
            this.BtnCreateStudent = new System.Windows.Forms.Button();
            this.BtnModStudent = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.LblID = new System.Windows.Forms.Label();
            this.LblName = new System.Windows.Forms.Label();
            this.LblType = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstStudents
            // 
            this.lstStudents.FormattingEnabled = true;
            this.lstStudents.Location = new System.Drawing.Point(12, 25);
            this.lstStudents.Name = "lstStudents";
            this.lstStudents.Size = new System.Drawing.Size(384, 186);
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
            // BtnCreateStudent
            // 
            this.BtnCreateStudent.Location = new System.Drawing.Point(12, 217);
            this.BtnCreateStudent.Name = "BtnCreateStudent";
            this.BtnCreateStudent.Size = new System.Drawing.Size(95, 23);
            this.BtnCreateStudent.TabIndex = 2;
            this.BtnCreateStudent.Text = "Create Student";
            this.BtnCreateStudent.UseVisualStyleBackColor = true;
            this.BtnCreateStudent.Click += new System.EventHandler(this.BtnCreateStudent_Click_1);
            // 
            // BtnModStudent
            // 
            this.BtnModStudent.Location = new System.Drawing.Point(12, 246);
            this.BtnModStudent.Name = "BtnModStudent";
            this.BtnModStudent.Size = new System.Drawing.Size(95, 23);
            this.BtnModStudent.TabIndex = 3;
            this.BtnModStudent.Text = "Modify Student";
            this.BtnModStudent.UseVisualStyleBackColor = true;
            this.BtnModStudent.Click += new System.EventHandler(this.BtnModStudent_Click_1);
            // 
            // BtnClose
            // 
            this.BtnClose.Location = new System.Drawing.Point(321, 246);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(75, 23);
            this.BtnClose.TabIndex = 4;
            this.BtnClose.Text = "Close";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click_1);
            // 
            // LblID
            // 
            this.LblID.AutoSize = true;
            this.LblID.Location = new System.Drawing.Point(12, 6);
            this.LblID.Name = "LblID";
            this.LblID.Size = new System.Drawing.Size(18, 13);
            this.LblID.TabIndex = 5;
            this.LblID.Text = "ID";
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Location = new System.Drawing.Point(82, 6);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(35, 13);
            this.LblName.TabIndex = 6;
            this.LblName.Text = "Name";
            // 
            // LblType
            // 
            this.LblType.AutoSize = true;
            this.LblType.Location = new System.Drawing.Point(165, 6);
            this.LblType.Name = "LblType";
            this.LblType.Size = new System.Drawing.Size(83, 13);
            this.LblType.TabIndex = 7;
            this.LblType.Text = "Type of Student";
            // 
            // FrmStudentList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 273);
            this.Controls.Add(this.LblType);
            this.Controls.Add(this.LblName);
            this.Controls.Add(this.LblID);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.BtnModStudent);
            this.Controls.Add(this.BtnCreateStudent);
            this.Controls.Add(this.CboStudentType);
            this.Controls.Add(this.lstStudents);
            this.Name = "FrmStudentList";
            this.Text = "Student List";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstStudents;
        private System.Windows.Forms.ComboBox CboStudentType;
        private System.Windows.Forms.Button BtnCreateStudent;
        private System.Windows.Forms.Button BtnModStudent;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Label LblID;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.Label LblType;
    }
}