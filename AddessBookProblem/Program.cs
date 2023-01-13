using System;
using AddessBookProblem;

namespace AddressBookProblem
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Displaying Welcome to Address Book Program");

            //UC_2UC_2
            //AddContact.ContactDetails();
            UC_1CreateContact UC_1CreateContact = new UC_1CreateContact();
            bool flag = true;
            while (flag)
            {
                //Console.WriteLine("1. Create  2. Edit  3.Delete ");

                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        UC_1CreateContact.UC_2AddContact();
                        break;
                    case 2:
                        Console.Write("Enter FirstName and LastName to edit ");
                        string edit = Console.ReadLine();
                        UC_1CreateContact.Equals(edit);
                        break;
                    default:
                        flag = false;
                        break;


                }

            }
        }
    }
}