using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1.src.DesignPatterns.Behavioral.Template.BadExample
{
    public class Coffee
    {
        public void MakeBeverage()
        {
            BoilWater();
            PourWaterIntoCup();
            Brew();
            AddCondiments();
        }

        private void BoilWater()
        {
            System.Console.WriteLine("Boiling water");
        }

        private void PourWaterIntoCup()
        {
            System.Console.WriteLine("Pouring water into cup");
        }

        private void Brew()
        {
            System.Console.WriteLine("Brewing coffee for 5 minutes");
        }

        private void AddCondiments()
        {
            if (CustomerWantsCondiments())
                System.Console.WriteLine("Adding cream to coffee");
        }

        private bool CustomerWantsCondiments()
        {
            Console.WriteLine("Would you like cream with your coffee? (y/n)");
            string input = Console.ReadLine();
            return input.ToLower() == "y";
        }
    }
}