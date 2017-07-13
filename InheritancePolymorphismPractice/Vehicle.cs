using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePolymorphismPractice
{
    class Vehicle
    {
        //vehicle is base class
        //fields = protected can be inherited and changed
        protected int seats;
        protected int carryingCapacity;
        protected string color;
        protected double movementSpeed;
        protected double distanceTraveled;

        private float gearRatio; //Main doesn't have access to this field because it is private, only this class can access it
        private float engineSize; //Main doesn't have access to this field because it is private, only this class can access it

        //properties (type prop and tab twice for setup)
        public int Seats { get; } //this will be locked in
        public int CarryingCapacity { get; }
        public string Color { get; set; }
        public double DistanceTraveled { get; }

        //constructors (type ctor tab twice to see format)
        public Vehicle()
        {

        }

        public Vehicle(int seats, int carryingCapacity, string color, double movementSpeed)
        {
            this.seats = seats;
            this.carryingCapacity = carryingCapacity;
            this.color = color;
            this.movementSpeed = movementSpeed;

            distanceTraveled = 0.0d; //so it doesn't start moving immediately
        }

        //create methods
        public virtual void Move() //virtual keyword = whoever inherits from this class can override this method
        {
            distanceTraveled += movementSpeed;
        }

        public virtual string GetDistanceTraveled()
        {
            return "Distance Traveled: " + distanceTraveled + "\n";
        }



    }
}
