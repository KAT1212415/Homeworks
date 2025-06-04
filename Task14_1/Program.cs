using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static Task14_1.Program;

namespace Task14_1
{
    internal class Program
    {

        public delegate int Mydeligate(int a);
        public static int[] Metod1(Mydeligate mydeligate, int[] numbers)
         {
            int[] newnumbers = new int[numbers.Length];
            for (int i = 0;i<numbers.Length;i++)
                 {

                  newnumbers[i] = mydeligate(numbers[i]);
                  Console.WriteLine(newnumbers[i]);
                  }
            return newnumbers;
         }
        static void Main(string[] args)
        {
            Mydeligate Transformer1 = a => a*2;
            int[] numbers = { 1, -2, 3, 4 };
            Metod1(Transformer1, numbers);
            Console.WriteLine();
            Mydeligate Transformer2 = a => a * a;
            Metod1(Transformer2, numbers);
            Console.WriteLine();
            Mydeligate Transformer3 = a => a >=0? a:-a;
            Metod1(Transformer3, numbers);


        }
    }
}
     
      