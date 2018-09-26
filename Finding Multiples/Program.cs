using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing
{
    class Program
    {//Write a C# Sharp program to check if a given positive number is a multiple of 3 or a multiple of 7. 
        static void Main(string[] args)
        {
            var numbers = new[] { 10, 11, 12, 13, 14, 15, 16, 16, 18, 19, 20 };

            foreach (var i in numbers)
            {
                if (i % 3 == 0)
                    Console.WriteLine("True");
                else if (i % 7 == 0)
                    Console.WriteLine("True");
                else
                    Console.WriteLine("False");
            }
        }
    }
}
