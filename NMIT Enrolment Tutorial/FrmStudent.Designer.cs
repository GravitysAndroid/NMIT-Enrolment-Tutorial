namespace NMIT_Enrolment_Tutorial
{
    partial class FrmStudent
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
            this.LblID = new System.Windows.Forms.Label();
            this.LblName = new System.Windows.Forms.Label();
            this.LblDOB = new System.Windows.Forms.Label();
            this.LblBalance = new System.Windows.Forms.Label();
            this.TxtID = new System.Windows.Forms.TextBox();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.TxtBalance = new System.Windows.Forms.TextBox();
            this.DtpDOB = new System.Windows.Forms.DateTimePicker();
            this.BtnOK = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.LblProgrammes = new System.Windows.Forms.Label();
            this.LstProgrammes = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // LblID
            // 
            this.LblID.AutoSize = true;
            this.LblID.Location = new System.Drawing.Point(12, 16);
            this.LblID.Name = "LblID";
            this.LblID.Size = new System.Drawing.Size(18, 13);
            this.LblID.TabIndex = 0;
            this.LblID.Text = "ID";
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Location = new System.Drawing.Point(12, 43);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(35, 13);
            this.LblName.TabIndex = 1;
            this.LblName.Text = "Name";
            // 
            // LblDOB
            // 
            this.LblDOB.AutoSize = true;
            this.LblDOB.Location = new System.Drawing.Point(12, 73);
            this.LblDOB.Name = "LblDOB";
            this.LblDOB.Size = new System.Drawing.Size(66, 13);
            this.LblDOB.TabIndex = 2;
            this.LblDOB.Text = "Date of Birth";
            // 
            // LblBalance
            // 
            this.LblBalance.AutoSize = true;
            this.LblBalance.Location = new System.Drawing.Point(12, 96);
            this.LblBalance.Name = "LblBalance";
            this.LblBalance.Size = new System.Drawing.Size(55, 13);
            this.LblBalance.TabIndex = 3;
            this.LblBalance.Text = "Balance $";
            // 
            // TxtID
            // 
            this.TxtID.Location = new System.Drawing.Point(84, 13);
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(100, 20);
            this.TxtID.TabIndex = 4;
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(84, 40);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(100, 20);
            this.TxtName.TabIndex = 5;
            // 
            // TxtBalance
            // 
            this.TxtBalance.Location = new System.Drawing.Point(84, 93);
            this.TxtBalance.Name = "TxtBalance";
            this.TxtBalance.Size = new System.Drawing.Size(100, 20);
            this.TxtBalance.TabIndex = 6;
            // 
            // DtpDOB
            // 
            this.DtpDOB.Location = new System.Drawing.Point(84, 67);
            this.DtpDOB.Name = "DtpDOB";
            this.DtpDOB.Size = new System.Drawing.Size(200, 20);
            this.DtpDOB.TabIndex = 7;
            // 
            // BtnOK
            // 
            this.BtnOK.Location = new System.Drawing.Point(12, 185);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(75, 23);
            this.BtnOK.TabIndex = 8;
            this.BtnOK.Text = "OK";
            this.BtnOK.UseVisualStyleBackColor = true;
            this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(394, 185);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnCancel.TabIndex = 9;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // LblProgrammes
            // 
            this.LblProgrammes.AutoSize = true;
            this.LblProgrammes.Location = new System.Drawing.Point(347, 16);
            this.LblProgrammes.Name = "LblProgrammes";
            this.LblProgrammes.Size = new System.Drawing.Size(65, 13);
            this.LblProgrammes.TabIndex = 10;
            this.LblProgrammes.Text = "Programmes";
            // 
            // LstProgrammes
            // 
            this.LstProgrammes.FormattingEnabled = true;
            this.LstProgrammes.Location = new System.Drawing.Point(350, 32);
            this.LstProgrammes.Name = "LstProgrammes";
            this.LstProgrammes.Size = new System.Drawing.Size(120, 95);
            this.LstProgrammes.TabIndex = 11;
            // 
            // FrmStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 215);
            this.Controls.Add(this.LstProgrammes);
            this.Controls.Add(this.LblProgrammes);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnOK);
            this.Controls.Add(this.DtpDOB);
            this.Controls.Add(this.TxtBalance);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.TxtID);
            this.Controls.Add(this.LblBalance);
            this.Controls.Add(this.LblDOB);
            this.Controls.Add(this.LblName);
            this.Controls.Add(this.LblID);
            this.Name = "FrmStudent";
            this.Text = "Student Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblID;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.Label LblDOB;
        private System.Windows.Forms.Label LblBalance;
        private System.Windows.Forms.TextBox TxtID;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.TextBox TxtBalance;
        private System.Windows.Forms.DateTimePicker DtpDOB;
        private System.Windows.Forms.Button BtnOK;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Label LblProgrammes;
        private System.Windows.Forms.ListBox LstProgrammes;
    }
}