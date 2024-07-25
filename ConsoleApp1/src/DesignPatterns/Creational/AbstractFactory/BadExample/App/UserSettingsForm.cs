using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConsoleApp1.src.DesignPatterns.Creational.AbstractFactory.BadExample.Mac;
using ConsoleApp1.src.DesignPatterns.Creational.AbstractFactory.BadExample.Windows;

namespace ConsoleApp1.src.DesignPatterns.Creational.AbstractFactory.BadExample.App
{
    // /App/UserSettingsForm.cs
    public class UserSettingsForm
    {
        public void Render(OperatingSystemType os)
        {
            // PROBLEM: open-closed principle violated: if add new OS, we have to modify this class
            if (os == OperatingSystemType.Windows)
            {
                // PROBLEM: too easy to make mistake -- e.g. easy to accidentally render a Mac button here.
                new WindowsButton().Render();
                // PROBLEM: UserSettingsForm is tightly coupled to many concrete implementations of widgets.
                new WindowsCheckbox().Render();
            }
            else if (os == OperatingSystemType.Mac)
            {
                new MacButton().Render();
                new MacCheckbox().Render();
            }
        }
    }
}