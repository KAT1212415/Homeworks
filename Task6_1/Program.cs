using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6_1
{
    internal class Program
    {
        static void Main(string[] args)
        {//Ввести с клавиатуры предложение. Предложение представляет собой слова,
         //разделенные пробелом. Знаки препинания не используются.
         //Найти самое длинное слово в строке.
            Console.WriteLine("введите предложение");
            string a=Console.ReadLine();
            //Console.WriteLine(a);
            string[] words = a.Split(' ');
            string b = " ";
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length > b.Length) { b = words[i]; };            
                //Console.WriteLine(words[i]);

            }
            Console.WriteLine ("Самое длинное слово {0}",b);






        }
    }
}
