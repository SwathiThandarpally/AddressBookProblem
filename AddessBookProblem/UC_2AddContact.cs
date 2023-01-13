using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddessBookProblem
{
    internal class UC_2AddContact
    {
        public static void ContactDetails()
        {
            UC_1CreateContact contacts = new UC_1CreateContact();
            Console.WriteLine("Enter your FirstName :");
            contacts.Firstname = Console.ReadLine();

            Console.WriteLine("Enter your LastName :");
            contacts.Lastname = Console.ReadLine();

            Console.WriteLine("Enter your PhoneNumber :");
            contacts.Phonenumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your Email-Id :");
            contacts.Email = Console.ReadLine();

            Console.WriteLine("Enter your Address :");
            contacts.Address = Console.ReadLine();

            Console.WriteLine("Enter your City :");
            contacts.City = Console.ReadLine();

            Console.WriteLine("Enter your Sate :");
            contacts.State = Console.ReadLine();

            Console.WriteLine("Enter your ZipCode :");
            contacts.Zipcode = Convert.ToInt32(Console.ReadLine());
        }
    }
}
