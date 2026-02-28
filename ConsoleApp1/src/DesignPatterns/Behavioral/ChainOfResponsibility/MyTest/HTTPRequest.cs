using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.src.DesignPatterns.Behavioral.ChainOfResponsibility.MyTest
{
    public class HTTPRequest
    {
        private string _username;
        private string _password;
        public string ValidatedUsername { get; set; } = "";
        public string ValidatedPassword { get; set; } = "";


        public HTTPRequest(string username, string password)
        {
            _username = username;
            _password = password;
        }

        public string GetUsername()
        {
            return _username;
        }

        public string GetPassword()
        {
            return _password;
        }
    }
}
