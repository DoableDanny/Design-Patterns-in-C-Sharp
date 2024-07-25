using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1.src.DesignPatterns.Behavioral.Observer.GoodExample
{
    public class Subject
    {
        private List<Observer> _observers = new List<Observer>();

        public void AddObserver(Observer observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(Observer observer)
        {
            _observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach (Observer observer in _observers)
            {
                observer.Update();
            }
        }
    }
}