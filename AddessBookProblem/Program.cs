using System;
using AddessBookProblem;

namespace AddressBookProblem
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Displaying Welcome to Address Book Program");

            //UC_2UC_2AddContact.ContactDetails();
            

            //UC_3
            Edit edit = new Edit();
            edit.createContact();
            edit.print();
            edit.Editing("Swathi");

        }
    }
}