using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// Composition involves creating complex objects by combining simpler objects or components. In composition, objects are assembled together to form larger structures, with each component object maintaining its own state and behavior. Composition is often described in terms of a "has-a" relationship.

namespace ConsoleApp1.src.OopPrinciples.Composition
{
    public class Chassis
    {
        public void Support()
        {
            Console.WriteLine("Chassis supporting the car");
        }
    }
}