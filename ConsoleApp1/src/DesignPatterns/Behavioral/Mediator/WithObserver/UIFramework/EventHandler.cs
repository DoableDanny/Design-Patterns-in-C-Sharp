using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1.src.DesignPatterns.Behavioral.Mediator.WithObserver.UIFramework
{
    // This is akin to our "Observer" interface in the Observer Pattern.
    // In C#, we can use delegates to specify what an event handler, or "callback", function/method should look like. Here, we say that EventHandler methods should return void and receive no arguments.
    public delegate void EventHandler();
}