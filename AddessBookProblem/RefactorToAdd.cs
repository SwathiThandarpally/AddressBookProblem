using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddessBookProblem
{
    internal class RefactorToAdd
    {
        Dictionary<string, string> contacts;
        Dictionary<string, Dictionary<string, string>> addressBook = new Dictionary<string, Dictionary<string, string>>();
        Dictionary<string, Dictionary<string, Dictionary<string, string>>> AddressBookCollection = new Dictionary<string, Dictionary<string, Dictionary<string, string>>>();
        String CurrentAddressBookName = "default";
        private readonly string contactName;

        public void PersonDetails()
        {
            PersonDetails(contacts);
        }

        public void PersonDetails(Dictionary<string, string> contacts)
        {
            contacts = new Dictionary<string, string>();

            Console.Write("Firstname :");
            contacts.Add("Firstname", Console.ReadLine());

            Console.WriteLine("Lastname :");
            contacts.Add("Firstname", Console.ReadLine());

            Console.WriteLine("PhoneNumber :");
            contacts.Add("PhoneNumber", Console.ReadLine());

            Console.WriteLine("Email-Id :");
            contacts.Add("Email-Id", Console.ReadLine());

            Console.WriteLine("Address :");
            contacts.Add("Address", Console.ReadLine());

            Console.WriteLine("City :");
            contacts.Add("City", Console.ReadLine());

            Console.WriteLine("State :");
            contacts.Add("State", Console.ReadLine());

            Console.WriteLine("Zipcode :");
            contacts.Add("Zipcode", Console.ReadLine());

            contacts.TryGetValue("FirstName", out string FirstName);
            contacts.TryGetValue("LastName", out string LastName);
            addressBook.Add(FirstName + "" + LastName, contacts);
            Console.WriteLine("contact added \n");
        }

        public void Display()
        {
            Console.WriteLine("Enter your full name :");
            string contactName = Console.ReadLine();

            if (addressBook.ContainsKey(contactName))
            {
                contacts = new Dictionary<string, string>();
                addressBook.TryGetValue(contactName, out contacts);
                Console.WriteLine("FirstName: " + contacts["first Name"]);

                Console.WriteLine("LastName: " + contacts["last Name"]);

                Console.WriteLine("PhoneNumber: " + contacts["phone number"]);

                Console.WriteLine("Email id: " + contacts["Email id"]);

                Console.WriteLine("Address: " + contacts["Address"]);

                Console.WriteLine("City: " + contacts["City"]);

                Console.WriteLine("State: " + contacts["State"]);

                Console.WriteLine("ZipCode: " + contacts["ZipCode"]);
            }
            else
            {
                Console.WriteLine("contact doesn't support");

            }
        }

        public void EditContact()
        {
            Console.WriteLine("Enter full contact name");
            string contactname = Console.ReadLine();

            if (addressBook.ContainsKey(contactname))
            {
                Console.WriteLine("Select option you want to edit: ");
                Console.WriteLine("1.First Name 2.Last Name 3.Phone Number 4.Email Id 5.Address 6.City 7.State 8.Zipcode");

                int option = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Contact filed:");

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

        public void CreateAddressBook()
        {
            addressBook = new Dictionary<string, Dictionary<string, string>>();
            Console.WriteLine("Address Book Name: ");
            string addressBookName = Console.ReadLine();
            if (AddressBookCollection.ContainsKey(addressBookName))
                Console.WriteLine("Address Book already exist");
            else
            {
                AddressBookCollection.Add(addressBookName, addressBook);
                CurrentAddressBookName = addressBookName;
                Console.WriteLine("Address Book created");
            }
        }
        public void ChangeAddressBook()
        {
            Console.WriteLine("Enter Address Book Name:");
            string addressBookName = Console.ReadLine();
            if (AddressBookCollection.ContainsKey(addressBookName))
            {
                CurrentAddressBookName = addressBookName;
                Console.WriteLine("Address Book changed");
            }
            else
                Console.WriteLine("Address Book doesn't exist");
        }


        public void display()
        {
            foreach (var contact in contacts)
            {
                Console.WriteLine(contact);
            }
        }
    }

}
        

                 


                

                

            


        

    
    

