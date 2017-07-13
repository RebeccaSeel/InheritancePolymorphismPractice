using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePolymorphismPractice
{
    class Boat : Vehicle //this is the syntax for inheritance
    {
        private double waterDrag;

        //constructor
        public Boat (int seats, int carryingCapacity, string color, double movementSpeed, double waterDrag) //inherited plus waterDrag
        {
            this.seats = seats;
            this.carryingCapacity = carryingCapacity;
            this.color = color;
            this.movementSpeed = movementSpeed;
            this.waterDrag = waterDrag;
        }

        public override void Move() //this is overriding the Move method in Vehicle
        {
            distanceTraveled += movementSpeed * waterDrag; //the override is adding waterDrag for boat
        }
    }
}
