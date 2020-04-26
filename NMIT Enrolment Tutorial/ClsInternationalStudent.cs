﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NMIT_Enrolment_Tutorial
{
    class ClsInternationalStudent : ClsStudent
    {
        private string _Country;
        private string _ELTS;
        //private static FrmInternationalStudent _IntStudentForm;
        private static FrmStudent _IntStudentForm = new FrmInternationalStudent();

        public string Country 
        { 
            get => _Country; 
            set => _Country = value; 
        }
        public string ELTS 
        { 
            get => _ELTS; 
            set => _ELTS = value; 
        }

        public override bool ViewEdit()
        {
            return _IntStudentForm.ShowDialog(this);
        }

        //private FrmStudent _MOEStudentForm = new FrmMOEStudent();
        private readonly string Intl;

        protected override string TypeOfStudent()
        {
            return Intl;
        }
    }
}
