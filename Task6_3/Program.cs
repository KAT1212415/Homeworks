using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6_3
{
    internal class Program
    {
        static void Main(string[] args)
        {//Нужно создать отчёт, который будет содержать информацию о продажах за определённый период.

            Console.WriteLine("Введите месяц");
            string month = Console.ReadLine();
            Console.WriteLine("ВВедите год");
            string year = Console.ReadLine();
            Console.WriteLine("Общая сумма продаж");
            double summ = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Количество продаж");
            double number = Convert.ToDouble(Console.ReadLine());
            string report = 
               
$@"Отчёт о продажах за {month} {year} год

--------------------------------

Общая сумма продаж: {summ:N2} р.

Количество проданных товаров: {number:N0} шт.

Средняя стоимость товара: {summ/number:N2}  ";

            Console.WriteLine(report);






        }
    }
}
