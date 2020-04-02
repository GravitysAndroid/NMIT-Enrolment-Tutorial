using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NMIT_Enrolment_Tutorial
{
    class ClsMOEStudent : ClsStudent
    {
        private decimal _LoanAmount;
        private bool _FullTime;
        private FrmMOEStudent _Form;

        public override bool ViewEdit()
        {
            return _Form.ShowDialog(this);
        }

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
    }
}
