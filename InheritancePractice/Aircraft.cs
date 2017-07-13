using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePractice
{
    class Aircraft : Vehicle
    {
        private double altitude;

        public double Altitude { get; }

        public Aircraft()
        {
            //default
        }

        public Aircraft(int seats, int carryCapacity, string color, double movmentSpeed)
        {
            this.seats = seats;
            this.carryingCapacity = carryingCapacity;
            this.color = color;
            this.movmentSpeed = movmentSpeed;
            altitude = 0.0d;
        }

        public override void Move()
        {
            altitude += 10000.0d;
            base.Move();
        }

        public override string GetDistanceTraveled()
        {
            return "Altitude " + altitude + "-" + base.GetDistanceTraveled();
        }

    }
}
