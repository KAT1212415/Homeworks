using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HW11_2.Bird;

namespace HW11_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IFlyable[] flyables = new IFlyable[]
                { new Bird(4),
                  new Bird(100),
                  new Airplane(150, 5),
                  new Airplane(200, 10),

               };
            foreach (var flyabl in flyables)
            {
                flyabl.Fly();
            }


        }




    }
    public interface IFlyable
    {
      void Fly();
      int MaxAltitude { get; }
    }
    public class Bird : IFlyable
    {

        public int MaxAltitude { get; }
        public void Fly()

        {
            Console.WriteLine($"Лечу на высоте {MaxAltitude} метров");
        }

        public Bird(int maxAltitude)
        {
            MaxAltitude = maxAltitude;
        }
        public class Airplane : IFlyable
        {
            public int CountPassengers { get; }
            public int MaxAltitude { get; }
            public Airplane(int maxAltitude, int countPassengers)
            {
                MaxAltitude = maxAltitude;
                CountPassengers = countPassengers;

            }
            public void Fly()

            {
                Console.WriteLine($"Лечу на высоте {MaxAltitude} метров. Везу {CountPassengers} пассажиров");
            }
        }

    }

}   


