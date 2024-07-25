using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1.src.DesignPatterns.Structural.Facade.GoodExample
{
    public class Inventory
    {
        public bool CheckInventory(string itemId)
        {
            return true; // just return true to keep example simple
        }

        public void ReduceInventory(string itemId, int amount)
        {
            System.Console.WriteLine("Reducing inventory of " + itemId + " by " + amount);
        }
    }
}