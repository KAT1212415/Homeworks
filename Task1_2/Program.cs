using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Task1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {   //1. обменять местами числа
              int a = 1;
              int b = 2;
              int c = 3;
              b = a;
              a = c;          
              c = a - b;

              Console.WriteLine("1 задание a={0} b={1} c={2}", a, b, c);

            // 2. Перевести угол из градусов в радианы.
            Console.WriteLine("2 задание Тут пока ничего нет");

            // 3. Перевести значение длины из дюймов в метрическую систему
            Console.Write("3 задание Введите целое число");
            double l = Convert.ToDouble (Console.ReadLine());
            double n = 0.0254;
            int mm = Convert.ToInt32(l * n * 1000); //перевод в мм всего
            int mm1 = mm%10; //перевод в мм остатка
            int m = Convert.ToInt32 (mm)/1000;//перевод в метры              
            int sm = Convert.ToInt32(mm / 10);//перевод в см     
            Console.WriteLine(" 3 задание l={0} дюймов равно m={1} метров {2} см {3} мм", l, m, sm, mm1);


            // 4. Вводится четырехзначное число.Поменять местами 2 - ую и 4 - ую цифру.
            
            Console.Write("4 задание Введите 4-х значное число");
            int abcd = Convert.ToInt32(Console.ReadLine());
            int aa = abcd/1000;
            int bb = (abcd- aa * 1000)/ 100;
            int cc = (abcd - aa * 1000 - bb * 100) / 10;
            int dd = abcd % 10;
            int adcb = aa*1000+dd*100+cc*10+bb;
            Console.WriteLine("4 задание abcd={0} aa ={1} bb ={2} cc ={3} dd ={4} adcb ={5} ", abcd, aa, bb, cc, dd, adcb);

            // 5. Округление числа в большую сторону.
            Console.Write("5 задание Введите длину трубы");
            double aa1 = Convert.ToDouble(Console.ReadLine());
            int aa3 = Convert.ToInt32(aa1);//отбросить десятичную часть числа из 17,1 в 17       
            double aa7 = Convert.ToDouble(Convert.ToInt32(aa1));//перевести целое число 17 в число
                                                                //с запятой чтобы выполнить действие
            double aa6 = (aa1-aa7)+1;                          //(17,1-17)+1 = 1 ,1      
            int a2 = Convert.ToInt32 (aa1 + 0.9 *aa6);          //17+0,9*0 если число 17
                                                                //17+0,9*1 если число больше 17, напр 17,2


            Console.WriteLine("5 задание {0}+0.9*{1} = {2}  {1}={0}-{3} ", aa1, aa6, a2, aa7);
        }
    }
}
