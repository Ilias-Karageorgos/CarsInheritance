using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsInheritance
{
    internal class Car
    {
        public string Colour { get; set; }

        public string Brand { get; }

        public string Model { get; }
        public Engine Engine { get; set; }

        private int speed;

        public int Speed
        {
            get { return speed; }
            set
            {
                {
                    if (value > 120)  //kai edo den leitourgei :(
                    {
                        Console.WriteLine("Speed must be up to 120 km/h");
                    }
                    else
                    {
                        speed = value;
                    }
                }
            }
        }

        public int CurrentSpeed { get; set; } = 0;

        public Car(string colour, string brand, string model, string engine)
        {
            this.Colour = colour;
            this.Brand = brand;
            this.Model = model;
            this.Engine = new Engine(engine); //THELO NA SE ROTISO PRAMATA EDO!
        }




        public void Accelerate(int Speed)
        {
            for (int i = CurrentSpeed + 1; i <= Speed; i++)
            {
                Console.WriteLine(i);
            }

            CurrentSpeed = Speed;
        }

        public void Stop()
        {
            Console.WriteLine("Car Stopped!");
            CurrentSpeed = 0;
        }

    }
}
