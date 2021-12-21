using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBook2
{
    public class AddPeople
    {
        public static List<Person> People = new List<Person>();
        public static void AddPerson()
        {
            Person person = new Person();

            Console.Write("Enter First Name: ");
            person.FirstName = Console.ReadLine();

            Console.Write("Enter Last Name: ");
            person.LastName = Console.ReadLine();

            Console.Write("Enter Phone Number: ");
            person.PhoneNumber = Console.ReadLine();

            Console.Write("Enter Address: ");
            person.Addresses = Console.ReadLine();

            Console.Write("Enter City: ");
            person.city = Console.ReadLine();

            Console.Write("Enter state: ");
            person.state = Console.ReadLine();

            Console.Write("Enter Zip Number: ");
            person.zip = Console.ReadLine();

            Console.Write("Enter email: ");
            person.email = Console.ReadLine();

            People.Add(person);
        }
    }
}
