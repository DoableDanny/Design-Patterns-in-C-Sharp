
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1.src.DesignPatterns.Creational.AbstractFactory.GoodExample.App
{
    public class UserSettingsForm
    {
        // Polymorphism used here, so that this client requires no knowledge of specific uiComponentFactory.
        public void Render(IUIComponentFactory uiComponentFactory)
        {
            uiComponentFactory.CreateButton().Render();
            uiComponentFactory.CreateCheckbox().Render();
        }
    }
}