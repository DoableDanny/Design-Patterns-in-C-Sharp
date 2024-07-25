using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1.src.DesignPatterns.Behavioral.Visitor.GoodExample
{
    public class EmailVisitor : Visitor
    {
        public void VisitLaw(Law law)
        {
            System.Console.WriteLine("Sending law marketing tips email to " + law.GetEmail());
        }

        public void VisitRestaurant(Restaurant restaurant)
        {
            System.Console.WriteLine("Sending restaurant marketing tips email to " + restaurant.GetEmail());
        }

        public void VisitRetail(Retail retail)
        {
            System.Console.WriteLine("Sending retail marketing tips email to " + retail.GetEmail());
        }
    }
}