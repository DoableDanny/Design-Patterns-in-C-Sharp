using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1.src.DesignPatterns.Structural.Decorator.BadExample
{
    public class EncryptedData : CloudData
    {
        public EncryptedData(string url) : base(url)
        {
        }

        public override void Save(string data)
        {
            var encrypted = Encrypt(data);
            base.Save(encrypted);
        }

        public string Encrypt(string data)
        {
            return "$dc&^*()';,,£@%%*(~)`"; // pretend to encrypt data
        }
    }
}