// See https://aka.ms/new-console-template for more information
//Console.WriteLine("***************** Welcome To AddressBook ************************");
using AddressBook_ADO.Net;
PersonDetails repo = new PersonDetails();
Person employee = new Person();
employee.ID = 7;
employee.FirstName = "Darla";
employee.LastName = "roy";
employee.Address = "Delhi";
employee.PhoneNumber = "123456492";
employee.zip = 456487;
employee.City = "Goa";
employee.State = "Goa";
employee.Email = "darla@gmail.com";
employee.AddressBookName = "book3";
employee.Type = "Friends";

repo.AddEmployee(employee);