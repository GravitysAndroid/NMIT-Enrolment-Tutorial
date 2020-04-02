namespace NMIT_Enrolment_Tutorial
{
    partial class FrmMOEStudent
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
            this.LblLoan = new System.Windows.Forms.Label();
            this.TxtLoan = new System.Windows.Forms.TextBox();
            this.LblFullTime = new System.Windows.Forms.Label();
            this.ChkFullTime = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // LblLoan
            // 
            this.LblLoan.AutoSize = true;
            this.LblLoan.Location = new System.Drawing.Point(12, 123);
            this.LblLoan.Name = "LblLoan";
            this.LblLoan.Size = new System.Drawing.Size(31, 13);
            this.LblLoan.TabIndex = 12;
            this.LblLoan.Text = "Loan";
            // 
            // TxtLoan
            // 
            this.TxtLoan.Location = new System.Drawing.Point(84, 120);
            this.TxtLoan.Name = "TxtLoan";
            this.TxtLoan.Size = new System.Drawing.Size(100, 20);
            this.TxtLoan.TabIndex = 13;
            // 
            // LblFullTime
            // 
            this.LblFullTime.AutoSize = true;
            this.LblFullTime.Location = new System.Drawing.Point(12, 148);
            this.LblFullTime.Name = "LblFullTime";
            this.LblFullTime.Size = new System.Drawing.Size(49, 13);
            this.LblFullTime.TabIndex = 14;
            this.LblFullTime.Text = "Full Time";
            // 
            // ChkFullTime
            // 
            this.ChkFullTime.AutoSize = true;
            this.ChkFullTime.Location = new System.Drawing.Point(84, 147);
            this.ChkFullTime.Name = "ChkFullTime";
            this.ChkFullTime.Size = new System.Drawing.Size(68, 17);
            this.ChkFullTime.TabIndex = 15;
            this.ChkFullTime.Text = "Full Time";
            this.ChkFullTime.UseVisualStyleBackColor = true;
            // 
            // FrmMOEStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 214);
            this.Controls.Add(this.ChkFullTime);
            this.Controls.Add(this.LblFullTime);
            this.Controls.Add(this.TxtLoan);
            this.Controls.Add(this.LblLoan);
            this.Name = "FrmMOEStudent";
            this.Text = "MOE Student";
            this.Controls.SetChildIndex(this.LblLoan, 0);
            this.Controls.SetChildIndex(this.TxtLoan, 0);
            this.Controls.SetChildIndex(this.LblFullTime, 0);
            this.Controls.SetChildIndex(this.ChkFullTime, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblLoan;
        private System.Windows.Forms.TextBox TxtLoan;
        private System.Windows.Forms.Label LblFullTime;
        private System.Windows.Forms.CheckBox ChkFullTime;
    }
}