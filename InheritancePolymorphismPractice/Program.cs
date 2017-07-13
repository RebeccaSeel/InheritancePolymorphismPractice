using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePolymorphismPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //create instance of our boat
            Boat boat1 = new Boat(2, 500, "White and Yellow", 70.0d, .78); //hover over new Boat for structure
            boat1.Move(); //move the boat
            boat1.Move(); //move the boat again
            Console.WriteLine("Boat " + boat1.GetDistanceTraveled()); //prints Boat Distance Traveled: 109.2


        }
    }
}
