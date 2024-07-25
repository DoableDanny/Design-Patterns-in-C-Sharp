using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1.src.DesignPatterns.Behavioral.Visitor.GoodExample
{
    public class Law : Client
    {
        public Law(string name, string email) : base(name, email)
        {
        }

        public override void Accept(Visitor visitor)
        {
            visitor.VisitLaw(this);
        }
    }
}