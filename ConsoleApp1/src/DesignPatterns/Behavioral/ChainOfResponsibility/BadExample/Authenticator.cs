using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1.src.DesignPatterns.Behavioral.ChainOfResponsibility.BadExample
{
    public class Authenticator
    {
        public bool Authenticate(HttpRequest request)
        {
            var username = request.GetUsername();
            var password = request.GetPassword();

            return username == "danny" && password == "123";
        }
    }
}