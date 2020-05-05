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

        private void EditStudent(ClsStudent prStudent)
        {
            if (prStudent != null && prStudent.ViewEdit())
            {
                _Student = prStudent;
            }
        }

        private void UpdateDisplay()
        {
            lstStudents.DataSource = null;
            lstStudents.DataSource = ClsInstitute.StudentList.Values.ToList();
        }

        private void BtnClose_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnCreateStudent_Click_1(object sender, EventArgs e)
        {
            ClsStudent lcStudent = ClsStudent.NewStudent(CboStudentType.SelectedIndex);
            if (lcStudent != null && lcStudent.ViewEdit())
            {
                ClsInstitute.StudentList.Add(lcStudent.ID, lcStudent);
                UpdateDisplay();
            }
            //EditStudent(lcStudent);
        }

        private void BtnModStudent_Click_1(object sender, EventArgs e)
        {
            ClsStudent lcStudent = (ClsStudent)lstStudents.SelectedValue;
            if (lcStudent != null && lcStudent.ViewEdit())
            {
                UpdateDisplay();
            }
        }

        private void BtnFind_Click(object sender, EventArgs e)
        {
            ClsStudent lcStudent;
            if (ClsInstitute.StudentList.TryGetValue(TxtID.Text, out lcStudent))
            {
                lstStudents.SelectedItem = lcStudent;

            }
        }

        private void FrmStudentList_Load(object sender, EventArgs e)
        {
            UpdateDisplay();
        }
    }
}