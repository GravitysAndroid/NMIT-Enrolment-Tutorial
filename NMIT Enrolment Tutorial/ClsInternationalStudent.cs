using System;
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
        private static FrmInternationalStudent _Form;

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
            return _Form.ShowDialog(this);
        }
    }
}
