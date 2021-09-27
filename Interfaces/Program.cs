using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Engine engine1 = new Engine(20);

            Car car1 = new Car(engine1);
            UseCar(car1);
        }

        static void UseCar(Car car)
        {
            Console.WriteLine("Using the car...");

            car.Start();
            car.Stop();
        }
    }
}
