using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePolymorphismPractice
{
    class DishWasher : Appliances //Appliances is the abstract class
    {
        public override void Clean()
        {
            Console.WriteLine("I'm clean now"); //this is override, but you don't need to say virtual because there is nothing to inherit
        }
        //if there are muliple methods in Appliances, DishWasher must implement every one of the methods
    }
}
