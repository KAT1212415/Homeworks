using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int [] array = { 1, 2, 3, 4 };
            FindMax(array);
        }
        static void FindMax( params int[] number)
            
        {
            int max = 0;
            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] > max) 
                {
                    max=number[i];
                }

            }
            Console.WriteLine(max);
        
        }
    }   
}

