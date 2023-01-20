using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            int resAdd;
            Console.Write("Input first: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input second: ");
            b = Convert.ToInt32(Console.ReadLine());
            resAdd = a + b;
            Console.WriteLine("Result addition: "+ resAdd);
            Console.ReadKey();
        }
    }
}
