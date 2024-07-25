using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConsoleApp1.src.DesignPatterns.Behavioral.Mediator.GoodExample.UIFramework;

namespace ConsoleApp1.src.DesignPatterns.Behavioral.Mediator.GoodExample
{
    public class PostsDialogBox : DialogBox
    {
        // fields for all ui components
        private ListBox _postsListBox;
        private TextBox _titleTextBox;
        private Button _saveButton;

        public PostsDialogBox()
        {
            _postsListBox = new ListBox(this);
            _titleTextBox = new TextBox(this);
            _saveButton = new Button(this);
            _saveButton.SetEnabled(false); // initially disabled
        }

        public void SimulateUserInteraction()
        {
            _postsListBox.SetSelection("Post 2");
            _titleTextBox.SetText(""); // add this line
            System.Console.WriteLine("Title text box: " + _titleTextBox.GetText());
            System.Console.WriteLine("Button enabled: " + _saveButton.IsEnabled());
        }

        public override void Changed(UIControl uiControl)
        {
            if (uiControl == _postsListBox)
            {
                handlePostChanged();
            }
            else if (uiControl == _titleTextBox)
            {
                handleTitleChanged();
            }
        }

        private void handlePostChanged()
        {
            _titleTextBox.SetText(_postsListBox.GetSelection());
            _saveButton.SetEnabled(true);
        }

        private void handleTitleChanged()
        {
            bool isTitleEmpty = _titleTextBox.GetText() == "";
            _saveButton.SetEnabled(!isTitleEmpty);
        }
    }
}