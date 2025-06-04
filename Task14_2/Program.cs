using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Task14_2;

namespace Task14_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SmartHomeSystem Light1 = new Light("Светильник потолочный", 1, false, "Состояние светильника");

            SmartHomeSystem Door1 = new Door("Дверь входная", 2, true, "Состояние двери");
            void StateChangedDevice(SmartHomeSystem type, string description, DateTime time)
            { Console.WriteLine($"{type.Name} {description} в {time}"); }

            Light1.DeviceStateChanged += StateChangedDevice;
            Door1.DeviceStateChanged += StateChangedDevice;
            Light1.On();
            Door1.Off();
        }
    }
    public delegate void StateChanged(SmartHomeSystem type, string description, DateTime time);
    public abstract class SmartHomeSystem
    {

        public int Id;
        public bool State { get; set; }
        public event StateChanged DeviceStateChanged;
        public string Name { get; set; }
        public abstract string description { get;  }
        public void On()
        {
            if (State == false)
            {
                State = true;
                DeviceStateChanged?.Invoke(this, description, DateTime.Now);
            }


        }
        public void Off()
        {
            if (State == true)
            {
                State = false;
                DeviceStateChanged?.Invoke(this, description, DateTime.Now);
            }
        }

        public SmartHomeSystem(string name, int id, bool state, string _description)
        {
            Name = name;
            Id = id;
            State = state;
          
        }

    }
    public class Light : SmartHomeSystem
    {
        public override string description => State?"Включен" :"Выключен";
        public Light(string name, int id, bool state, string description) : base(name, id, state, description)
        {

        }      
    }
    public class Door: SmartHomeSystem
    {
        public override string description => State ? "Открыта" : "Закрыта";
        public Door(string name, int id, bool state, string description) : base(name, id, state, description)
        {

        }
    }

}









