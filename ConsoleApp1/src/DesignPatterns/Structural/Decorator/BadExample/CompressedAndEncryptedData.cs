using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1.src.DesignPatterns.Structural.Decorator.BadExample
{
    public class CompressedAndEncryptedData : CloudData
    {
        public CompressedAndEncryptedData(string url) : base(url)
        {
        }

        public override void Save(string data)
        {
            var compressed = new CompressedData(base._url).Compress(data);
            var encryptedAndComressed = new EncryptedData(base._url).Encrypt(compressed);
            base.Save(encryptedAndComressed);
        }
    }
}