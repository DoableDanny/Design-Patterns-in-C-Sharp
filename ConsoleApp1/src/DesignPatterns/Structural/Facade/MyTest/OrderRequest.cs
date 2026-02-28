using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.src.DesignPatterns.Structural.Facade.MyTest
{
    public class OrderRequest
    {
        public string Name { get; } = "Leif";
        public string CardNumber { get; } = "12345";
        public float Amount { get; } = 20.99f;
        public string Address { get; } = "Danmarksgade 4, Vejle";
        // item ids user wants to order
        public string[] ItemIds { get; } = { "123", "423", "555", "989" };
    }
}

