using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMethod
{
    internal class Car : Vehicae
    {

        public Car(double distance,double hour,double fuel):base(distance,hour,fuel)
        {

        }
        public void Avegrage()
        {
            double average = 0.0;
            average = distance / fuel;
            Console.WriteLine($"the car Average is {average}");
        }
        public override void speed()
        {
            Console.WriteLine($"this car speed{distance / hour}");
        }

    }
}
