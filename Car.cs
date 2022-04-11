using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method
{
    internal class Car
    {
        public string Name { get; set; }
        public int Fuel { get; set; }

        public List<int> Amount { get; set; }

        public Car()
        {
            Name = "Мошина";
            Fuel = 100;
            Amount = new List<int>();
        }
        public Car(string _name, int _fuel)
        {
            Name = _name;
            Fuel = _fuel;
            Amount = new List<int>();
        }

        public void PrintInfo()
        {
            Console.WriteLine(Name);
            Console.WriteLine(Fuel);
        }
        public void Move(int rass)
        {
            Fuel -= rass;
        }
    }
}
