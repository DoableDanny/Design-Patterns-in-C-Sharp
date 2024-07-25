using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1.src.DesignPatterns.Structural.Decorator.GoodExample
{
    public class CompressionDecorator : DataDecorator
    {
        public CompressionDecorator(Data data) : base(data)
        {
        }

        public override void Save(string data)
        {
            System.Console.WriteLine("Compressing data");
            var compressed = Compress(data);
            base._data.Save(compressed);
        }

        private string Compress(string data)
        {
            return data.Substring(0, 9); // pretend to compress data
        }
    }
}