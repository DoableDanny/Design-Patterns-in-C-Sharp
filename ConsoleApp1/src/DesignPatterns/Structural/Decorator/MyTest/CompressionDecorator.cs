using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.src.DesignPatterns.Structural.Decorator.MyTest
{
    public class CompressionDecorator :DataDecorator
    {
        public CompressionDecorator(IData data) : base(data)
        {
        }
        public override void SaveData(string data)
        {
            // Simulate compression by just indicating that the data is compressed
            var compressedData = Compress(data);
            base._data.SaveData(compressedData);
            Console.WriteLine("Compressing data...");
        }

        public string Compress(string data)
        {
            // In a real implementation, you would have actual compression logic here.
            return data.Substring(0,9);
        }
    }
}
