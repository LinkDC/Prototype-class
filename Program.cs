
using System;

namespace method // Note: actual namespace depends on the project name.
{
    internal class Program
    {


        static void Main(string[] args)
        {
            Car mers = new Car();
            Car gaz = new Car("Газель", 300);
            gaz.PrintInfo();
            gaz.Move(50);
            gaz.PrintInfo();
        }

    }
}