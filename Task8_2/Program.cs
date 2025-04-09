using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите возраст");
            int age = AValidateAge(Convert.ToInt32(Console.ReadLine()));
        }
        static int AValidateAge (int age)
        {

            if (age <= 0)
            {
                throw new ArgumentException($"Возраст {age} меньше нуля"); 
                //Console.WriteLine("Возраст меньше 0");
            }
            else
                if (age > 150)
            {
                throw new ArgumentException($"Возраст{age} больше 150");
                //Console.WriteLine("Возраст больше 150");
            }
            Console.WriteLine("Возраст от 0 до 150");
                return age;
        
        }

    }
}
