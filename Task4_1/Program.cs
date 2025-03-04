using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Вводится натуральное число n. Найти n! Например, 6! = 1 * 2 * 3 * 4 * 5 * 6
           Console.WriteLine("задача 1. введите число");
            int number1 = Convert.ToInt32(Console.ReadLine());
            int f1=1;

            for (int j = 1; j <= number1; j++)
            {
                f1 = f1* j;      
                //Console.WriteLine("i={0} f={1}", j, f1);
            }
            Console.WriteLine("{0}!={1}", number1,f1);

            //2.Вводится натуральное число n. Найти 1 + 1 / 2 + 1 / 3 + … +1 / n
           Console.WriteLine("задача 2.введите число");
            int number7 = Convert.ToInt32(Console.ReadLine());
            double ff1 = 1;

            for (int ii = 2; ii <= number7; ii++)
            {
                ff1 = ff1+(1 / Convert.ToDouble(ii));
                //Console.WriteLine("i={0} f={1}", ii, ff1);
            }
            Console.WriteLine("сумма равна={0}", ff1);

            // 3. Вводятся целые числа a>0, b>0. Найти a^b. Не использовать класс Math
            Console.WriteLine("задача 3. введите 2 числа");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = a; 
            for (int z = 2; z <= b;  z++)
            {
                c = c * a;           
                //Console.WriteLine("z={0} aa={1}", z, c);
            }
            Console.WriteLine("{0}  в степени {1} равно {2}", a, b, c);
            // 4. Вводятся целые числа a>0, b<0. Найти a^b. Не использовать класс Math
            Console.WriteLine("задача 4. введите 2 числа,второе отрицательное");
            int a1 = Convert.ToInt32(Console.ReadLine());
            int b1 = Convert.ToInt32(Console.ReadLine());
            int c1 = a1;            
            if (b1 < 0) {b1 = 0 - b1; //Console.WriteLine("b1={0}", b1); };
            for (int q = 2; q <= b1; q++)
            {
                c1 = c1 * a1;
                //Console.WriteLine("{0}  в степени {1} равно {2}", a1, b1, c1);
            }
            Console.WriteLine("{0}  в степени {1} равно {2}", a1, b1, c1);
            //5. Запрашивать у пользователя число до тех пор, пока он не введет число из диапазона[20; 60]
              Console.WriteLine("задача 5. введите число");
           int number5 = Convert.ToInt32(Console.ReadLine());
            while (number5 < 20 || number5 > 60)
            {
                Console.WriteLine("Введите число");
                number5 = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Число {0} больше 20 и меньше 60", number5);
            //6.Вводится n. Определить, является ли оно степенью 2-ки
              Console.WriteLine("задача 6. введите число");
            int number2 = Convert.ToInt32(Console.ReadLine());
            Double number3 = number2;

            while (number3 >= 2 )
            {
                number3 = number3 / 2.0;
            }
            if (number3 == 1)
            {
                Console.WriteLine("число {0} степень двойки", number2);
            } else
            {
                Console.WriteLine("число {0} не степень двойки", number2);
            }

            //7.Вводится n. Определить количество цифр в числе
            Console.WriteLine("задача 7. введите число");
            int number4 = Convert.ToInt32(Console.ReadLine());
            int i = 1;
            while (number4 > 9)
               
            {
                number4 = number4 / 10;// Console.WriteLine("number4={0}, i={1}", number4,i);
                i++; 

            }
            
            Console.WriteLine("Количество цифр {0}",i);
        }

    }
}
