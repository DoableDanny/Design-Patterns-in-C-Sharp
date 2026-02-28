using ConsoleApp1.src.DesignPatterns.Behavioral.Mediator.MyTest.UIFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.src.DesignPatterns.Behavioral.Mediator.MyTest
{
    public class PostDialogBox
    {
        private ListBox _postListBox;
        private TextBox _titleTextBox;
        private Button _saveButton;

        public PostDialogBox()
        {
            _postListBox = new ListBox();
            _titleTextBox = new TextBox();
            _saveButton = new Button();
            _saveButton.SetEnabled(false);

            _postListBox.AddEventHandler(PostSelected);
            _titleTextBox.AddEventHandler(TitleChanged);
            _saveButton.Click += SaveButton_Clicked;
        }
       
        private void PostSelected()
        {
            _titleTextBox.SetText(_postListBox.GetSelection());
            _saveButton.SetEnabled(true);
        }

        private void TitleChanged() {
            bool isTitleEmpty = _titleTextBox.GetText() == "";
            _saveButton.SetEnabled(!isTitleEmpty);
        }

        private void SaveButton_Clicked()
        {
            _titleTextBox.SetText("");
            _saveButton.SetEnabled(false);
        }

        //Simulate action
        public void SimulateUserInteraction()
        {
            _postListBox.SetSelection("Post 2");
            // _titleTextBox.SetText("");
            System.Console.WriteLine("Title text box: " + _titleTextBox.GetText());
            System.Console.WriteLine("Button enabled: " + _saveButton.IsEnabled());
            System.Console.WriteLine("Clicking saveButton...");
            _saveButton.Click();
            System.Console.WriteLine("Button enabled: " + _saveButton.IsEnabled());
            System.Console.WriteLine("Title text box: " + _titleTextBox.GetText());
        }
    }
}
