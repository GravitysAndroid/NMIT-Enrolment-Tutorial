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
        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnManageStudents_Click_1(object sender, EventArgs e)
        {
            FrmStudentList _FrmStudentList = new FrmStudentList();
            _FrmStudentList.ShowDialog();
            LblStudentDetails.Text = string.Format("{0} Student(s)\nTotal Balance: {1:C}", ClsInstitute.StudentList.Count, ClsInstitute.TotalBalance());
        }
    }
}

