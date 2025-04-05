using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int c = Multiply(4,4);
            Console.WriteLine(c); 
            double c1 = Multiply(4.5, 4);
            Console.WriteLine(c1);
        }
        static int Multiply(int a, int b)
        { 
            return a * b;

        
        }
        static double Multiply(double a, double b)
        {
            return a * b;

        }
    }
}
