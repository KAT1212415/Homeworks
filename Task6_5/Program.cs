using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task6_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер телефона, начиная с +7");
            string number = Console.ReadLine();
            string number2 = @"^\+\d\(\d{3}\)\d{3}-\d{2}-\d{2}$";
            Regex number3 = new Regex(number2);

            if (number3.IsMatch(number))
            { Console.WriteLine("Номер корректен"); }
            else
            {
                Console.WriteLine("Номер не корректен");
            }
        }
    }
}
