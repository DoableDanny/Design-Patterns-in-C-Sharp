using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1.src.DesignPatterns.Creational.AbstractFactory.GoodExample
{
    public interface IUIComponentFactory
    {
        IButton CreateButton();
        ICheckbox CreateCheckbox();
    }
}