using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1.src.DesignPatterns.Behavioral.Command.UndoableCommandPattern
{
    // This is where we implement our business logic. This class knows nothing about commands.
    // This is part of the "business layer" of an application.
    // Commands are the link between user interface object, and business objects.
    public class HtmlDocument
    {
        public string Content { get; set; }

        public void MakeItalic()
        {
            Content = "<i>" + Content + "</i>"; // business logic -- HtmlDocument knows how to make itself bold
        }
    }
}