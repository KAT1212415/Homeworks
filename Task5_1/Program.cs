using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5_1
{
    internal class Program
    {
        static void Main(string[] args)
        {//Задача 1. Сформировать одномерный массив из 10 случайных чисел из диапазона [0, 100].
         //Определить, каких чисел больше – четных или нечетных
            Console.WriteLine("Задача 1");
   
            int[] array1 =new int[10];
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                array1[i] = rnd.Next(0, 101);
                Console.Write("{0} ", array1[i]);
            }
            Console.WriteLine();
            //Задача 2.Сформировать одномерный массив из 10 случайных чисел из диапазона [-20, 20].
            //Определить количество положительных, отрицательных и равных нулю элементов
            Console.WriteLine("Задача 2");
            int[] array = new int[10];
            Random rnd2 = new Random();
            int a=0;
            int b=0;  
            int c=0;
            for (int i = 0; i < 10; i++)
            {
                array[i] = rnd2.Next(-20, 21);

                
                    if (array[i] < 0)
                {
                    a++;
                }
                else
                {
                    if (array[i] > 0)
                    {
                        b++;
                    }
                    else 
                    { 
                        c++; 
                    }
                }
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine("кол отр={0} кол пол={1} кол равн 0={2}", a,b,c);
            //Задача 3.Сформировать одномерный массив из 10 случайных чисел из диапазона[0, 50]. 
            //Найти и вывести значение максимального, минимального элементов и их индексы
            Console.WriteLine("Задача 3");
            int[] array2 = new int[10];
            Random rnd3 = new Random();
            int max = 0;
            int min = 50;
            int maxi = 0;
            int mini = 0;
            for (int i = 0; i < 10; i++)
            {
                array2[i] = rnd3.Next(0, 51);


                if (array2[i] <= min)
                {
                    min = array2[i]; mini= i;
                }
                else
                {
                    if (array2[i] >= max)
                    {
                        max = array2[i]; maxi = i;
                    }

                }
                Console.Write("{0} ", array2[i]);
            }
            Console.WriteLine();
            Console.WriteLine(" max ={0} min ={1} maxi ={2} mini ={3}", max, min, maxi, mini);
            //Задача 4.Сформировать одномерный массив из 10 случайных чисел из диапазона [0, 10].
            //Перевернуть массив, т.е. переставить элементы массива в обратном порядке

            Console.WriteLine("Задача 4");
            int[] array3 = new int[10];
            Random rnd4 = new Random();
            int m;
            for (int i = 0; i < 10; i++)
            {
                array[i] = rnd4.Next(0, 51);
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine(); 
            for (int i = 0; i < 5; i++)
            {
                m = array[i];
                array[i] = array[9 - i];
                array[9 - i] = m;
            }
            Console.WriteLine();
            for (int i = 0; i < 10; i++)
            { Console.Write("{0} ", array[i]); }
            Console.WriteLine();
            //Задача 5. Сформировать одномерный массив из 10 случайных чисел в диапазоне [-50, 50].
            //Первые 5 элементов упорядочить по возрастанию, вторые 5 – по убыванию.
            //Вывести отсортированный таким образом массив на экран

            Console.WriteLine("Задача 5");
            int mm = 10;
            int t = 45;
            int[] array4 = new int[mm];
            Random rnd5 = new Random();
            //int[] array = new int [5]{ 1, 2, 3, 4, 5};
            for (int i = 0; i < mm; i++)
            {
                array4[i] = rnd5.Next(-50, 51);
                Console.Write("{0} ", array4[i]);

            }


            for (int i = 0; i < 10; i++)
            {
                if (i < 5)
                {
                    for (int j = i + 1; j < 5; j++)
                    //Console.WriteLine("{0} ", array[i]);

                    {
                        if (array4[i] > array4[j])
                        {
                            t = array4[i]; array4[i] = array4[j]; array4[j] = t;
                        }
                        //Console.WriteLine("{0} ", array[i]);
                    }
                }

                else
                {
                    for (int j = i + 1; j < 10; j++)
                    //Console.WriteLine("{0} ", array[i]);

                    {
                        if (array4[i] < array4[j])
                        {
                            t = array4[i]; array4[i] = array4[j]; array4[j] = t;
                        }
                       // Console.WriteLine("{0} ", array4[i]);
                    }
                }
            }
            Console.WriteLine();

            for (int aa = 0; aa < mm; aa++)
            {
                Console.Write("{0} ", array4[aa]);
            }
            Console.WriteLine();
            //Задача 6.Сформировать двумерный массив вида

            //1 0 1 0 1
            //0 1 0 1 0
            //1 0 1 0 1
            //0 1 0 1 0
            //1 0 1 0 1

            //Сформировать двумерный массив из 10 строк и 5 столбцов.
            //Заполнить его случайными числами в диапазоне[0, 10].
            //Определить максимальный элемент в каждой строке
            Console.WriteLine("Задача 6");

            int n = 5;

                    int[,] array5 = new int[n*2, n];
                    Random rnd6 = new Random();
                    for (int i = 0; i < n*2; i++)
                    { for (int j = 0; j < n; j++)
                        {
                            array5[i, j] = (i+j)%2==0 ? 1 : 0;
                            Console.Write("{0,3} ", array5[i, j]);
                        }
                            //array[i, j] = rnd.Next(-50, 51);                  

                        Console.WriteLine();
                    }

            // Задача 7.Сформировать двумерный массив из 10 строк и 5 столбцов.
            // Заполнить его случайными числами в диапазоне [0, 10].
            // Определить максимальный элемент в каждой строке


            Console.WriteLine("Задача 7");
            int nn = 5;
            int max1=1;

            int[,] array6 = new int[nn * 2, nn];
            Random rnd7 = new Random();
            for (int i = 0; i < nn * 2; i++)
            {
                for (int j = 0; j < nn; j++)
                {
                    array6[i, j] = rnd7.Next(-50, 51);
                    Console.Write("{0,3} ", array6[i, j]);
                }
                Console.WriteLine();
            }
            
            for (int i = 0; i < nn * 2; i++)
            {
                for (int j = 0; j < nn; j++)
                {
                    max1 = array6[i, 0];
                    max1= array6[i, j] > max1 ? max1 = array6[i, j] : array6[i, 0];

                }
                Console.WriteLine("max {0} строки {1}  ", i, max1);
            }



        }
    }
}
