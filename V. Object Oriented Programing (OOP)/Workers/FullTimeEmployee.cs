using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workers
{
    class FullTimeEmployee : BaseEmployee
    {
        public string EmployeePosition { get; }
        public string EmployeeDepartment { get; }

        public FullTimeEmployee(string employeeId, string employeeName, string employeeAddress, string employeePosition, string employeeDepartmrnt) 
            : base(employeeId, employeeName, employeeAddress)
        {
            EmployeePosition = employeePosition;
            EmployeeDepartment = employeeDepartmrnt;
        }

        protected override decimal CalculateSalary(int workingHours)
        {
            return 250 + workingHours * 10.8m;
        }

        protected override string GetDepartment()
        {
            return EmployeeDepartment;
        }

        public override string ToString()
        {
            return $"{base.ToString()}\nPosition: {EmployeePosition}\nDepartment: {EmployeeDepartment}";
        }
    }
}
