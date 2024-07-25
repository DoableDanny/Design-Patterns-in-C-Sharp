using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1.src.DesignPatterns.Structural.Decorator.GoodExample
{
    public class EncryptionDecorator : DataDecorator
    {
        public EncryptionDecorator(Data data) : base(data)
        {
        }

        public override void Save(string data)
        {
            System.Console.WriteLine("Encryping data");
            var encrypted = Encrypt(data);
            base._data.Save(encrypted);
        }

        // This can now be private, encapsulating this code
        private string Encrypt(string data)
        {
            return "$dc&^*()';,,£@%%*(~)`"; // pretend to encrypt data
        }
    }
}