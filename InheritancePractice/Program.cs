using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Boat boat1 = new Boat(2, 500, "White and Yellow", 70d, .78d);
            boat1.Move();
            boat1.Move();
            Console.WriteLine("Boat" + boat1.GetDistanceTraveled());
            




        }
    }
}
