using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ввести с клавиатуры предложение.
            //Предложение представляет собой слова,
            //разделенные пробелом.Знаки препинания не используются.
            //Составить программу, определяющую,
            //является ли строка палиндромом без учёта пробелов и
            //регистра(пример палиндрома – «А роза упала на лапу Азора»)
            Console.WriteLine("введите предложение");
            string a = Console.ReadLine();
            //Console.WriteLine(a);
            string c = a.Replace(" ", "");
            Console.WriteLine(c);
            bool b = false;
            int x = c.Length;

            for (int i = 0; i < c.Length / 2; i++)
            {
                if (c[i] == c[x - 1])
                {
                    b = true;
                    break;
                }

            }
            if (b == true)
            {
                Console.WriteLine("Это палиндром");
            }
            else
            {
                Console.WriteLine("Это не палиндром");
            }
            

        }

    }
}
