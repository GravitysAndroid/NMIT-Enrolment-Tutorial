﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NMIT_Enrolment_Tutorial
{
    [Serializable]
    class ClsMOEStudent : ClsStudent
    {
        private decimal _LoanAmount;
        private bool _FullTime;
        private static FrmStudent _MOEStudentForm = new FrmMOEStudent();

        public decimal LoanAmount 
        { 
            get => _LoanAmount; 
            set => _LoanAmount = value; 
        }
        public bool FullTime 
        { 
            get => _FullTime; 
            set => _FullTime = value; 
        }

        public override bool ViewEdit()
        {
            return _MOEStudentForm.ShowDialog(this);
        }

        protected override string TypeOfStudent()
        {
            return "MOE";
        }
    }
}
