using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConsoleApp1.src.DesignPatterns.Creational.Builder.BadExample.Components;

namespace ConsoleApp1.src.DesignPatterns.Creational.Builder.BadExample
{
    public class Car
    {
        public CarType _type;
        public int _seats;
        public Engine _engine;
        public bool _isConvertible;
        public Dashboard _dashboard;
        public Wheels _wheels;
        public GPSNavigator _gpsNavigator;

        // Fields specific to this class:
        public double Fuel { get; set; }

        public Car(
            CarType type,
            int seats,
            bool isConvertible,
            Engine engine,
            Dashboard dashboard,
            Wheels wheels,
            GPSNavigator gpsNavigator
        )
        {
            _type = type;
            _seats = seats;
            _isConvertible = isConvertible;
            _engine = engine;
            _dashboard = dashboard;
            _wheels = wheels;
            _gpsNavigator = gpsNavigator;
        }
    }
}