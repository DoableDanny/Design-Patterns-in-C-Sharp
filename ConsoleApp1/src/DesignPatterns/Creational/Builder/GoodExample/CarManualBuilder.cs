using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConsoleApp1.src.DesignPatterns.Creational.Builder.GoodExample.Components;

namespace ConsoleApp1.src.DesignPatterns.Creational.Builder.GoodExample
{
    public class CarManualBuilder : IBuilder
    {
        private Manual _manual;

        public CarManualBuilder()
        {
            Reset();
        }

        public void Reset()
        {
            _manual = new Manual();
        }

        public IBuilder SetCarType(CarType type)
        {
            _manual.Type = type;
            return this;
        }

        public IBuilder SetDashboard(Dashboard dashboard)
        {
            _manual.Dashboard = dashboard;
            return this;
        }

        public IBuilder SetEngine(Engine engine)
        {
            _manual.Engine = engine;
            return this;
        }

        public IBuilder SetGPSNavigator(GPSNavigator gpsNavigator)
        {
            _manual.GpsNavigator = gpsNavigator;
            return this;
        }

        public IBuilder SetSeats(int seats)
        {
            _manual.Seats = seats;
            return this;
        }

        public IBuilder IsConvertible(bool isConvertible)
        {
            _manual.isConvertible = isConvertible;
            return this;
        }

        public IBuilder SetWheels(Wheels wheels)
        {
            _manual.Wheels = wheels;
            return this;
        }

        public Manual GetManual()
        {
            var manual = _manual;
            Reset();
            return manual;
        }

    }
}