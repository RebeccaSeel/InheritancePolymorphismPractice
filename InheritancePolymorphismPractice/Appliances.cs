using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePolymorphismPractice
{
    abstract class Appliances //used as a template , abstraction is a template for classes, use this to get around multiple inheritances
    {
        public abstract void Clean(); //don't give a body for an abstract method 
        //only used for methods, not fields or properties
        //you know there are these methods, but may not know what the method specifically will do in the program

    }
}
