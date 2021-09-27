using System;

namespace ExampleConsole.Example4
{
    public class Organization
    {
        private Department _department;

        public Department Department
        {
            get
            {
                if (_department == null)
                {
                    _department = new Department();
                }

                return _department;
            }
        }

        public Organization()
        {
            Console.WriteLine(_department == null);
        }

        public Department Get_Department()
        {
            if (_department == null)
            {
                _department = new Department();
            }

            return _department;
        }
    }
}