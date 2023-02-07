// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using Task_22.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.IdentityModel.Tokens;
// insert, update, and delete entries

Contact Sarah = new Contact("Sarah H", "(083)383-3555", "House A, Street 2, Town, Co. Wicklow, Ireland");
Contact Zeus = new Contact("Zeus F.", "(083)555-2323", "House A, Street 2, Town, Co. Wicklow, Ireland");
Contact Skadi = new Contact("Skadi F.", "(083)555-321", "House A, Street 2, Town, Co. Wicklow, Ireland");
Contact Buffy = new Contact("Buffy Summers", "(555)338-33555", "1630 Revello Drive, Sunnydale, CA, USA");
Contact Angel = new Contact("Angel", "(213)555-0162", "1481 Hyperion Ave., LA, CA, USA");
Contact Rick = new Contact("Rick Sanchezs", "(184)466-3742", "The Smith Residence, Washington, USA, Earth");
Contact Doctor = new Contact("The Doctor", "(077)009-0461", "The TARDIS");
Contact Rose = new Contact("Rose Tyler", "(020)794-6000", "Earth Twoo");
Contact Zelda = new Contact("Princess Zelda", "(085)121-2212", "Hyila, Hyrule");
Contact Link = new Contact("Link", "(087)111-2311", "Hyila, Hyrule");


// connect to local database
var context = new PhoneBookV1Context();
context.Database.EnsureCreated();



// function to add a new contact to the phone book i.e. to the loacl database if it is not already there
var addContact = (Contact person) => {
    var result = context.PhoneBook.Find(person.PhoneNumber);
    if (result == null)
    {
        context.PhoneBook.Add(person);
    }
    else
    {
        Console.WriteLine(person.PhoneNumber + " - - - - - That Person's Contact Already Exists...");
    }
};


// Commented out Adding Contacts while testing tasks
/*
addContact(Sarah);
addContact(Zeus);
addContact(Skadi);
addContact(Buffy);
addContact(Angel);
addContact(Rick);   
addContact(Doctor);
addContact(Rose);
addContact(Zelda);
addContact(Link);
*/

context.SaveChanges();


// Report the full contents of the phone book in name order
var AscOrder = from person in context.PhoneBook
              orderby person.PhoneNumber
              select person;
foreach(var contact in  AscOrder)
{
    Console.WriteLine(contact);
}


// Report the name and address for specified phone number
var SearchByNum = from person in context.PhoneBook
                     where person.PhoneNumber == "(077)009-0461"
                     select person;
Console.WriteLine(SearchByNum);



// Report phone numbers and addresses matching a specified name
//  Searching for a name
var SearchByName = from person in context.PhoneBook
                     where person.Name.Equals("Zeus")
                     select person;
foreach(var person in SearchByName)
{
    Console.WriteLine(person);
}

// Searching for an address
var SearchByAddress = from person in context.PhoneBook
                   where person.Address == "House A, Street 2, Town, Co. Wicklow, Ireland"
                      select person;
foreach(var address in SearchByAddress)
{
    Console.WriteLine(address);
}


Console.WriteLine("\n\tTask 2 Complete");
Console.ReadLine();