using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBook2
{
    public class ListingPeople
    {
        public static void PrintPerson(Person person)
        {
            Console.WriteLine("First Name: " + person.FirstName);
            Console.WriteLine("Last Name: " + person.LastName);
            Console.WriteLine("Phone Number: " + person.PhoneNumber);
            Console.WriteLine("Address: " + person.Addresses);
            Console.WriteLine("city: " + person.city);
            Console.WriteLine("state: " + person.state);
            Console.WriteLine("zip: " + person.zip);
            Console.WriteLine("email: " + person.email);
            Console.WriteLine("-------------------------------------------");
        }

        public static void ListPeople()
        {
            if (AddPeople.People.Count == 0)
            {
                Console.WriteLine("Your address book is empty. Press any key to continue.");
                Console.ReadKey();
                return;
            }
            Console.WriteLine("Here are the current people in your address book:\n");
            foreach (var person in AddPeople.People)
            {
                PrintPerson(person);
            }
            Console.WriteLine("\nPress any key to continue.");
            Console.ReadKey();
        }
    }
}
