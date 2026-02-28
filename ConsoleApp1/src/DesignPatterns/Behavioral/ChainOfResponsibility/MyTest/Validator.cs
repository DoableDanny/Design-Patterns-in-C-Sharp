using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.src.DesignPatterns.Behavioral.ChainOfResponsibility.MyTest
{
    public class Validator : Handler
    {
        public override bool DoHandle(HTTPRequest request)
        {
            Console.WriteLine("Validating");
            var username = request.GetUsername();
            var password = request.GetPassword();

            request.ValidatedUsername = username.Trim();
            request.ValidatedPassword = password.Trim();

            return request.ValidatedUsername == "" || request.ValidatedPassword == "";
        }
    }
}
