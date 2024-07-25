using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1.src.DesignPatterns.Behavioral.Visitor.GoodExample
{
    public class PDFExportVisitor : Visitor
    {
        public void VisitLaw(Law law)
        {
            System.Console.WriteLine("Exporting law client as PDF.");
        }

        public void VisitRestaurant(Restaurant restaurant)
        {
            System.Console.WriteLine("Exporting restaurant client as PDF.");
        }

        public void VisitRetail(Retail retail)
        {
            System.Console.WriteLine("Exporting retail client as PDF.");
        }
    }
}