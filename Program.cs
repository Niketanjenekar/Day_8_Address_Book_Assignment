using System.Security.Cryptography.X509Certificates;

namespace Day_8_Adress_Book_Assignment
{
   public class Program
   {
        public string firstname, lastname, mobilenumber, address, city, state, zip, email;
        public static void Main(string[] args)
        {
            //Usecase4:-
            ContactManagementUsecase4 obj = new ContactManagementUsecase4();
            obj.Usecase4_ContactManagement();
            

            //use case 3:-
            //ContactManagement_UC3 obj = new ContactManagement_UC3();
            //obj.Usecase3_ContactManagement();

            //    //Console.WriteLine("Hello, Welcome to the Adress Book Program: ");
            //    //ContactManagement_UC1.CreateContact();

            //    ContactManagement_UC3 num = new ContactManagement_UC3();
            //    num.EditContact();

        }
   }
}