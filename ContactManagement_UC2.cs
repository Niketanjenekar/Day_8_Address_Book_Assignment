using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Day_8_Adress_Book_Assignment
{
    internal class ContactManagement_UC2
    {
       
        
        public void AddingContacts()
        {
            Program obj = new Program();

            Console.WriteLine("Enter First Name: ");
            obj.firstname = Console.ReadLine();

            Console.WriteLine("Enter Last name: ");
            obj.lastname = Console.ReadLine();

            Console.WriteLine("Enter Your MobileNumber: ");
            obj.mobilenumber = Console.ReadLine();

            Console.WriteLine("Enter Your Address: ");
            obj.address = Console.ReadLine();

            Console.WriteLine("Enter Your City: ");
            obj.city = Console.ReadLine();

            Console.WriteLine("Enter  Your State: ");
            obj.state = Console.ReadLine();

            Console.WriteLine("Enter Your Zip: ");
            obj.zip = Console.ReadLine();

            Console.WriteLine("Enter Your Email Id: ");
            obj.email = Console.ReadLine();

            Console.WriteLine("*****************************************************");
            Console.WriteLine("Here are the details of the Employee: ");
            Console.WriteLine(obj.firstname);
            Console.WriteLine(obj.lastname);
            Console.WriteLine(obj.mobilenumber);
            Console.WriteLine(obj.address);
            Console.WriteLine(obj.city);
            Console.WriteLine(obj.state);
            Console.WriteLine(obj.zip);
            Console.WriteLine(obj.email);
            
        }
      
    }
}
