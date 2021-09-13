using System;
using System.IO;

namespace ExampleConsole.Example2
{
    public class Enemy
    {
        private int _movementSpeed;

        public int Get_MovementSpeed()
        {
            return _movementSpeed;
        }

        public int Set_MovementSpeed(int speed)
        {
            if (speed < 0)
            {
                throw new InvalidDataException();
            }

            return speed;
        }
    }
}