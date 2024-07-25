using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1.src.DesignPatterns.Structural.Decorator.BadExample
{
    public class CloudData
    {
        protected string _url;

        public CloudData(string url)
        {
            _url = url;
        }

        public virtual void Save(string data)
        {
            System.Console.WriteLine($"Saving data '{data}' to cloud at '{_url}'");
        }
    }
}