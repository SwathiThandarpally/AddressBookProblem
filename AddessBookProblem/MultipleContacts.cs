using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddessBookProblem
{
    internal class MultipleContacts
    {

        Dictionary<string, string> UC_1CreateContact;
        Dictionary<string, Dictionary<string, string>> addressBook = new Dictionary<string, Dictionary<string, string>>();
        public void PersonDetails()
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

        public void ViewContact()
        {
            Console.WriteLine("Enter full name:");
            string contactName = Console.ReadLine();
            if (addressBook.ContainsKey(contactName))
            {
                UC_1CreateContact = new Dictionary<string, string>();
                addressBook.TryGetValue(contactName, out UC_1CreateContact);
                Console.WriteLine("First Name: " + UC_1CreateContact["first Name"]);

                Console.WriteLine("Last Name:" + UC_1CreateContact["last Name"]);

                Console.WriteLine("Address:" + UC_1CreateContact["Address"]);

                Console.WriteLine("City:" + UC_1CreateContact["City"]);

                Console.WriteLine("State:" + UC_1CreateContact["State"]);

                Console.WriteLine("Zip:" + UC_1CreateContact["Zip"]);

                Console.WriteLine("Phone number:" + UC_1CreateContact["Phone number"]);

                Console.WriteLine("Email:" + UC_1CreateContact["Email"]);
            }
            else
                Console.WriteLine("Contact doesn't exist");

        }

        public void EditContact()
        {

            Console.WriteLine("Enter full contact name");
            String contactName = Console.ReadLine();

            if (addressBook.ContainsKey(contactName))
            {
                Console.Write("Select option you want to edit : ");
                Console.WriteLine("1. First Name 2. Last Name 3. Address\n 4. City 5. State 6. Zip\n 7. Phone number  8. Email");

                int option = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter contact field:");
                String Cotanctinfo = Console.ReadLine();

                switch (option)
                {
                    case 1:
                        addressBook[contactName]["First Name"] = Cotanctinfo;
                        break;
                    case 2:
                        addressBook[contactName]["Last Name"] = Cotanctinfo;
                        break;
                    case 3:
                        addressBook[contactName]["Address"] = Cotanctinfo;
                        break;
                    case 4:
                        addressBook[contactName]["City"] = Cotanctinfo;
                        break;
                    case 5:
                        addressBook[contactName]["State"] = Cotanctinfo;
                        break;
                    case 6:
                        addressBook[contactName]["Zip"] = Cotanctinfo;
                        break;
                    case 7:
                        addressBook[contactName]["Phone number"] = Cotanctinfo;
                        break;
                    case 8:
                        addressBook[contactName]["Email"] = Cotanctinfo;
                        break;

                }
            }
            else
            {
                Console.WriteLine("contact doesn't exist");
            }
        }
        public void DeleteContact()
        {
            Console.WriteLine("Enter contact name:");
            String ContactName = Console.ReadLine();
            if (addressBook.ContainsKey(ContactName))
            {
                addressBook.Remove(ContactName);
                Console.WriteLine("contact removed");
            }
            else
                Console.WriteLine("contact doesn't exist");
        }
        public void Display()
        {
            foreach (var contact in UC_1CreateContact)
            {
                Console.WriteLine(contact);
            }
        }
    }
}
