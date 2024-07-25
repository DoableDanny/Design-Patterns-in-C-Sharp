using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1.src.DesignPatterns.Behavioral.Memento.BadExample
{
public class Editor
{

    private string _content = "";
    private List<string> _prevContents = new List<string>();

    private string _title = "";
    private List<string> _prevTitles = new List<string>();


    public string GetContent()
    {
        return _content;
    }

    public void SetContent(string content)
    {
        _prevContents.Add(_content);
        _content = content;
    }

    public string GetTitle()
    {
        return _title;
    }

    public void SetTitle(string title)
    {
        _prevTitles.Add(_title);
        _title = title;
    }

    public void Undo()
    {
        UndoContent();
        UndoTitle();
    }

public void UndoContent()
{
    var lastContent = _prevContents.Last();
    _prevContents.Remove(lastContent);
    _content = lastContent;
}

public void UndoTitle()
{
    var lastTitle = _prevTitles.Last();
    _prevTitles.Remove(lastTitle);
    _title = lastTitle;
}

}
}