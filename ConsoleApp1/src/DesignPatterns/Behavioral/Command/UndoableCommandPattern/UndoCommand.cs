using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1.src.DesignPatterns.Behavioral.Command.UndoableCommandPattern
{
    public class UndoCommand : Command
    {
        private History _history;

        public UndoCommand(History history)
        {
            _history = history;
        }

        public void Execute()
        {
            if (_history.Size() > 0)
            {
                var lastCommand = _history.Pop(); // remove from history
                lastCommand.Unexecute(); // delegate the undo logic to the UndoableCommand object
            }
        }
    }
}