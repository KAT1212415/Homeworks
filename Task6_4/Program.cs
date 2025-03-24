using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Имя");
            string name = Console.ReadLine();
            Console.WriteLine("Возраст");
            string year = Console.ReadLine();
            Console.WriteLine("Город");
            string City = Console.ReadLine();

            StringBuilder report = new StringBuilder();
            report.Append("Имя ");
            report.Append(name);
            report.Append(" Возраст ");
            report.Append(year);
            report.Append(" Город ");
            report.Append(City);
            
            Console.WriteLine(report.ToString());

        }
    }
}
