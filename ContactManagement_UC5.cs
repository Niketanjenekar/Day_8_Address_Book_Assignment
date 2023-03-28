using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_8_Adress_Book_Assignment
{
    internal class ContactManagement_UC5
    {
        public void Usecase5_ContactManagement()
        {
            List<Address> addresses = new List<Address>();

            while (true)
            {
                Console.WriteLine("Please choose an option:");
                Console.WriteLine("1. Add new address");
                Console.WriteLine("2. Edit existing address");
                Console.WriteLine("3. Delete a Existing Contact");
                Console.WriteLine("3. Exit");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddAddress(addresses);
                        break;
                    case 2:
                        EditAddress(addresses);
                        break;
                    case 3:
                        DeleteContact(addresses);
                        break;
                    case 4:
                        Console.WriteLine("Exiting program...");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        static void AddAddress(List<Address> addresses)
        {
            Console.WriteLine("Enter name:");
            string Name = Console.ReadLine();

            Console.WriteLine("Enter street address:");
            string streetAddress = Console.ReadLine();

            Console.WriteLine("Enter city:");
            string city = Console.ReadLine();

            Console.WriteLine("Enter state:");
            string state = Console.ReadLine();

            Console.WriteLine("Enter zip code:");
            string zipCode = Console.ReadLine();

            Address address = new Address(Name, streetAddress, city, state, zipCode);
            addresses.Add(address);

            Console.WriteLine("Address added successfully.");
        }

        static void EditAddress(List<Address> addresses)
        {
            Console.WriteLine("Enter name of address to edit:");
            string name = Console.ReadLine();

            Address addressToEdit = null;

            foreach (Address address in addresses)
            {
                if (address.Name == name)
                {
                    addressToEdit = address;
                    break;
                }
            }

            if (addressToEdit == null)
            {
                Console.WriteLine("Address not found.");
                return;
            }

            Console.WriteLine("Enter new street address (or press Enter to keep current value):");
            string newStreetAddress = Console.ReadLine();

            if (!string.IsNullOrEmpty(newStreetAddress))
            {
                addressToEdit.StreetAddress = newStreetAddress;
            }

            Console.WriteLine("Enter new city (or press Enter to keep current value):");
            string newCity = Console.ReadLine();

            if (!string.IsNullOrEmpty(newCity))
            {
                addressToEdit.City = newCity;
            }

            Console.WriteLine("Enter new state (or press Enter to keep current value):");
            string newState = Console.ReadLine();

            if (!string.IsNullOrEmpty(newState))
            {
                addressToEdit.State = newState;
            }

            Console.WriteLine("Enter new zip code (or press Enter to keep current value):");
            string newZipCode = Console.ReadLine();

            if (!string.IsNullOrEmpty(newZipCode))
            {
                addressToEdit.ZipCode = newZipCode;
            }

            Console.WriteLine("Address updated successfully.");
        }
        static void DeleteContact(List<Address> addresses)
        {
            Console.WriteLine("Enter the First Name of the contact to be deleted:");
            string name = Console.ReadLine();

            Address contactToDelete = addresses.FirstOrDefault(c => c.Name.Equals(name, StringComparison.OrdinalIgnoreCase));

            if (contactToDelete == null)
            {
                Console.WriteLine("Contact not found!");
                return;
            }

            addresses.Remove(contactToDelete);
            Console.WriteLine("Contact deleted successfully!");
        }
    }

    class Address
    {
        public string Name { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }

        public Address(string name, string streetAddress, string city, string state, string zipCode)
        {
            Name = name;
            StreetAddress = streetAddress;
            City = city;
            State = state;
            ZipCode = zipCode;
        }
    }
}

