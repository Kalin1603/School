namespace Работници
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public abstract class BaseEmployee
    {
        private string employeeID;
        private string employeeName;
        private string employeeAddress;

        protected BaseEmployee(string employeeAddress, string employeeName, string employeeID)
        {
            this.EmployeeAddress = employeeAddress;
            this.EmployeeName = employeeName;
            this.EmployeeID = employeeID;
        }

        public string EmployeeAddress
        {
            get { return employeeAddress; }
            set { employeeAddress = value; }
        }

        public string EmployeeName
        {
            get { return employeeName; }
            set { employeeName = value; }
        }

        public string EmployeeID
        {
            get { return employeeID; }
            set { employeeID = value; }
        }

        public virtual string Show()
        {
            return $"{this.EmployeeID} {this.EmployeeName} {this.EmployeeAddress}";
        }

        public abstract decimal CalculateSalary(int workingHours);
        public abstract string GetDepartment(); 
    }
}
