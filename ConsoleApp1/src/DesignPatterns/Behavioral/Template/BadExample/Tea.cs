using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1.src.DesignPatterns.Behavioral.Template.BadExample
{
    public class Tea
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
            System.Console.WriteLine("Brewing tea for 3 minutes");
        }

        private void AddCondiments()
        {
            if (CustomerWantsCondiments())
                System.Console.WriteLine("Adding lemon to tea");
        }

        private bool CustomerWantsCondiments()
        {
            Console.WriteLine("Would you like lemon with your tea? (y/n)");
            string input = Console.ReadLine();
            return input.ToLower() == "y";
        }
    }
}