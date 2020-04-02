namespace NMIT_Enrolment_Tutorial
{
    partial class FrmInternationalStudent
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
            this.LblCountry = new System.Windows.Forms.Label();
            this.TxtCountry = new System.Windows.Forms.TextBox();
            this.LblELTS = new System.Windows.Forms.Label();
            this.TxtELTS = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LblCountry
            // 
            this.LblCountry.AutoSize = true;
            this.LblCountry.Location = new System.Drawing.Point(12, 123);
            this.LblCountry.Name = "LblCountry";
            this.LblCountry.Size = new System.Drawing.Size(43, 13);
            this.LblCountry.TabIndex = 12;
            this.LblCountry.Text = "Country";
            // 
            // TxtCountry
            // 
            this.TxtCountry.Location = new System.Drawing.Point(84, 120);
            this.TxtCountry.Name = "TxtCountry";
            this.TxtCountry.Size = new System.Drawing.Size(100, 20);
            this.TxtCountry.TabIndex = 13;
            // 
            // LblELTS
            // 
            this.LblELTS.AutoSize = true;
            this.LblELTS.Location = new System.Drawing.Point(12, 150);
            this.LblELTS.Name = "LblELTS";
            this.LblELTS.Size = new System.Drawing.Size(34, 13);
            this.LblELTS.TabIndex = 14;
            this.LblELTS.Text = "ELTS";
            // 
            // TxtELTS
            // 
            this.TxtELTS.Location = new System.Drawing.Point(84, 147);
            this.TxtELTS.Name = "TxtELTS";
            this.TxtELTS.Size = new System.Drawing.Size(100, 20);
            this.TxtELTS.TabIndex = 15;
            // 
            // FrmInternationalStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 215);
            this.Controls.Add(this.TxtELTS);
            this.Controls.Add(this.LblELTS);
            this.Controls.Add(this.TxtCountry);
            this.Controls.Add(this.LblCountry);
            this.Name = "FrmInternationalStudent";
            this.Text = "International Student";
            this.Controls.SetChildIndex(this.LblCountry, 0);
            this.Controls.SetChildIndex(this.TxtCountry, 0);
            this.Controls.SetChildIndex(this.LblELTS, 0);
            this.Controls.SetChildIndex(this.TxtELTS, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblCountry;
        private System.Windows.Forms.TextBox TxtCountry;
        private System.Windows.Forms.Label LblELTS;
        private System.Windows.Forms.TextBox TxtELTS;
    }
}