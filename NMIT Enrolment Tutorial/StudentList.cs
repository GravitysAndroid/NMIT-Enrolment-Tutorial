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
    public partial class FrmStudentList : Form
    {
        private ClsStudent _Student;
        public FrmStudentList()
        {
            InitializeComponent();
            CboStudentType.DataSource = ClsStudent._StudentType;
            CboStudentType.SelectedIndex = 0;
        }

        private void btnCreateStudent_Click(object sender, EventArgs e)
        {
            ClsStudent lcStudent = ClsStudent.NewStudent(CboStudentType.SelectedIndex);
            if (lcStudent != null && lcStudent.ViewEdit())
            {
                ClsInstitute.StudentList.Add(lcStudent);
                UpdateDisplay();
            }
            EditStudent(lcStudent);
        }

        private void btnModStudent_Click(object sender, EventArgs e)
        {
            EditStudent(_Student);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void EditStudent(ClsStudent prStudent)
        {
            if (prStudent != null && prStudent.ViewEdit())
            {
                _Student = prStudent;
                //LblStudentDetails.Text = "Student:\n" + _Student.ToString();
            }
        }

        private void UpdateDisplay()
        {
            lstStudents.DataSource = null; 
            lstStudents.DataSource = ClsInstitute.StudentList;
        }
    }
}
