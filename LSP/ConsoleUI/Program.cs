// See https://aka.ms/new-console-template for more information
using DemoLib;

Console.WriteLine("Hello, World!");

Manager accountingVP= new Manager();

accountingVP.FirstName = "abc";
accountingVP.LastName = "def";
accountingVP.CalculatePerHourRate(4);

Employee Employee= new Manager();

Employee.FirstName = "Jim";
Employee.LastName = "carry";
Employee.CalculatePerHourRate(2);

Console.WriteLine($"{Employee.FirstName}'s salary is:{Employee.Salary}/hrs.");
Console.ReadLine();
