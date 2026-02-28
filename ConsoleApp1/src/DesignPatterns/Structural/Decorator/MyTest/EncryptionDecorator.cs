using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.src.DesignPatterns.Structural.Decorator.MyTest
{
    public class EncryptionDecorator:DataDecorator
    {
        public EncryptionDecorator(IData data) : base(data)
        {
        }
        public override void SaveData(string data)
        {
            // Simulate encryption by just indicating that the data is encrypted
            var encryptedData = Encrypt(data);
            base._data.SaveData(encryptedData);
            Console.WriteLine("Encrypting data...");
        }
        public string Encrypt(string data)
        {
            // In a real implementation, you would have actual encryption logic here.
            return Convert.ToBase64String(Encoding.UTF8.GetBytes(data));
        }
    }
}
