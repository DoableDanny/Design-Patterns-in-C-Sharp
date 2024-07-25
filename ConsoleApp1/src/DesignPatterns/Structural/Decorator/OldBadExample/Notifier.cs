using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1.src.DesignPatterns.Structural.Decorator.OldBadExample
{
    public class Notifier
    {
        public virtual void Send(int userId, string message)
        {
            System.Console.WriteLine("Sending email to " + userId + " with message " + message);
        }
    }
}