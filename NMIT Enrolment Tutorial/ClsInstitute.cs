using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace NMIT_Enrolment_Tutorial
{
    [Serializable]
    class ClsInstitute
    {
        //private static List<ClsStudent> _StudentList = new List<ClsStudent>();
        private static string fileName = "NmitStorage";
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

        public static void Save()
        {
            using (FileStream lcFileStream = new FileStream(fileName, FileMode.Create))
                {
                    BinaryFormatter lcFormatter = new BinaryFormatter();
                    lcFormatter.Serialize(lcFileStream, _StudentList);
                }
            }

    public static void Retrieve()
    {
        using (FileStream lcFileStream = new FileStream(fileName, FileMode.Open))
        {
            BinaryFormatter lcFormatter = new BinaryFormatter();
            _StudentList = (Dictionary<string, ClsStudent>) lcFormatter.Deserialize(lcFileStream);
        }
    }
    }
}
