using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddessBookProblem
{
    internal class Edit
    {
        UC_1CreateContact contact = new UC_1CreateContact();
        List<UC_1CreateContact> addressBook = new List<UC_1CreateContact>();
        public void print()
        {
            Console.WriteLine("Contact Derails : " + "\n" + "First Name : " + contact.Firstname + "\n" + "Last Name : " + contact.Lastname
                                + "\n" + "Address is : " + contact.Address + "\n" + "City is : " + contact.City + "\n" + "State is : " + contact.State
                                + "\n" + "Zip is : " + contact.Zipcode + "\n" + "Phone Number is :" + contact.Phonenumber + "\n" + "Email is : " + contact.Email);
        }
        public void createContact()
        {
            contact.Firstname = Console.ReadLine();
            contact.Lastname = Console.ReadLine();
            contact.Address = Console.ReadLine();
            contact.City = Console.ReadLine();
            contact.State = Console.ReadLine();
            contact.Phonenumber = Convert.ToInt32(Console.ReadLine());
            contact.Email = Console.ReadLine();
            contact.Zipcode = Convert.ToInt32(Console.ReadLine());
            addressBook.Add(contact);
        }
        public void Editing(string name)
        {
            createContact();
            foreach (var contact in addressBook)
            {
                if ((contact.Firstname.Equals(name)) || (contact.Lastname.Equals(name)))
                {
                    Console.WriteLine("1.FirstName 2.LastName 3.Address 4.City 5.State 6.Zip 7.PhoneNumber 8.Email");
                    int option = Convert.ToInt32(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            contact.Firstname = Console.ReadLine();
                            break;
                        case 2:
                            contact.Lastname = Console.ReadLine();
                            break;
                        case 3:
                            contact.City = Console.ReadLine();
                            break;
                        case 4:
                            contact.State = Console.ReadLine();
                            break;
                        case 5:
                            contact.Zipcode = Convert.ToInt32(Console.ReadLine());
                            break;
                        case 6:
                            break;
                        case 7:
                            contact.Phonenumber = Convert.ToInt32(Console.ReadLine());
                            break;
                        case 8:
                            contact.Email = Console.ReadLine();
                            break;
                    }
                    print();
                }
            }
        }

    }
}
