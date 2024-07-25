using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1.src.DesignPatterns.Behavioral.State.GoodExample
{
    public class DraftState : State
    {
        private Document _document;

        public DraftState(Document document)
        {
            _document = document;
        }

        public void Publish()
        {
            _document.State = new ModerationState(_document);
        }
    }
}