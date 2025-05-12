using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace HW11_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal[] animals = new Animal[]
            {

                new Dog("Лайка"),
                new Dog("Шарпей"),
                new Cat("Сибирская"),
                new Cat("Сиамская"),
            };
            foreach (var animal in animals)
            { animal.ShowInfo(); };



        }
    }
    public abstract class Animal
    {
        public abstract string _name { get; set; }
        public abstract void Say();
        public void ShowInfo()
            {
            Console.WriteLine($"{_name}");
            Say();
        }

    }
    public class Dog : Animal
    {
        public override string _name { get; set; }
        public override void Say()
        {
            Console.WriteLine("Гав");
        }
        public Dog(string name)
        { _name = name; }


    }
    public class Cat : Animal
    {
        public override string _name { get; set; }
        public override void Say()
        {
            Console.WriteLine("Мяу");
        }
        public Cat(string name)
        { _name = name; }
    }



}
