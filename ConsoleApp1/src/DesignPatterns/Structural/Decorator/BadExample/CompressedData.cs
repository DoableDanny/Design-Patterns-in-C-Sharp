using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1.src.DesignPatterns.Structural.Decorator.BadExample
{
    public class CompressedData : CloudData
    {
        public CompressedData(string url) : base(url)
        {
        }

        public override void Save(string data)
        {
            var compressed = Compress(data);
            base.Save(compressed);
        }

        public string Compress(string data)
        {
            return data.Substring(0, 9); // pretend to compress data
        }
    }
}