using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1.src.DesignPatterns.Creational.Builder.GoodExample.Components
{
    public class Wheels
    {
        private float _diameterInInches;

        public Wheels(float diameterInInches)
        {
            _diameterInInches = diameterInInches;
        }

        public float GetDiameterInInches()
        {
            return _diameterInInches;
        }
    }
}