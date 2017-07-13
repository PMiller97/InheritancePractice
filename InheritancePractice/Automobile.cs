using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePractice
{
    class Automobile : Vehicle 
    {
        private int numberOfWheels;
        private float wheelSize;
        private int numberOfDoors;

        public int NumberOFWheels { get; }
        public float WheelSize { get; }
        public int NumberOfDoors { get; }

        public Automobile()
        {
              //this is my default constructor  
        }

        public Automobile(int numberOfWheels, float wheelSize, int numberOfDoors, int seats, int carryCapacity, string color, double movmentSpeed)
        {
            this.numberOfWheels = numberOfWheels;
            this.wheelSize = wheelSize;
            this.numberOfDoors = numberOfDoors;
            this.seats = seats;
            this.carryingCapacity = carryingCapacity;
            this.color = color;
            this.movmentSpeed = movmentSpeed;

        }
        


    }
}
