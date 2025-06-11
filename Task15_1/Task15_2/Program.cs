using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task15_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> catalog = new Dictionary<string, int>();
            catalog.Add("A001", 10);
            catalog.Add("B205", 25);
            catalog.Add("C307", 15);
            bool check = catalog.ContainsKey("B205");
            catalog["A001"] = 8;          
            bool checkcount1 = catalog.TryGetValue("C307", out int count1);
            catalog["B205"] = 30;
            catalog.Remove("C307");
            Console.WriteLine($"Есть ли товар с артикулом B205 {check}");
            Console.WriteLine($"количество наушников {count1}");
            Console.WriteLine($"Текущий инвентарь");
            foreach (var i in catalog)
            {
                Console.WriteLine($"Артикул{i.Key}-{i.Value}шт.");
            }
            if (catalog.Count == 0) {
                Console.WriteLine($"Инвентарь пуст");
            }
            else { Console.WriteLine($"Инвентарь полон"); };
            catalog.Clear();
            Console.WriteLine($"количество товаров после очистки {catalog.Count}");
        }
    }
}
