using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task16_1
{
    internal class Program
    { 
        static void Main(string[] args)
        {
            List<Computer> list = new List<Computer>
            {
                new Computer
                {
                    Code = 1,
                    Brand = "HP",// марка
                    CPUType = "Intel Core i5",// тип процессора
                    CPUFrequencyGHz = 2.5,// частота  работы  процессора
                    RAMSizeGB = 8,// объем оперативной памяти
                    HDDSizeGB = 1000, // объем жесткого диска
                    GPUMemoryGB = 2, // объемом памяти видеокарты
                    Price = 55000,// стоимость компьютера в условных единицах
                    Quantity = 5 // количеством экземпляров
                },
                new Computer
                {
                    Code = 2,
                    Brand = "Dell",
                    CPUType = "Intel Core i5",
                    CPUFrequencyGHz = 3.2,
                    RAMSizeGB = 16,
                    HDDSizeGB = 2000,
                    GPUMemoryGB = 4,
                    Price = 78000,
                    Quantity = 3
                },
                new Computer
                {
                    Code = 3,
                    Brand = "Lenovo",
                    CPUType = "AMD Ryzen 5",
                    CPUFrequencyGHz = 3.6,
                    RAMSizeGB = 12,
                    HDDSizeGB = 500,
                    GPUMemoryGB = 3,
                    Price = 62000,
                    Quantity = 7
                },
                new Computer
                {
                    Code = 4,
                    Brand = "Asus",
                    CPUType = "Intel Core i3",
                    CPUFrequencyGHz = 2.0,
                    RAMSizeGB = 4,
                    HDDSizeGB = 500,
                    GPUMemoryGB = 1,
                    Price = 35000,
                    Quantity = 10
                },
                new Computer
                {
                    Code = 5,
                    Brand = "Acer",
                    CPUType = "AMD Ryzen 7",
                    CPUFrequencyGHz = 3.8,
                    RAMSizeGB = 32,
                    HDDSizeGB = 1000,
                    GPUMemoryGB = 8,
                    Price = 95000,
                    Quantity = 2
                },
                new Computer
                {
                    Code = 6,
                    Brand = "Apple",
                    CPUType = "Apple M1",
                    CPUFrequencyGHz = 3.2,
                    RAMSizeGB = 16,
                    HDDSizeGB = 512,
                    GPUMemoryGB = 8,
                    Price = 120000,
                    Quantity = 4
                },
                new Computer
                {
                    Code = 7,
                    Brand = "MSI",
                    CPUType = "Intel Core i9",
                    CPUFrequencyGHz = 4.5,
                    RAMSizeGB = 64,
                    HDDSizeGB = 2000,
                    GPUMemoryGB = 12,
                    Price = 150000,
                    Quantity = 1
                },
                new Computer
                {
                    Code = 8,
                    Brand = "Huawei",
                    CPUType = "Intel Core i5",
                    CPUFrequencyGHz = 2.8,
                    RAMSizeGB = 8,
                    HDDSizeGB = 1000,
                    GPUMemoryGB = 2,
                    Price = 58000,
                    Quantity = 30
                }

            };


            Console.WriteLine($"Введите тип процессора");
            string cPUType=Console.ReadLine();
            var CPUType= list.Where(computer => computer.CPUType == cPUType).ToList();
            Console.WriteLine($"Компьютеры с процессором {cPUType}");
            CPUType.ForEach(computer => Console.WriteLine($"{computer.Code}-{computer.CPUType}"));

            Console.WriteLine($"Введите объем озу");
            int rAMSizeGB = Convert.ToInt32(Console.ReadLine());
            var RAMSizeGB = list.Where(computer => computer.RAMSizeGB > rAMSizeGB).ToList();
            Console.WriteLine($"Компьютеры с озу более  {rAMSizeGB}");
            RAMSizeGB.ForEach(computer => Console.WriteLine($"{computer.Code}-{computer.RAMSizeGB}"));

            Console.WriteLine($"Отсортированный по цене список");
            var Price = list.OrderBy(computer => computer.Price).ToList();
            Price.ForEach(Console.WriteLine);

            Console.WriteLine($"Сгруппированный по типу процессора список");
            var groupCPUType =list.GroupBy(computer => computer.CPUType).ToList();
            foreach ( var group in groupCPUType )
            { Console.WriteLine($"ПРоцессор{group.Key}");
                foreach (var computer in group)
                {
                    Console.WriteLine(computer);
                }
            }


            Console.WriteLine($"Самый дорогой компьютер ");
            var maxfilter = list.OrderByDescending(computer => computer.Price).ToList();
            var maxprisecomputer = maxfilter.First();
            Console.WriteLine(maxprisecomputer);

            Console.WriteLine($"Самый дешевый компьютер ");       
            var minfrisecomputer = Price.First();
            Console.WriteLine(minfrisecomputer);

            Console.WriteLine($"Есть ли компьютер в количестве 30 штук? ");
            bool Computer30=list.Any(computer => computer.Quantity > 29);
            Console.WriteLine(Computer30);

        }
    }
    public class Computer
    {
        public int Code { get; set; }
        public string Brand { get; set; }
        public string CPUType { get; set; }
        public double CPUFrequencyGHz { get; set; }
        public int RAMSizeGB { get; set; }
        public int HDDSizeGB { get; set; }
        public int GPUMemoryGB { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        public override string ToString()
        {
            return $"Код: {Code}, Марка: {Brand}, Процессор: {CPUType} ({CPUFrequencyGHz} GHz), " +
                   $"ОЗУ: {RAMSizeGB} GB, HDD: {HDDSizeGB} GB, Видеокарта: {GPUMemoryGB} GB, " +
                   $"Цена: {Price} у.е., Количество: {Quantity}";
        }
    }
}
