using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NMIT_Enrolment_Tutorial
{
    public partial class FrmStudent : Form
    {
        protected ClsStudent _Student;

        public FrmStudent()
        {
            InitializeComponent();
        }

        public bool ShowDialog(ClsStudent prStudent)
        {
            _Student = prStudent;
            UpdateDisplay();
            return ShowDialog() == DialogResult.OK;
        }

        protected virtual void UpdateDisplay()
        {
            TxtID.Text = _Student.ID;
            TxtName.Text = _Student.Name;
            DtpDOB.Value = _Student.DOB;
            TxtBalance.Text = Convert.ToString(_Student.Balance);
            TxtID.Enabled = string.IsNullOrEmpty(_Student.ID);
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            if (TxtID.Enabled && ClsInstitute.StudentList.ContainsKey(TxtID.Text))
                MessageBox.Show("Student with that ID already exists", "Duplicate ID");
            else
            {
                PushData();
                DialogResult = DialogResult.OK;
            }
        }

        protected virtual void PushData()
        {
            _Student.ID = TxtID.Text;
            _Student.Name = TxtName.Text;
            _Student.DOB = DtpDOB.Value;
            _Student.Balance = Convert.ToDecimal(TxtBalance.Text);
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
