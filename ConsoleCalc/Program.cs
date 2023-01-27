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
            double resSub = a - b;
            Console.WriteLine("Result subtraction = " + resSub);
            double resMul = a * b;
            Console.WriteLine("Result multiplication = " + resMul);
            double resDiv = a / b;
            Console.WriteLine("Result division = " + resDiv);
            double resMode = a % b;
            Console.WriteLine("Result mode = " + resMode);
            a++;
            Console.WriteLine("Result inc = " + a);
            Console.ReadKey();
        }
    }
}
