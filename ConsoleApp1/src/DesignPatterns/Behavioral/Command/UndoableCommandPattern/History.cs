using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1.src.DesignPatterns.Behavioral.Command.UndoableCommandPattern
{
    // Class to keep track of the commands that we've applied.
    public class History
    {
        private List<UndoableCommand> commands = new List<UndoableCommand>();

        public void Push(UndoableCommand command)
        {
            commands.Add(command);
        }

        public UndoableCommand Pop()
        {
            var last = commands.Last();
            commands.Remove(last);
            return last;
        }

        public int Size()
        {
            return commands.Count;
        }
    }
}