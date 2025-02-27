using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {//1. Вводятся два числа. Сравнить их и вывести правильный знак «<», «>» или «=»
            Console.WriteLine("Введите 2 числа");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            if (a == b)
            {
                Console.WriteLine("a=b");
            }
            else
            {
                if (a < b)
                {
                    Console.WriteLine("a<b");
                }
                else
                {
                    Console.WriteLine("a>b");
                }


                //2. Вводятся три числа. Вывести большее их них.
                Console.WriteLine("Введите 3 числа");
                int aa1 = Convert.ToInt32(Console.ReadLine());
                int ab1 = Convert.ToInt32(Console.ReadLine());
                int ac1 = Convert.ToInt32(Console.ReadLine());
                int max;
                if (aa1 > ab1 && aa1 > ac1)
                {
                    max = aa1;
                }
                else if (ab1 > aa1 && ab1 > ac1)
                {
                    max = ab1;
                }
                else
                {
                    max = ac1;
                }
                Console.WriteLine("max={0}", max);

                //3. Вводятся 4 числа. Вывести большее их них.
                Console.WriteLine("Введите 3 числа");
                int aa = Convert.ToInt32(Console.ReadLine());
                int ab = Convert.ToInt32(Console.ReadLine());
                int ac = Convert.ToInt32(Console.ReadLine());
                int ad = Convert.ToInt32(Console.ReadLine());
                int max1;
                if (aa > ab && aa > ac && aa > ad)
                {
                    max1 = aa;
                }
                else if (ab > aa && ab > ac && ab > ad)
                {
                    max1 = ab;
                }
                else if (ac > aa && ac > ab && ac > ad)
                {
                    max1 = ac;
                }
                else
                {
                    max1 = ad;
                }
                Console.WriteLine("max={0}", max);
                // 4.Вводятся три разных числа. Вывести медиану – среднее по величине число.
                Console.WriteLine("Введите 3 числа");
                int ba = Convert.ToInt32(Console.ReadLine());
                int bb = Convert.ToInt32(Console.ReadLine());
                int bc = Convert.ToInt32(Console.ReadLine());
                int mediana;
                if ((ba > bb && ba < bc) || (ba < bb && ba > bc))
                {
                    mediana = ba;
                    Console.WriteLine("mediana ={0}", ba);
                }
                else if ((bb > ba && bb < bc) || (bb < ba && bb > bc))
                {
                    mediana = bb;
                    Console.WriteLine("mediana ={0}", bb);
                }
                else Console.WriteLine("mediana ={0}", bc);

                // 5.Вводится число. Вывести «Да», если оно оканчивается на 0, и «Нет» в противном случае.
                Console.WriteLine("Введите число");
                int сa = Convert.ToInt32(Console.ReadLine());
                int nc = сa % 10;
                if (nc == 0) Console.WriteLine("{0} оканчивается на 0", сa);
                else
                {
                    Console.WriteLine("{0} не оканчивается на 0", сa);
                }

                //6.Вводится число. Вывести «Да», если оно четное, и «Нет» в противном случае.
                Console.WriteLine("Введите число");
                int fa = Convert.ToInt32(Console.ReadLine());
                int nf = fa % 2;
                if (nf == 0) Console.WriteLine("{0} четное", fa);
                else
                {
                    Console.WriteLine("{0} не четное", fa);
                }
                //7. Вводится число. Вывести «Да», если оно двухзначное, и «Нет» в противном случае.
                Console.WriteLine("Введите число");
                int ga = Convert.ToInt32(Console.ReadLine());
                if (ga > 10 && ga < 100) Console.WriteLine(" двухзначное", ga);
                else
                {
                    Console.WriteLine("нет");
                }

                //8. Вводится число. Вывести «Да», если оно попадает в диапазон [-10,10], и «Нет» в противном случае.
                Console.WriteLine("Введите число");
                int ha = Convert.ToInt32(Console.ReadLine());
                if (ha > -10 && ha < 10) Console.WriteLine("Да");
                else
                {
                    Console.WriteLine("нет");
                }
                //Вводится число. Вывести «Да», если оно попадает в диапазон (-∞; -10] Ս [10; +∞), и «Нет» в противном случае.
                Console.WriteLine("Введите число");
                int ia = Convert.ToInt32(Console.ReadLine());
                if (ia <= -10 || ia >= 10) Console.WriteLine("Да");
                else
                {
                    Console.WriteLine("нет");
                }
                //9.Застройщик построил n домов. Вывести фразу «Мы построили n домов»,
                //обеспечив правильное согласование числа со словом «дом»,
                //например: 20 — «Мы построили 20 домов», 32 — «Мы построили 32 дома»,
                //41 — «Мы построили 41 дом»
                Console.WriteLine("Введите число домов");
                int ha1 = Convert.ToInt32(Console.ReadLine());
                if (ha1 % 10 == 1) Console.WriteLine("Мы построили {0} дом", ha);
                else
                {
                    if (ha % 10 > 1 && ha % 10 < 5) Console.WriteLine("Мы построили {0} дома", ha1);
                    else
                    {
                        Console.WriteLine("Мы построили {0} домов", ha);
                    }
                    //10.Можно ли на прямоугольном участке застройки размером a * b метров
                    //разместить два дома размером в плане p * q и r * s метров?
                    //Дома можно располагать только параллельно сторонам участка.
                    //Дома могу стоять «вплотную» друг к другу.
                    Console.WriteLine("Введите длину участка a");
                    int a1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите ширину участка b");
                    int b1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите ширину 1 дома ");
                    int p = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите длину 1 дома ");
                    int q = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите ширину 2 дома ");
                    int r = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите длину 2 дома ");
                    int s = Convert.ToInt32(Console.ReadLine());
                    if (((p + r) <= a1 && q <= b1 && s <= b1) ||
                        ((p + s) <= a1 && q <= b1 && r <= b1) ||
                        ((q + s) <= a1 && p <= b1 && r <= b1) ||
                        ((q + r) <= a1 && p <= b1 && s <= b1) ||
                        ((p + r) <= b1 && q <= a1 && s <= a1) ||
                        ((p + s) <= b1 && q <= a1 && r <= a1) ||
                        ((q + s) <= b1 && p <= a1 && r <= a1) ||
                        ((q + r) <= b1 && p <= a1 && s <= a1))


                        Console.WriteLine("Разместить два дома размером {0}на{1} и {2} на {3}в плане на участке {4} на {5} метров можно", p, q, r, s, a1, b1);
                    else
                    {
                        Console.WriteLine("Нет");
                    }
                }
            }
        }
    }
}