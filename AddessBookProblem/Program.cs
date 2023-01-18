using System;
using AddessBookProblem;

namespace AddressBookProblem
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Displaying Welcome to Address Book Program");

            //UC_6
            RefactorToAdd addressBook = new RefactorToAdd();
            addressBook.PersonDetails();
            addressBook.display();
            addressBook.EditContact();
            addressBook.DeleteContact();
            addressBook.CreateAddressBook();
            addressBook.ChangeAddressBook();


        }
        
    }
}