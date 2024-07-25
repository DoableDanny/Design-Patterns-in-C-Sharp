using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1.src.DesignPatterns.Structural.Decorator.OldBadExample
{
    public class SMSAndFacebookNotifier : Notifier
    {
        public override void Send(int userId, string message)
        {
            System.Console.WriteLine("Sending SMS to " + userId + " with message " + message);
            System.Console.WriteLine("Sending FB message to " + userId + " with message " + message);
            base.Send(userId, message);
        }
    }
}