using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMethod
{
    class Bike : Vehicae
    {
        public Bike(double distance,double hour,double fuel):base(distance,hour,fuel)
        {

        }

        public void Avegrage()
        {
            Console.WriteLine($"This is Bike so , my Avg is 20+{distance - 5 / fuel}");
        }
        public override void speed()
        {
            Console.WriteLine($"this bike , im going inside of Street in quick ,{distance - 7 / hour}");
        }

    }
}
