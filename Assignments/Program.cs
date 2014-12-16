using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    class Program
    {
        static void Main(string[] args)
        {
             Dictionary<int, student> dictionarystudent = new Dictionary<int, student>(); 

            student student1 = new student() {ID = 101, Name = "Ruwan", course = "IT"};
            student student2 = new student() {ID = 102, Name = "Kalum", course = "Maths"};
            student student3 = new student() {ID = 103, Name = "Aruna", course = "Science"}; 

            dictionarystudent.Add(student1.ID,student1); 
            dictionarystudent.Add(student2.ID,student2); 
            dictionarystudent.Add(student3.ID,student3);

            foreach (KeyValuePair<int, student> studentKeyValuePair in dictionarystudent) 
            { 
                student stu = studentKeyValuePair.Value;
                Console.WriteLine("ID = {0}, Name = {1}, course = {2}", stu.ID, stu.Name, stu.course);
                
            }
            Console.ReadLine();
 
        }
    }
    public class student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string course { get; set; }
 
        }
    }

