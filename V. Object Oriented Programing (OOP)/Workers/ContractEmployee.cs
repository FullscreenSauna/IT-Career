using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workers
{
    class ContractEmployee : BaseEmployee
    {
        public string EmployeeTask { get; }
        public string EmployeeDepartment { get; }

        public ContractEmployee(string employeeId, string employeeName, string employeeAddress, string employeeTask, string employeeDepartment)
            : base(employeeId, employeeName, employeeAddress)
        {
            EmployeeTask = employeeTask;
            EmployeeDepartment = employeeDepartment;
        }

        protected override decimal CalculateSalary(int workingHours)
        {
            return 250 + workingHours * 20m;
        }

        protected override string GetDepartment()
        {
            return EmployeeDepartment;
        }

        public override string ToString()
        {
            return $"{base.ToString()}\nTask: {EmployeeTask}\nDepartment: {EmployeeDepartment}";
        }
    }
}
