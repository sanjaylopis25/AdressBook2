using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AddressBook2
{
    public class RemovingPeople
    {
        public static void RemovePerson()
        {
            Console.WriteLine("Enter the first name of the person you would like to remove.");
            string firstName = Console.ReadLine();
            Person person = AddPeople.People.FirstOrDefault(x => x.FirstName.ToLower() == firstName.ToLower());
            if (person == null)
            {
                Console.WriteLine("That person could not be found. Press any key to continue");
                Console.ReadKey();
                return;
            }
            Console.WriteLine("Are you sure you want to remove this person from your address book? (Y/N)");
            ListingPeople.PrintPerson(person);

            if (Console.ReadKey().Key == ConsoleKey.Y)
            {
                AddPeople.People.Remove(person);
                Console.WriteLine("Person removed. Press any key to continue.");
                Console.ReadKey();
            }
        }
    }
}
