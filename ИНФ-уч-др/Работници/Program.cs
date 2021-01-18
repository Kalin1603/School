namespace Работници
{
    using System;

    class Program
    {
       public static void Main()
        {
            FullTimeEmployee employee1 = new FullTimeEmployee("Velingrad","Vesko","9","10","WebDeveloper");
            FullTimeEmployee employee2 = new FullTimeEmployee("Plovdiv", "Alex", "12", "20", "Programmer");
            

            ContractEmployee employee3 = new ContractEmployee("Pazardjik","Kalin","8","Task3","Programmer");
            ContractEmployee employee4 = new ContractEmployee("Grashevo", "Krasi", "10", "Task4", "Teacher");

            Console.WriteLine(employee1.CalculateSalary(10));
            Console.WriteLine(employee3.CalculateSalary(10));
        }
    }
}
