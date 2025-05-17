using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Building building1 = new Building("Рябиновая 20", 10, 1989);
            MultiBuilding multiBuilding1 = new MultiBuilding("Рябиновая 30", 60, 1987, 4, true);
            Building building2 = multiBuilding1;
            //MultiBuilding house4 = (MultiBuilding)house1;
            if (building1 is MultiBuilding)
            {
                MultiBuilding multiBuilding2 = (MultiBuilding)building1;
                Console.WriteLine($"после даункастинга{multiBuilding2.CalculateTax()}");
            }
            else { Console.WriteLine($"Ошибка {nameof(building1)} не {nameof(MultiBuilding)} "); };
            Console.WriteLine($"Налог на {nameof(building1)} сорставит {building1.CalculateTax()}");
            Console.WriteLine($"Налог на {nameof(multiBuilding1)} сорставит {multiBuilding1.CalculateTax()}");

            building1.DisplayInfo();
            multiBuilding1.DisplayInfo();
            



        }
    }

    public class Building
    {
        protected string _address;
        protected double _area;
        protected int _yearBuilt;
        public int BuildingAge
        {
            get { return DateTime.Now.Year - _yearBuilt; }
        }

        public Building(string address, double area, int yearBuilt)
        {
            _address = address;
            _area = area;
            _yearBuilt = yearBuilt;
        }
        public virtual double CalculateTax()
        {
            double Tax = _area * 1000;
            return Tax;
        }
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"{_address} {_area} {_yearBuilt}");
        }
    }
    public class MultiBuilding : Building
    {
        private int _floors;
        private bool _hasElevator;

        public MultiBuilding(string address, double area, int yearBuilt, int floors, bool hasElevator) :
        base(address, area, yearBuilt)
        {
            _floors = floors;
            _hasElevator = hasElevator;
        }
        public override double CalculateTax()
        {
            double Tax = 0;

            if (_hasElevator)
            {
                Tax = (_area * 1000) * (1 + (_floors - 1) * 0.05) + 1;
            }
            else
            {
                Tax = (_area * 1000) * (1 + (_floors - 1) * 0.05);
            }
            return (Tax);
        }
        public override void DisplayInfo()
        {
            Console.WriteLine($"{_address}, {_area}, {_yearBuilt},{_floors},{_hasElevator}");
        }


    }

}
