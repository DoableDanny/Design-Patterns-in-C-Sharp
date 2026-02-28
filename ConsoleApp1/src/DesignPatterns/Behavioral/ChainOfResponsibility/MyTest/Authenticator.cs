using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.src.DesignPatterns.Behavioral.ChainOfResponsibility.MyTest
{
    public class Authenticator : Handler
    {
        public override bool DoHandle(HTTPRequest request)
        {
            Console.WriteLine("Authentication");
            var username = request.ValidatedUsername;
            var password = request.ValidatedPassword;

            //True if the user is not authenticated, false if the user is authenticated
            return !(username == "Leif" && password == "123"); 
        }
    }
}
