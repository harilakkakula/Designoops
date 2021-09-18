using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMethod
{
    class Vehicae
    {
        public double distance = 0.0;
        public double hour = 0.0;
        public double fuel = 0.0;

        public Vehicae(double distance,double hour,double fuel)
        {
            this.distance = distance;
            this.hour = hour;
            this.fuel = fuel;
        }

        public void Avegrage()
        {
            double average = 0.0;
            average = distance / fuel;
            Console.WriteLine($"the vehicle Average is {average}");
        }

        public virtual void speed(){ Console.WriteLine($"the Vehicle speed is {distance/hour}");}

    }
}
