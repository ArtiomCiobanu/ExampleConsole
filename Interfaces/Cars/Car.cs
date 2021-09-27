using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class Car
    {
        private readonly Engine _engine;

        public Car(Engine engine)
        {
            _engine = engine;
        }

        public void Start()
        {
            Console.WriteLine("The car is starting");

            _engine.Start();

            Console.WriteLine("You can now drive the car.");
        }

        public void Stop()
        {
            Console.WriteLine("The car is stopping");

            _engine.Start();
        }
    }
}
