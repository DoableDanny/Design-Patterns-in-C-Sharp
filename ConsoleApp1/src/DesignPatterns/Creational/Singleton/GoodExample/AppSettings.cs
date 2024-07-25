using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1.src.DesignPatterns.Creational.Singleton.GoodExample
{
    public class AppSettings
    {
        private static AppSettings _instance;
        private Dictionary<string, object> _settings = new Dictionary<string, object>();

        // make constructor private
        private AppSettings() { }

        // method for creating a single instance of this class
        public static AppSettings GetInstance()
        {
            if (_instance == null)
            {
                _instance = new AppSettings();
            }
            return _instance;
        }

        public object Get(string key)
        {

            if (!_settings.ContainsKey(key))
                return null;

            return _settings[key];
        }

        public void Set(string key, object value)
        {
            _settings[key] = value;
        }
    }
}