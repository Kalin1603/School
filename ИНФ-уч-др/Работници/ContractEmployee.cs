namespace Работници
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    class ContractEmployee : BaseEmployee
    {
        private string employeeTask;
        private string employeeDepartment;

        public ContractEmployee(string employeeAddress, string employeeName, string employeeID,string employeeTask,string employeeDepartment) : base(employeeAddress, employeeName, employeeID)
        {
            this.EmployeeTask = employeeTask;
            this.EmployeeDepartment = employeeDepartment;
        }


        public string EmployeeTask
        {
            get { return employeeTask; }
            set { employeeTask = value; }
        }

        public string EmployeeDepartment
        {
            get { return employeeDepartment; }
            set { employeeDepartment = value; }
        }



        public override decimal CalculateSalary(int workingHours)
        {
            decimal sum = 250m + workingHours * 20m;
            return sum;
        }

        public override string GetDepartment()
        {
            return $"{this.EmployeeDepartment}";
        }

        public override string Show()
        {
            return base.Show()+$"{this.EmployeeTask} {this.EmployeeDepartment}";
        }

    }
}
