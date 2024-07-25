using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConsoleApp1.src.DesignPatterns.Creational.Builder.GoodExample.Components;

namespace ConsoleApp1.src.DesignPatterns.Creational.Builder.GoodExample
{
    public class Car
    {
        public CarType Type { get; set; }
        public int Seats { get; set; }
        public bool isConvertible { get; set; }
        public Engine Engine { get; set; }
        public Dashboard Dashboard { get; set; }
        public Wheels Wheels { get; set; }
        public GPSNavigator GpsNavigator { get; set; }

        // Fields specific to this class:
        public double Fuel { get; set; }
    }
}