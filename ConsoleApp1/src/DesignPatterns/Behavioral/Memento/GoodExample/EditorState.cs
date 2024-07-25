using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace ConsoleApp1.src.DesignPatterns.Behavioral.Memento.GoodExample
{
// Memento
public class EditorState
{
    // Editor state data:
    // `readonly` so once created we cannot change it, adding robustness to our code.
    private readonly string _title;
    private readonly string _content;

    // State meta data:
    private readonly DateTime _stateCreatedAt;


    public EditorState(string title, string content)
    {
        _title = title;
        _content = content;
        _stateCreatedAt = DateTime.Now;
    }

    public string GetTitle()
    {
        return _title;
    }

    public string GetContent()
    {
        return _content;
    }

    // The rest of the methods are used by the CareTaker (History) to display meta data:
    public DateTime GetDate()
    {
        return _stateCreatedAt;
    }

    public string GetName()
    {
        // return $"{_stateCreatedAt} / ({_title.Substring(0, 9)})...";
        return $"{_stateCreatedAt} / ({_title})";
    }
}
}