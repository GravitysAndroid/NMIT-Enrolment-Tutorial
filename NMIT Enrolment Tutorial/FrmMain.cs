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
        private FrmStudent _StudentForm = new FrmStudent();
        public FrmMain()
        {
            InitializeComponent();
        }
        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnCreateStudent_Click(object sender, EventArgs e)
        {
            _Student = new ClsStudent();
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

