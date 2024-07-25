using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConsoleApp1.src.DesignPatterns.Creational.Builder.GoodExample.Components;

namespace ConsoleApp1.src.DesignPatterns.Creational.Builder.GoodExample
{
    public class Director
    {
        public void ConstructSportsCar(IBuilder builder)
        {
            builder.SetCarType(CarType.Sports);
            builder.SetDashboard(new Dashboard(hasRevCounter: true));
            builder.SetEngine(new Engine());
            builder.SetSeats(2);
            builder.SetWheels(new Wheels(diameterInInches: 20));
        }

        public void ConstructSUV(IBuilder builder)
        {
            builder.SetCarType(CarType.SUV);
            builder.SetDashboard(new Dashboard(hasRevCounter: true));
            builder.SetEngine(new Engine());
            builder.SetGPSNavigator(new GPSNavigator());
            builder.SetSeats(5);
            builder.SetWheels(new Wheels(diameterInInches: 19));
        }
    }
}