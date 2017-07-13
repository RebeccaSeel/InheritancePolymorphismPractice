using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePolymorphismPractice
{
    class Aircraft : Vehicle
    {
        private double altitude;

        public double Altitude { get; } //pilot needs to see altitude, set to 0
        //constructor
        public Aircraft()
        {

        } 

        public Aircraft(int seats, int carryingCapacity, string color, double movementSpeed)
        {
            this.seats = seats;
            this.carryingCapacity = carryingCapacity;
            this.color = color;
            this.movementSpeed = movementSpeed;

            altitude = 0.00d; //set here in the contructor rather than in the fields at top
        }

        //method
        public override void Move()
        {
            altitude += 10000.0d;
            base.Move();                //base = keep the base or original but add something to it
        }

        public override string GetDistanceTraveled()
        {
            return "Altitude: " + altitude + "-" + base.GetDistanceTraveled();
        }
    }
}
