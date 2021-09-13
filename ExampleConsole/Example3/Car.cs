namespace ExampleConsole.Example3
{
    public class Car
    {
        private Engine _engine;

        public Car(Engine engine)
        {
            _engine = engine;
        }

        public Engine GetEngine()
        {
            return _engine;
        }
    }
}