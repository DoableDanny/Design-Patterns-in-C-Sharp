using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1.src.DesignPatterns.Behavioral.Visitor.BadExample
{
    public abstract class Client
    {
        protected string _name;
        protected string _email;

        public Client(string name, string email)
        {
            _name = name;
            _email = email;
        }

        public abstract void SendEmail();
    }
}