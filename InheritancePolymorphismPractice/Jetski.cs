using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePolymorphismPractice
{
    class Jetski : Boat
    {
        //can't do anything here because Boat doesn't have public fields, virtual methods, etc.
        //needs protected fields in Boat for this class to be operational
        //can create new versions of the fields, etc. from the grandparent class ex. vehicle
    }
}
