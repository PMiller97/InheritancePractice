using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePractice
{
    class Boat : Vehicle
    {
        private double waterDrag;

        public Boat(int seats, int carryingCapactiy, string color, double movmentSpeed, double waterDrag)
        {
            this.seats = seats;
            this.carryingCapacity = carryingCapacity;
            this.color = color;
            this.movmentSpeed = movmentSpeed;
            this.waterDrag = waterDrag;
        }

        public override void Move()
        {
            distanceTraveled += movmentSpeed * waterDrag; //+= is saying distance traveled is equal to DT + movement speed
        }











    }
}
