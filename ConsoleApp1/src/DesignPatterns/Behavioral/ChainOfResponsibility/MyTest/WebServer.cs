using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.src.DesignPatterns.Behavioral.ChainOfResponsibility.MyTest
{
    public class WebServer
    {
        private Handler _handler;
        public WebServer(Handler handler)
        {
            _handler = handler;
        }

        public void Handle(HTTPRequest request)
        {
            _handler.Handle(request);
        }
    }
}
