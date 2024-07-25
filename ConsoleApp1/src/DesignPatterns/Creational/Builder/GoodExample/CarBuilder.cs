using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConsoleApp1.Inheritance;
using ConsoleApp1.src.DesignPatterns.Creational.Builder.GoodExample.Components;

namespace ConsoleApp1.src.DesignPatterns.Creational.Builder.GoodExample
{
    public class CarBuilder : IBuilder
    {
        private Car _car;

        public CarBuilder()
        {
            Reset();
        }

        public void Reset()
        {
            _car = new Car();
        }

        public IBuilder SetCarType(CarType type)
        {
            _car.Type = type;
            return this;
        }

        public IBuilder SetDashboard(Dashboard dashboard)
        {
            _car.Dashboard = dashboard;
            return this;
        }

        public IBuilder SetEngine(Engine engine)
        {
            _car.Engine = engine;
            return this;
        }

        public IBuilder SetGPSNavigator(GPSNavigator gpsNavigator)
        {
            _car.GpsNavigator = gpsNavigator;
            return this;
        }

        public IBuilder SetSeats(int seats)
        {
            _car.Seats = seats;
            return this;
        }

        public IBuilder IsConvertible(bool isConvertible)
        {
            _car.isConvertible = isConvertible;
            return this;
        }

        public IBuilder SetWheels(Wheels wheels)
        {
            _car.Wheels = wheels;
            return this;
        }

        public Car GetCar()
        {
            var car = _car;
            Reset();
            return car;
        }
    }
}