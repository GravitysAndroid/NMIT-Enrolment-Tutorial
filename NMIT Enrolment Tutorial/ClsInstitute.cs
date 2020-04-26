using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NMIT_Enrolment_Tutorial
{
    class ClsInstitute
    {
        private static List<ClsStudent> _StudentList = new List<ClsStudent>();

        public static List<ClsStudent> StudentList 
        { 
            get => _StudentList; /*set => _StudentList = value;*/
        }

        public static decimal TotalBalance()
        {
            decimal lcTotal = 0;
            foreach (ClsStudent lcStudent in _StudentList)
                lcTotal += lcStudent.Balance;
            return lcTotal;
        }
    }
}
