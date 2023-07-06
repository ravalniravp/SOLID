// See https://aka.ms/new-console-template for more information
using OCPLibrary;

Console.WriteLine("Hello, World!");

List<IApplicantModel> applications = new List<IApplicantModel>
{
    new ManagerModel { FirstName = "Nirav", LastName = "Raval"},
    new PersonModel { FirstName = "Uday", LastName = "Raval"},
    new PersonModel { FirstName = "Hitesh", LastName = "Raval"},
    new PersonModel { FirstName = "Ashish", LastName = "Raval"}
};

List<Employee> employees = new List<Employee>();

foreach(var applicator in applications)
{
    employees.Add(applicator.AccountProcessor.Create(applicator));
}

foreach(var employee in employees)
{
    Console.WriteLine($"{employee.FirstName} {employee.LastName}: {employee.Email} isManager: {employee.isManager}");
}

Console.ReadLine();