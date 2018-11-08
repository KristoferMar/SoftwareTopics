using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareTopics.Interfaces
{
    class Vechicle : IDriveable
    {
        public string Brand { get; set; }

        public int Wheels { get; set; }
        public double Speed { get; set; }

        public Vechicle(string brand = "No Brand", int wheels = 0, double speed = 0)
        {
            Brand = brand;
            Wheels = wheels;
            Speed = speed;
        }

        public void Move()
        {
            Console.WriteLine($"The {Brand} Moves Forward at {Speed} MPH");
        }

        public void Stop()
        {
            Console.WriteLine($"The {Brand} Stops");
            Speed = 0;
        }
    }
}
