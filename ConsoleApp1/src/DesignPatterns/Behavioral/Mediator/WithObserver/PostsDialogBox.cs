using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConsoleApp1.src.DesignPatterns.Behavioral.Mediator.WithObserver.UIFramework;


namespace ConsoleApp1.src.DesignPatterns.Behavioral.Mediator.WithObserver
{
    // The Concrete Observer class
    public class PostsDialogBox
    {
        // declare fields for UI components
        private ListBox _postsListBox;
        private TextBox _titleTextBox;
        private Button _saveButton;

        public PostsDialogBox()
        {
            // assign ui components
            _postsListBox = new ListBox();
            _titleTextBox = new TextBox();
            _saveButton = new Button();

            // add event handler methods to each ui component
            _postsListBox.AddEventHandler(PostSelected);
            _titleTextBox.AddEventHandler(TitleChanged);
        }

        public void SimulateUserInteraction()
        {
            _postsListBox.SetSelection("Post 2");
            // _titleTextBox.SetText("");
            System.Console.WriteLine("Title text box: " + _titleTextBox.GetText());
            System.Console.WriteLine("Button enabled: " + _saveButton.IsEnabled());
        }

        // event handler methods:
        private void PostSelected()
        {
            _titleTextBox.SetText(_postsListBox.GetSelection());
            _saveButton.SetEnabled(true);
        }

        private void TitleChanged()
        {
            var isTitleEmpty = _titleTextBox.GetText() == "";
            _saveButton.SetEnabled(!isTitleEmpty);
        }
    }
}