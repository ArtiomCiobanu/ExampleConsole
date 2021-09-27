using System;

namespace ExampleConsole.Example3
{
    public class Car
    {
        private NewEngine _engine;

        private int _maxSpeed;

        public Car(NewEngine engine)
        {
            _engine = engine; //new Engine();
            _engine.Start();

            _maxSpeed = 10;
        }

        /*public NewEngine GetEngine()
        {
            return _engine;
        }*/

        public int GetMaxSpeed()
        {
            return _maxSpeed;
        }

        public void Start()
        {
            Console.WriteLine("The car is starting");
        }
    }

    public struct NewEngine
    {
        public string Name { get; set; }

        public NewEngine(string name)
        {
            Name = name;
        }

        public void Start()
        {
        }
    }
}