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
    public partial class FrmMain : Form
    {
        private ClsStudent _Student;
        private FrmStudent _StudentForm;
        private FrmStudent _MOEStudentForm = new FrmMOEStudent();
        private FrmStudent _IntStudentForm = new FrmInternationalStudent();
        private string[] _StudentType = { "MOE (local)", "International" };

        public FrmMain()
        {
            InitializeComponent();
            CboStudentType.DataSource = _StudentType;
            CboStudentType.SelectedIndex = 0;
        }
        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnCreateStudent_Click(object sender, EventArgs e)
        {
            if (CboStudentType.SelectedIndex == 0)
            {
                _StudentForm = _MOEStudentForm;
                _Student = new ClsMOEStudent();
            }
            else
            {
                _StudentForm = _IntStudentForm;
                _Student = new ClsInternationalStudent();
            }

            EditStudent();
        }

        private void EditStudent()
        {
            if (_Student != null &&
            _StudentForm.ShowDialog(_Student) == DialogResult.OK)
            {
                LblStudentDetails.Text = "Student:\n" + _Student.ToString();
            }
        }


    }
}

