using ExampleConsole.Example3;

namespace ExampleConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Example3();
        }

        static void Example3()
        {
            var car = new Car();

            var engineFromCar = car.GetEngine();
            engineFromCar.Stop();
        }
    }
}