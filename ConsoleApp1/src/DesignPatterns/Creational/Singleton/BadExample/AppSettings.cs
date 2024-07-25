using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1.src.DesignPatterns.Creational.Singleton.BadExample
{
    public class AppSettings
    {
        private Dictionary<string, object> _settings = new Dictionary<string, object>();

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