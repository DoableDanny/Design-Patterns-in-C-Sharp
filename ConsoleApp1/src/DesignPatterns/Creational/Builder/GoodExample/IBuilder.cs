using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConsoleApp1.src.DesignPatterns.Creational.Builder.GoodExample.Components;

namespace ConsoleApp1.src.DesignPatterns.Creational.Builder.GoodExample
{
    public interface IBuilder
    {
        void Reset();
        IBuilder SetCarType(CarType type);
        IBuilder SetSeats(int seats);
        IBuilder IsConvertible(bool isConvertible);
        IBuilder SetEngine(Engine engine);
        IBuilder SetWheels(Wheels wheels);
        IBuilder SetDashboard(Dashboard dashboard);
        IBuilder SetGPSNavigator(GPSNavigator gpsNavigator);
    }
}