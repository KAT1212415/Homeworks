using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину 1 стороны треугольника");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите длину 2 стороны треугольника");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите длину 3 стороны треугольника");
            int c = Convert.ToInt32(Console.ReadLine());
            double s1 = S(a, b, c);
            Console.WriteLine("Введите длину 1 стороны треугольника 2");
            int a2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите длину 2 стороны треугольника 2");
            int b2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите длину 3 стороны треугольника 2");
            int c2 = Convert.ToInt32(Console.ReadLine());
            double s3 = S(a2, b2, c2);
            
            if (s1 > s3)
            {
                Console.WriteLine($"Площадь треугольника 1 {s1} больше площади треугольника 2 {s3}");
            }
            else
                Console.WriteLine($"Площадь треугольника 1 {s1} меньше площади треугольника 2 {s3}");
        }
        static double S(int a1, int b1, int c1)

        {
            double p = (a1 + b1 + c1) / 2.0;
            double S = Convert.ToDouble(Math.Sqrt(p*(p-a1)*(p-b1)*(p-c1)));
            return S;
        }
        


    }
}
