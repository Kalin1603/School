namespace Фирми
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Company
    {
        private string name;
        private string city;
        private List<Employee> employees = new List<Employee>();

        public Company(string name, string city)
        {
            this.Name = name;
            this.City = city;
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (value.Length < 2)
                {
                    throw new ArgumentException("Invalid company name!");
                }
                name = value;
            }
        }

        
        public string City
        {
            get { return city; }
            set
            {
                if (value.Length < 4 || !(char.IsUpper(value[0])))
                {
                    throw new ArgumentException("Invalid city");
                }
                city = value;
            }
        }

        public void AddEmployee(Employee employee)
        {
            this.employees.Add(employee);
        }

        public bool RemoveEmployee(Employee employee)
        {
            return this.employees.Remove(employee);
        
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Company {Name} from {City}");
            foreach (var e in employees)
            {
                sb.AppendLine(e.ToString());
            }
            return sb.ToString();
        }
    }
}
