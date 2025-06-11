using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task15_1
{
    internal class Program
    {
        static void Main(string[] args)
        {List<string> list = new List<string>();
            list.Add("Иванов");
            list.Add("Петров");
            list.Add("Сидоров");
            list.Insert(1, "Козлов");
            bool check = list.Contains("Петров");
            list.Remove("Сидоров");
            int index1 = list.IndexOf("Козлов");
            list.Sort();
            Console.WriteLine($"Есть ли игрок Петров в команде?{check}");
            Console.WriteLine($"Индекс игрока Козлов {index1}");
            Console.WriteLine("Текущий состав команды:");
            for (int i = 0; i < list.Count; i++) {Console.WriteLine(list[i], list[i]);}
            Console.WriteLine($"Команда пуста?{list.Count}");
            list.Clear();
            Console.WriteLine($"Количество игроков после очистки{list.Count}");



        }
    }
}
