using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.src.DesignPatterns.Behavioral.ChainOfResponsibility.MyTest
{
    public abstract class Handler
    {
        private Handler? _nextHandler;       

        public Handler SetNext(Handler handler)
        {
            _nextHandler = handler;
            
            return handler; // Return the next handler to allow chaining
        }

        public void Handle(HTTPRequest request)
        {       
            if (DoHandle(request))
            {
                return;
            }
            if (_nextHandler != null)
            {
                _nextHandler.Handle(request);
            }
        }

        public abstract bool DoHandle(HTTPRequest request);
    }
}
