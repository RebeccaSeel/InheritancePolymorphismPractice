using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePolymorphismPractice
{
    class Program
    {
        static void Main(string[] args) //this is where the app/program is run from because it is the Main
        {
            //create instance of our boat
            Boat boat1 = new Boat(2, 500, "White and Yellow", 70.0d, .78); //hover over new Boat for structure
            boat1.Move(); //move the boat
            boat1.Move(); //move the boat again
            Console.WriteLine("Boat " + boat1.GetDistanceTraveled()); //prints Boat Distance Traveled: 109.2

            //create instance of automobile
            Automobile car1 = new Automobile(4, 20, 4, 5, 500, "Red", 260);
            car1.Move();

            car1.Color = "Gold";
            Console.WriteLine("Automobile " + car1.GetDistanceTraveled());

            //create instance of aircraft
            Aircraft plane1 = new Aircraft(100, 1000000, "Purple", 600);
            plane1.Move();
            plane1.Move();
            Console.WriteLine("Aircraft " + plane1.GetDistanceTraveled());

        }
    }
}
