using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment___3
{
    class Program
    {
        static void Main(string[] args)
        {


            Stack myStack = new Stack();
            myStack.Push("Hello");
            myStack.Push("World");
            myStack.Push("!");
            myStack.Push("good");
            myStack.Push("bye");

            PrintValues(myStack);
            Console.ReadLine();

            myStack.Pop();
            PrintValues(myStack);
            Console.ReadLine();

            myStack.Push("bye");
            PrintValues(myStack);
            Console.ReadLine();


            //IEnumerable<string> age_Ienumarable = (IEnumerable<string>)myStack;
            //foreach (string age in age_Ienumarable)
            //Console.WriteLine(age);
            //Console.ReadLine();
    
        }

        public static void PrintValues(IEnumerable myCollection)
        {
            foreach (Object obj in myCollection)
                //Console.Write("    {0}", obj);
                //Console.WriteLine();
                Console.WriteLine("   {0}",obj);

        }
    }
}
