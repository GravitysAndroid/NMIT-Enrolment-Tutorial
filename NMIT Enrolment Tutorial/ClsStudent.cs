using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NMIT_Enrolment_Tutorial
{
    abstract public class ClsStudent
    {
        private string _ID;
        private string _Name;
        private DateTime _DOB = DateTime.Today;
        private decimal _Balance;
        public static readonly string[] _StudentType = { "MOE (local)", "International" };

        public override string ToString()
        {
            return _ID + "\n" + _Name;
        }

        public string ID
        {
            get { return _ID; }
            set { _ID = value; }
        }

        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        public DateTime DOB
        {
            get { return _DOB; }
            set { _DOB = value; }
        }

        public decimal Balance
        {
            get { return _Balance; }
            set { _Balance = value; }
        }

        public static ClsStudent NewStudent(int prChoice)
        {
            if (prChoice == 0)
                return new ClsMOEStudent();
            else
                return new ClsInternationalStudent();
        }
        public abstract bool ViewEdit();
    }
}
