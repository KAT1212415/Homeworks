using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task17_1
{
    internal class Program
    {   static int[] Metod1RamdomArray(int size)
        {
            Console.WriteLine("Метод1 запущен");
            Random rnd = new Random();
            int[] array = new int[size];
            for (int i = 0; i < size; i++)
            { array[i] = rnd.Next(10, 20);
                Console.WriteLine($"Метод1 счетчик({i})={array[i]}");
                Thread.Sleep(500);
            }
            Console.WriteLine("Метод1 завершен");
            return array;
        }

        static int[] Metod2Arrayavaragevalue(int size)
        {
            Console.WriteLine("Метод2 запущен");
            Random rnd = new Random();
            int[] array = new int[size];
            
            int summ = 0;
            for (int i = 0; i < size; i++)
            {
                array[i] = rnd.Next(0,10);
                
                summ +=array[i];
                Console.WriteLine($"Метод2  счетчик ({i})={array[i]} сумма {summ}");
                Thread.Sleep(500);
            }
            int avaragevalue = summ / size;
            Console.WriteLine($"Среднее арифметическое ={avaragevalue}");
            Console.WriteLine("Метод2 завершен");
            return array;
        }

        static async Task <int[]> Metod1Async()
        { Console.WriteLine("Metod1Async запущен");
            int[] result = await Task.Run(() => Metod1RamdomArray(3));

          Console.WriteLine("Metod1Async завершен");
            return result;
        }
        static async Task<int[]> Metod2Async()
        {
            Console.WriteLine("Metod2Async запущен");
            int[] result = await Task.Run(() => Metod2Arrayavaragevalue(3));

            Console.WriteLine("Metod2Async завершен");
            return result;
        }




        static void Main(string[] args)
        {

            /*Console.WriteLine("Main запущен");
            Task task1 = Task.Run(() => { Metod2Arrayavaragevalue(3); });
            Task task2 = Task.Run(() => { Metod1RamdomArray(3); });
            task2.Wait();
            task1.Wait();*/
            Console.WriteLine("Main запущен");
            //Task task1 = Task.Run(() => {Metod2Arrayavaragevalue(5);});
            int[] resultmetod1 = Metod1Async().Result;
            int[] resultmetod2 = Metod2Async().Result;
            //task1.Wait();



            Console.WriteLine("Main завершен");




        }
    }
}
