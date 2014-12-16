using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment___LINQ__3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            List<Employee> empList = new List<Employee>();
            Employee e;
            for (int i = 0; i <20; i++)
            { 
                string dip="";
                switch (r.Next(1, 4))
	            {
                    case 1: dip = "IT"; break;
                    case 2: dip = "HR"; break;
                    case 3: dip = "Resorce Management"; break;
                    case 4: dip = "Accounts"; break;
	             }

            e = new Employee(r.Next(1, 1000), "Employee_" + i, dip);
                empList.Add(e);
            }

            foreach (var item in empList.OrderBy(x => x.EmpId1))
            {
                System.Console.WriteLine(item);
            }
        }
    }
}
