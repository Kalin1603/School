using System;
using System.Collections.Generic;
using Фирми;

public class Program
{
    private static Dictionary<string, Employee> emploies = new Dictionary<string, Employee>();
    private static Dictionary<string,Company> companies = new Dictionary<string, Company>();
    static void Main(string[] args)
    {
        while (true)
        {
            string[] input = Console.ReadLine().Split(' ');
            string cmd = input[0];
            if (cmd == "end")
            {
                break;
            }
            switch (cmd)
            {
                case "CreateEmployee":
                    if (input.Length == 5)
                    {
                        CreateEmployee(input[1], input[2], input[3], int.Parse(input[4]));
                    }
                    else if (input.Length == 6)
                    {
                        CreateEmployee(input[1], input[2], input[3], int.Parse(input[4]), double.Parse(input[5]));
                    }
                    break;
                case "PrintEmployeeInfo":
                    PrintEmployeeInfo(input[1]);
                    break;

                case "CreateCompany":
                    CreateCompany(input[1], input[2]);
                    break;
                case "PrintCompanyInfo":
                    PrintCompanyInfo(input[1]);
                    break;

                case "HireEmployee":
                     HireEmployee(input[1], input[2]);
                    break;

                case "FireEmployee":
                     FireEmployee(input[1], input[2]);
                    break;
            }
        }
    }

    public static void CreateEmployee(string id, string firstName, string lastName, int age)
    {
        if (!emploies.ContainsKey(id))
        {
            emploies.Add(id, new Employee(id, firstName, lastName, age));
        }
        else
        {
            Console.WriteLine("Employee already exist!");
        }
    }

    public static void CreateEmployee(string id, string firstName, string lastName, int age, double salary)
    {
        if (!emploies.ContainsKey(id))
        {
            emploies.Add(id, new Employee(id, firstName, lastName, age, salary));
        }
        else
        {
            Console.WriteLine("Employee already exist!");
        }
    }

    public static void CreateCompany(string name, string city)
    {
        if (!companies.ContainsKey(name))
        {
            companies.Add(name, new Company(name, city));
        }
        else
        {
            Console.WriteLine("Company already exist!");
        }
    }

    public static void HireEmployee(string name, string id)
    {
        
        if (companies.ContainsKey(name))
        {
            Company company = companies[name];
            if (emploies.ContainsKey(id))
            {
                Employee employee = emploies[id];
                company.AddEmployee(employee);
            }
            else
            {
                Console.WriteLine("Employee not found!");
            }
        }
        else
        {
            Console.WriteLine("Company not found!");
        }
        
    }

    public static void FireEmployee(string name, string id)
    {
        if (companies.ContainsKey(name))
        {
            Company company = companies[name];
            
            if (emploies.ContainsKey(id))
            {
                Employee employee = emploies[id];
                bool isRemoved = company.RemoveEmployee(employee);
                if (isRemoved)
                {
                    Console.WriteLine("Employee is removed!");
                }
                else
                {
                    Console.WriteLine("Employee is not removed!");
                }
            }
            else
            {
                Console.WriteLine("Employee not found!");
            }
        }
        else
        {
            Console.WriteLine("Company not found!");
        }
    }

    public static void IncreaseSalaries(string name, double amount)
    {

    }

    public static void DecreaseSalaries(string name, double amount)
    {

    }

    public static void PrintEmployeeInfo(string id)
    {
        if (emploies.ContainsKey(id))
        {
            Console.WriteLine(emploies[id]);
        }
        else
        {
            Console.WriteLine("Employee not exist!");
        }
    }

    public static void PrintCompanyInfo(string name)
    {
        if (companies.ContainsKey(name))
        {
            Console.WriteLine(companies[name]);
        }
        else
        {
            Console.WriteLine("Company doesn't exist!");
        }
    }
}


