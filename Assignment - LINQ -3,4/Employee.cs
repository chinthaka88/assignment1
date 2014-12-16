using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment___LINQ__3_4
{
    class Employee
    {
        private int EmpId;
        private string empnm;
        private string empdep;

        public int EmpId1
        {
            get { return EmpId; }
            set { EmpId = value; }
        }     

        public string Empnm
        {
            get { return empnm; }
            set { empnm = value; }
        }      

        public string Empdep
        {
            get { return empdep; }
            set { empdep = value; }
        }

        public Employee(int _id, string _name, string _dob)
        {
            EmpId = _id;
            empnm = _name;
            empdep = _dob;
        }

    }
}
