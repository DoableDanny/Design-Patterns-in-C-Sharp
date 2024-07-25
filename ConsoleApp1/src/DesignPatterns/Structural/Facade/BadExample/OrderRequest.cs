using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1.src.DesignPatterns.Structural.Facade.BadExample
{
    // Request object containing user-submitted data
    public class OrderRequest
    {
        public string Name { get; } = "danny";
        public string CardNumber { get; } = "1234";
        public float Amount { get; } = 20.99f;
        public string Address { get; } = "123 Springfield Way, Texas";
        // item ids user wants to order
        public string[] ItemIds { get; } = { "123", "423", "555", "989" };
    }
}