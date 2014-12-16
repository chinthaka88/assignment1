using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_LINQ_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var primes = new List<int> { 2, 5, 7, 70, 80, 90, 25, 35, 15, 20 };
            IEnumerable<int> query = from val in primes
                                     select val;

            Console.WriteLine(query.Max());
            Console.ReadLine();

            Console.WriteLine(query.Average());
            Console.ReadLine();

            var seq = new List<string> { "Rohan", "Aruna", "Kamal", "Ruwan", "Rajitha", "Nuwan", "Piyumi" };
            IEnumerable<string> query1 = from val in seq
                                         select val;

            Console.WriteLine(seq.Max());
            Console.ReadLine();
        }
    }
}
