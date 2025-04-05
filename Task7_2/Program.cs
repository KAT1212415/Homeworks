using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину стороны куба");
            double edgeLength = Convert.ToDouble(Console.ReadLine()); ;
            CalcCube(edgeLength, out double volume, out double surfaceArea);
            
        }
        static void CalcCube(double edgeLength, out double volume, out double surfaceArea)
        {
            volume = edgeLength * edgeLength * edgeLength;
            surfaceArea = 6 * edgeLength * edgeLength;
            Console.WriteLine($"Объем куба : {volume}");
            Console.WriteLine($"Площадь поверхности:{surfaceArea}");
        }
    }
}
