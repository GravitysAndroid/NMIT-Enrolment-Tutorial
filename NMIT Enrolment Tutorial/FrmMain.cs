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
        //private FrmStudent _StudentForm;
        //private FrmStudent _MOEStudentForm = new FrmMOEStudent();
        //private FrmStudent _IntStudentForm = new FrmInternationalStudent();
        //private string[] _StudentType = { "MOE (local)", "International" };

        public FrmMain()
        {
            InitializeComponent();
            CboStudentType.DataSource = ClsStudent._StudentType;
            CboStudentType.SelectedIndex = 0;
        }
        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnCreateStudent_Click(object sender, EventArgs e)
        {
            ClsStudent lcStudent = ClsStudent.NewStudent(CboStudentType.SelectedIndex);
            EditStudent(lcStudent);
        }

        private void EditStudent(ClsStudent prStudent)
        {
            if (prStudent != null && prStudent.ViewEdit())
            {
                _Student = prStudent;
                LblStudentDetails.Text = "Student:\n" + _Student.ToString();
            }
        }
                    
        private void BtnModifyStudent_Click(object sender, EventArgs e)
        {
            EditStudent(_Student);
        }

        //private void CreateStudent()
        //{
        //    if (CboStudentType.SelectedIndex == 0)
        //    {
        //        _StudentForm = _MOEStudentForm;
        //        _Student = new ClsMOEStudent();
        //    }
        //    else
        //    {
        //        _StudentForm = _IntStudentForm;
        //        _Student = new ClsInternationalStudent();
        //    }
        //}
    }
}

