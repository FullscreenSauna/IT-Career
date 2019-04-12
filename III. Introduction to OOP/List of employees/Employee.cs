using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace List_of_employees
{
    class Employee
    {
        private string name;
        private decimal salary;
        private string position;
        private string department;
        private string email;
        private int age;

        public string Name { get => name; set => name = value; }

        public decimal Salary { get => salary; set => salary = value; }

        public string Position { get => position; set => position = value; }

        public string Department { get => department; set => department = value; }

        public string Email { get => email; private set => email = value; }

        public int Age { get => age; private set => age = value; }


        public void SetEmail(string value)
        {
            if (value == null)
            {
                email = "n/a";
            }
            else
            {
                email = value;

            }
        }

        public void SetAge (int value)
        {
            if (value == 0)
            {
                age = -1;
            }
            else
            {
                age = value;

            }
        }

        public override string ToString()
        {
            return $"{name} {salary:f2} {email} {age}";
        }
    }
}
