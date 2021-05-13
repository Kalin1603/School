namespace Фирми
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Employee
    {
        private string id;
        private string firstName;
        private string lastName;
        private int age;
        private double salary;

        public Employee(string id, string firstName, string lastName, int age)
        {
          this.Id = id;
          this.FirstName = firstName;
          this.LastName = lastName;
          this.Age = age;
          this.Salary = 500.0;
        }

        public Employee(string id, string firstName, string lastName, int age, double salary) : this(id, firstName, lastName, age)
        {
            this.Salary = salary;
        }

        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        

        public string FirstName
        {
            get { return firstName; }
            set
            {
                if (value.Length > 2 && value.Length < 8)
                {
                    throw new ArgumentException("Invalid employee name!");
                }
                firstName = value;
            }
        }
        

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        
        public int Age
        {
            get { return age; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Invalid employee age!");
                }
                age = value;
            }
        }
        

        public double Salary
        {
            get { return salary; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException($"Invalid salary!");
                }
                salary = value;
            }
        }

        public override string ToString()
        {
            return $"Employee: {FirstName} {LastName} with id: {Id} and salary: {Salary:f2}";
        }

    }
}
