using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment___2
{
    class Student : IComparable<Student>
    {
        private int studentId;
        private string name;
        private DateTime dob;

        public int StudentId
        {
            get { return studentId; }
            set { studentId = value; }
        }
       
        public DateTime Dob1
        {
            get { return dob; }
            set { dob = value; }
        }

        public DateTime Dob
        {
            get { return dob; }
            set { dob = value; }
        }

        public Student(int _id, string _name, DateTime _dob)
        {
            studentId = _id;
            name = _name;
            dob = _dob;
        }

        // For the sort method
        public int CompareTo(Student other)
        {
            int dob = DateTime.Compare(this.dob, other.dob);
            if (dob == 0)
            {
                return (this.marks.Average() > other.marks.Average()) ? 1 : -1;
            }
            else
            {
                return dob;
            }


        }

        // For printing perposes
        public override string ToString()
        {
            return string.Format("StudentID: {0}\tName: {1}\tDOB: {2}\tAvgMarks: {3}", studentId, name, Dob.ToShortDateString(), marks.Average());
        }


        List<double> marks = new List<double>();


        public void addMarks(double mark)
        {
            marks.Add(mark);
        }
    }
}
