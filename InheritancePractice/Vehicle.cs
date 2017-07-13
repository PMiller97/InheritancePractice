using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePractice
{
    class Vehicle
    {
        //fields
        protected int seats;
        protected int carryingCapacity;
        protected string color;
        protected double movmentSpeed;
        protected double distanceTraveled;

        private float gearRatio;
        private float engineSize;

        //properties
        public int Seats { get; } //prop + tab + tab
        public int CarryingCapacity { get; }
        public string Color { get; set; }
        public double DistanceTraveled { get; set; }

        //constructors
        public Vehicle() //ctor + tab + tab
        {

        }

        public Vehicle(int seats, int carryingCapacity, string color, double movementSpeed)
        {
            this.seats = seats;
            this.carryingCapacity = carryingCapacity;
            this.color = color;
            this.movmentSpeed = movmentSpeed;

            distanceTraveled = 0.0d;
        }
        public virtual void Move()
        {
            distanceTraveled += movmentSpeed;
        }

        public virtual string GetDistanceTraveled()
        {
            return "Distance Traveled:" + distanceTraveled + "\n";
        }







    }







}

    

