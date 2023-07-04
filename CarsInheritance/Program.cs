using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("Red", "Opel", "Astra", "454");

            

            car1.Accelerate(20);
            Console.WriteLine("------");
            car1.Accelerate(30);
            Console.WriteLine("------");
            car1.Accelerate(35);

        }
    }
}
