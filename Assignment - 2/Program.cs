using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment___2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            List<Student> stuList = new List<Student>();
            Student s1;
            for (int x = 0; x < 10; x++)
            {
                DateTime bday = new DateTime(r.Next(1988, 2000), r.Next(1, 12), r.Next(1, 25));
                s1 = new Student(r.Next(), "Student1" + x, bday);
                for (int i = 0; i < 10; i++)
                {
                    s1.addMarks(r.Next(0, 99));
                }
                stuList.Add(s1);
                s1 = new Student(r.Next(), "Student2" + x, bday);
                for (int i = 0; i < 10; i++)
                {
                    s1.addMarks(r.Next(0, 99));
                }
                stuList.Add(s1);
            }

            //Need to overide  public int CompareTo() in Student calss

            stuList.Sort();

            //foreach (var item in stuList)
            //{
            //    System.Console.WriteLine(item);
            //}
            //System.Console.Read();


            //Dictionary<Student, Course> stuDic = new Dictionary<Student, Course>();
            //int xx = 0;
            //Course cc;
            //foreach (var item in stuList)
            //{
            //    xx++;
            //    cc = new Course(r.Next(1, 1000), "Course" + xx);
            //    stuDic.Add(item, cc);
            //}

            //foreach (var item in stuDic)
            //{
            //    System.Console.WriteLine(item);
            //}
            //System.Console.Read();
            
        }
    }
}
