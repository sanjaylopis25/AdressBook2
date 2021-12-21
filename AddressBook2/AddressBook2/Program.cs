using System;
using System.Collections.Generic;
using System.Linq;

namespace AddressBook2
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Addresses { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zip { get; set; }
        public string email { get; set; }
        static void Main(string[] args)
        {

            int command = 0;
            while (command != 5)
            {
                Console.Clear();
                Console.WriteLine("1: Add \n2: Remove \n3: List \n4: Edit \n5: exit");
                Console.WriteLine("Please enter a command number: ");
                command = Convert.ToInt32(Console.ReadLine());
                switch (command)
                {
                    case 1:
                        AddPeople.AddPerson();
                        break;
                    case 2:
                        RemovingPeople.RemovePerson();
                        break;
                    case 3:
                        ListingPeople.ListPeople();
                        break;
                    case 4:
                        EditingPeople.EditPerson();
                        break;
                }
            }
        }

    }
}
