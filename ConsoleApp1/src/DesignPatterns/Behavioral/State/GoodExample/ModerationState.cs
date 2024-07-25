using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConsoleApp1.SOLID.S.BadExample;

namespace ConsoleApp1.src.DesignPatterns.Behavioral.State.GoodExample
{
    public class ModerationState : State
    {
        private Document _document;

        public ModerationState(Document document)
        {
            _document = document;
        }

        public void Publish()
        {
            if (_document.CurrentUserRole == UserRoles.ADMIN)
            {
                _document.State = new PublishedState(_document);
            }
        }
    }
}