using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("число элементов массива");
            int a = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[a];
            Console.WriteLine("Введите числа");
            for (int i = 0; i < a; i++)
            {
                Console.WriteLine($"введите {i + 1} элемент ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            PrintNumbers(numbers, true);
        }
        static void PrintNumbers(int[] numbers, bool reverse = false)
        {
            if (reverse == false)
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    Console.WriteLine(numbers[i]);
                }
            }
            else
            {
                for (int i = numbers.Length - 1; i >= 0; i--)
                {
                    Console.WriteLine(numbers[i]);
                }
            }
        }
    }
}
