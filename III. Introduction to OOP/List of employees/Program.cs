using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_of_employees
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var departments = new Dictionary<string, List<Employee>>();

            for (int i = 0; i < n; i++)
            {
                string[] info = Console.ReadLine().Split();
                var employee = CreateEmployee(info);
                AddToDepartments(departments, employee);
            }

            string finalDepartment = FindFinalDepartment(departments);

            PrintResult(departments, finalDepartment);
        }

        private static void PrintResult(Dictionary<string, List<Employee>> departments, string finalDepartment)
        {
            Console.WriteLine();
            Console.WriteLine($"Highest Average Salary: {finalDepartment}");

            foreach (var employee in departments[finalDepartment].OrderByDescending(x => x.Salary))
            {
                Console.WriteLine(employee.ToString());
            }
        }

        private static string FindFinalDepartment(Dictionary<string, List<Employee>> departments)
        {
            string finallDepartment = null;
            decimal highestAverage = 0M;

            foreach (var pair in departments)
            {
                decimal currentSalary = 0M;
                decimal currentAverage = 0M;

                foreach (var employee in pair.Value)
                {
                    currentSalary += employee.Salary;
                }
                currentAverage = currentSalary / pair.Value.Count();

                if (currentAverage > highestAverage)
                {
                    highestAverage = currentAverage;
                    finallDepartment = pair.Key;
                }
            }

            return finallDepartment;
        }

        private static void AddToDepartments(Dictionary<string, List<Employee>> departments, Employee employee)
        {
            if (!departments.ContainsKey(employee.Department))
            {
                departments.Add(employee.Department, new List<Employee>());
            }

            departments[employee.Department].Add(employee);
        }

        private static Employee CreateEmployee(string[] info)
        {
            var employee = new Employee
            {
                Name = info[0],
                Salary = decimal.Parse(info[1]),
                Position = info[2],
                Department = info[3]
            };

            string email = null;
            int age = 0;

            if (info.Length >= 5)
            {
                if (info.Length == 6)
                {
                    email = info[4];
                    age = int.Parse(info[5]);
                }
                else if (info[4].Contains('@'))
                {
                    email = info[4];
                }
                else
                {
                    age = int.Parse(info[4]);
                }
            }


            employee.SetEmail(email);
            employee.SetAge(age);

            return employee;
        }
    }
}
