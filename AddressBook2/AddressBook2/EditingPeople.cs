using AddressBook2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AddressBook2
{
    public class EditingPeople
    {
        public static void EditPerson()
        {
            Console.WriteLine("Enter the first name of the person you would like to edit..");
            string firstName = Console.ReadLine();
            Person person = AddPeople.People.FirstOrDefault(x => x.FirstName.ToLower() == firstName.ToLower());
            if (person == null)
            {
                Console.WriteLine("That person could not be found. Press any key to continue");
                Console.ReadKey();
                return;
            }
            Console.WriteLine("Are you sure you want to edit this person from your address book? (Y/N)");
            ListingPeople.PrintPerson(person);

            if (Console.ReadKey().Key == ConsoleKey.Y)
            {
                AddPeople.People.Remove(person);
                Console.WriteLine("Person removed. Press any key to edit.");
                AddPeople.AddPerson();
                Console.ReadKey();
            }
        }
    }
}
