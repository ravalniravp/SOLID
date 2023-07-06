// See https://aka.ms/new-console-template for more information
using ConsoleUI;
using DemoLib;

Console.WriteLine("Hello, World!");

IPerson owner = Fectory.CreatePerson();

owner.FirstName = "Test";
owner.LastName = "Test1";
owner.EmailAddress = "abc@xyz.com";
owner.PhoneNumber = "123-456-789";


IChore Chore = Fectory.CreateChore();

Chore.ChoreName = "Take out the trash";
Chore.Owner = owner;

Chore.PerformedWork(3);
Chore.PerformedWork(1.5);
Chore.CompleteChore();

Console.Read();
