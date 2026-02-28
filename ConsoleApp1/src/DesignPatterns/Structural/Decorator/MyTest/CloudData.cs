using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.src.DesignPatterns.Structural.Decorator.MyTest
{
    public class CloudData : IData
    {
        private string _url;

        public CloudData(string url)
        {
            _url = url;
        }
        public void SaveData(string data)
        {
            Console.WriteLine($"Saving data to the cloud: {data} using {_url} ");
        }
    }
}
