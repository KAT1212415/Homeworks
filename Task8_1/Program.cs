using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число 1");
            int n1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число 2");
            int n2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите код операции  1 – сложение, 2 – вычитание, 3 – произведение, 4 – деление ");         
            int kod = Convert.ToInt32(Console.ReadLine());

            if (kod == 1)
            { int Result = n1 + n2; Console.WriteLine($"{n1 + n2}"); }
            else if (kod == 2) { int Result = n1 - n2; Console.WriteLine($"{n1 - n2}"); }
            else if (kod == 3) { int Result = n1 * n2; Console.WriteLine($"{n1 * n2}"); }
            else if (kod == 4)
            { try
                {
                    int Result = n1 / n2;
                }
                catch
                { Console.WriteLine("Деление на 0");
                }
                
            }
        } 
    }
}
