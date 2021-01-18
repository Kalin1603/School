namespace Работници
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class FullTimeEmployee : BaseEmployee
    {
        private string employeePosition;
        private string employeeDepartment;
        public FullTimeEmployee(string employeeAddress, string employeeName, string employeeID,string employeePosition,string employeeDepartment) : base(employeeAddress, employeeName, employeeID)
        {
            this.EmployeePosition = employeePosition;
            this.EmployeeDepartment = employeeDepartment;
        }

        public string EmployeePosition
        {
            get { return employeePosition; }
            set { employeePosition = value; }
        }

        

        public string EmployeeDepartment
        {
            get { return employeeDepartment; }
            set { employeeDepartment = value; }
        }


        public override decimal CalculateSalary(int workingHours)
        {
            decimal sum = 250m + workingHours * 10.80m;
            return sum;
        }

        public override string GetDepartment()
        {
            return $"{this.EmployeeDepartment}";
        }

        public override string Show()
        {
            return base.Show()+$"{this.EmployeePosition} {this.EmployeeDepartment}";
        }
    }
}
