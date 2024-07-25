using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1.src.DesignPatterns.Behavioral.Visitor.BadExample
{
    public class Restaurant : Client
    {
        public Restaurant(string name, string email) : base(name, email)
        {
        }

        public override void SendEmail()
        {
            System.Console.WriteLine("Sending restaurant marketing tips email to " + _email);
        }
    }
}

