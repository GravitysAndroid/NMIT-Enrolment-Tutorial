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
    public partial class FrmMOEStudent : FrmStudent
    {
        public FrmMOEStudent()
        {
            InitializeComponent();
        }

        protected override void UpdateDisplay()
        {
            base.UpdateDisplay();
            ClsMOEStudent lcStudent = (ClsMOEStudent)_Student;
            TxtLoan.Text = Convert.ToString(lcStudent.LoanAmount);
            ChkFullTime.Checked = lcStudent.FullTime;
        }

        protected override void PushData()
        {
            base.PushData();
            ClsMOEStudent lcStudent = (ClsMOEStudent)_Student;
            lcStudent.LoanAmount = Convert.ToDecimal(TxtLoan.Text);
            lcStudent.FullTime = ChkFullTime.Checked;
        }
    }
}
