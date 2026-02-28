using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.src.DesignPatterns.Behavioral.ChainOfResponsibility.MyTest
{
    public class Logger : Handler
    {
        public override bool DoHandle(HTTPRequest request)
        {
            Console.WriteLine("Logging");
            return false;
        }
    }
}
