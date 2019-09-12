using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workers
{
    public abstract class BaseEmployee
    {
        protected string EmployeeId { get; }
        protected string EmployeeName { get; }
        protected string EmployeeAddress { get; }

        protected BaseEmployee(string employeeId, string employeeName, string employeeAddress)
        {
            EmployeeId = employeeId;
            EmployeeName = employeeName;
            EmployeeAddress = employeeAddress;
        }

        protected abstract decimal CalculateSalary(int workingHours);
        protected abstract string GetDepartment();

        public override string ToString()
        {
            return $"Id: {EmployeeId} \nName:{EmployeeName}\nAddress:{EmployeeAddress}";
        }
    }
}
