using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConsoleApp1.src.DesignPatterns.Creational.Builder.GoodExample.Components;

namespace ConsoleApp1.src.DesignPatterns.Creational.Builder.GoodExample
{
    public class Manual
    {
        public CarType Type { get; set; }
        public int Seats { get; set; }
        public bool isConvertible { get; set; }
        public Engine Engine { get; set; }
        public Dashboard Dashboard { get; set; }
        public Wheels Wheels { get; set; }
        public GPSNavigator GpsNavigator { get; set; }

        public string Print()
        {
            var text = "";

            text += "Car type: " + Type + "\n";
            text += "Seats: " + Seats + "\n";
            text += "Wheels: diameter in inches = " + Wheels.GetDiameterInInches() + "\n";
            text += "Engine: info on engine... \n";
            text += "GPS Navigator: ";
            if (GpsNavigator != null)
            {
                text += "Info on gps... \n";
            }
            else
            {
                text += "N/A \n";
            }

            return text;
        }
    }
}