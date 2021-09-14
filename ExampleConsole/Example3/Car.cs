namespace ExampleConsole.Example3
{
    public class Car
    {
        private Engine _engine;

        public Car(Engine engine)
        {
            _engine = engine;
        }

        public Car()
        {
            _engine = new Engine();
            _engine.Start();
        }

        public Engine GetEngine()
        {
            return _engine;
        }
    }
}