using System;
using ExampleConsole.Example3;
using ExampleConsole.Example4;

namespace ExampleConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Organization organization = new Organization();

            var department = organization.Get_Department();
            var department2 = organization.Get_Department();
        }
    }
}