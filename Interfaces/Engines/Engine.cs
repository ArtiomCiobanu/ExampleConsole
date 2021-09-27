using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class Engine
    {
        private readonly int _power;

        public Engine(int power)
        {
            _power = power;
        }

        public void Start()
        {
            Console.WriteLine($"Engine with power {_power} starts");
        }

        public void Stop()
        {
            Console.WriteLine($"Engine with power {_power} stops");
        }
    }
}
