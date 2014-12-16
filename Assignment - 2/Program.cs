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
          
            Student s1 = new Student(1, "Aruna", new DateTime(1988,02,25), 50);
            Student s2 = new Student(2, "Kamal", new DateTime(1988, 02, 25), 80);
            Student s3 = new Student(3, "Nimal", new DateTime(1988, 02, 25), 60);

            var studentList = new List<Student>();

            studentList.Add(s1);
            studentList.Add(s2);
            studentList.Add(s3);

            studentList.Sort();

            foreach (var item in studentList)
            {
                System.Console.WriteLine(item);
            }
            System.Console.Read();

            
        }
    }
}
