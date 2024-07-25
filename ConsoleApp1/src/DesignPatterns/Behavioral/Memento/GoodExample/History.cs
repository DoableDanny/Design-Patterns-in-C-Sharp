using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1.src.DesignPatterns.Behavioral.Memento.GoodExample
{
    // Caretaker
    public class History
    {
        private List<EditorState> _states = new List<EditorState>();
        private Editor _editor;

        public History(Editor editor)
        {
            _editor = editor;
        }

        public void Backup()
        {
            _states.Add(_editor.CreateState());
        }

        public void Undo()
        {
            if (_states.Count == 0)
            {
                return;
            }

            EditorState prevState = _states.Last();
            _states.Remove(prevState);

            _editor.Restore(prevState);
        }

        public void ShowHistory()
        {
            Console.WriteLine("\nHistory: Here's the list of mementos:");

            foreach (var state in _states)
            {
                Console.WriteLine(state.GetName());
            }
        }
    }
}