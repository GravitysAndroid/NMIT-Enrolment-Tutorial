using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NMIT_Enrolment_Tutorial
{
    [Serializable]
    class ClsInstitute
    {
        //private static List<ClsStudent> _StudentList = new List<ClsStudent>();
        private static Dictionary<string, ClsStudent> _StudentList = new Dictionary<string, ClsStudent>();

        public static Dictionary<string, ClsStudent> StudentList 
        {
            get => _StudentList; /*set => _StudentList = value;*/ 
        }

        public static decimal TotalBalance()
        {
            decimal lcTotal = 0;
            foreach (ClsStudent lcStudent in StudentList.Values)
                lcTotal += lcStudent.Balance;
            return lcTotal;
        }
    }
}
