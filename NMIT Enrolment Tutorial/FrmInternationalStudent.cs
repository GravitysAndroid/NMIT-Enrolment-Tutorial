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
    public partial class FrmInternationalStudent : FrmStudent
    {
        private static FrmInternationalStudent _Form;
        public FrmInternationalStudent()
        {
            InitializeComponent();
        }

        public override bool ViewEdit()
        {
            return _Form.ShowDialog(this);
        }
        protected override void UpdateDisplay()
        {
            base.UpdateDisplay();
            ClsInternationalStudent lcStudent = (ClsInternationalStudent)_Student;
            TxtCountry.Text = lcStudent.Country;
            TxtELTS.Text = lcStudent.ELTS;
        }

        protected override void PushData()
        {
            base.PushData();
            ClsInternationalStudent lcStudent = (ClsInternationalStudent)_Student;
            lcStudent.Country = TxtCountry.Text;
            lcStudent.ELTS = TxtELTS.Text;
        }
    }
}
