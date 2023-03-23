using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Day_8_Adress_Book_Assignment
{
    internal class ContactManagement_UC1
    {
        public static void CreateContact()
        {

            string firstname;
            string lastname;
            string address;
            string city;
            string state;
            string zip;

            string phone;
            string email;
            string mobilenumber;

            Console.WriteLine("Enter First Name: ");
            firstname = Console.ReadLine();

            Console.WriteLine("Enter Last name: ");
            lastname = Console.ReadLine();

            Console.WriteLine("Enter Your MobileNumber: ");
            mobilenumber = Console.ReadLine();

            Console.WriteLine("Enter Your Address: ");
            address = Console.ReadLine();

            Console.WriteLine("Enter Your City: ");
            city = Console.ReadLine();

            Console.WriteLine("Enter  Your State: ");
            state = Console.ReadLine();

            Console.WriteLine("Enter Your Zip: ");
            zip = Console.ReadLine();

            Console.WriteLine("Enter Your Email Id: ");
            email = Console.ReadLine();
            
            
        }
    }
}
