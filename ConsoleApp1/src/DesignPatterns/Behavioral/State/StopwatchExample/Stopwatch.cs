using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1.src.DesignPatterns.Behavioral.State.StopwatchExample
{
    public class Stopwatch
    {
        private bool IsRunning { get; set; } = false;

        public void click()
        {
            if (IsRunning)
            {
                IsRunning = false;
                System.Console.WriteLine("Stopped");
            }
            else
            {
                IsRunning = true;
                System.Console.WriteLine("Running");
            }
        }
    }
}