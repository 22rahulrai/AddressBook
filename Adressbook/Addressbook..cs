using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adressbook
{
    class Addressbook
    {
        private List<Contact> listcontacts = new List<Contact>();
        public  void Updatecontact(string fname)
        {
            Contact contact = listcontacts.Find(c => c.FirstName.Equals(fname, StringComparison.OrdinalIgnoreCase));

            if (contact == null)
            {
                Console.WriteLine("\ncontact not found");
            }

            Console.WriteLine("\nEditing Contact: " + contact.FirstName);

            Console.Write("Enter New Last Name: ");
            contact.LastName = Console.ReadLine();

            Console.Write("Enter New Address: ");
            contact.Address = Console.ReadLine();

            Console.Write("Enter New City: ");
            contact.City = Console.ReadLine();

            Console.Write("Enter New State: ");
            contact.State = Console.ReadLine();

            Console.Write("Enter New Zip Code: ");
            contact.Zip = Console.ReadLine();

            Console.Write("Enter New Phone Number: ");
            contact.PhoneNumber = Console.ReadLine();

            Console.Write("Enter New Email: ");
            contact.Email = Console.ReadLine();

            Console.WriteLine("\nContact Updated Successfully!");

        }

        public  void Addcontact(Contact contact)
        {
            listcontacts.Add(contact);
            Console.WriteLine("\nContact Added successfully!");
        }


        public void DisplayContacts()
        {
            if (listcontacts.Count == 0)
            {
                Console.WriteLine("\nAddress book is empty.");
                return;
            }

            Console.WriteLine("\nContacts in Address Book:");
            foreach (var contact in listcontacts)
            {
                Console.WriteLine(contact);
                Console.WriteLine("---------------------------");
            }
        }

    }
}
