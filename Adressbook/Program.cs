namespace Adressbook
{
    using System.Collections.Generic;
    internal class Program
    {
        static void Manageaddressbook(Addressbook myab)
        {
            if (myab == addressbooks["pkl"])
            {
                Contact c1 = new Contact("rahul", "rai", "123", "Panchkula", "HR", "62701", "10", "rahul@gmail.com");
                myab.Addcontact(c1);
            }
            else if(myab == addressbooks["chd"])
            {
                Contact c2 = new Contact("john", "martin", "292", "chd", "Chandigarh", "134908", "20", "john@gmail.com");
                myab.Addcontact(c2);
            }
               

            while (true)
            {
                Console.WriteLine("\n1. Add Contact\n2. Display Contacts\n3. Update Contact\n4. Delete Contact\n5. Exit");
                Console.Write("Choose an option: ");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter First Name: ");
                        string FirstName = Console.ReadLine();

                        Console.Write("Enter Last Name: ");
                        string LastName = Console.ReadLine();

                        Console.Write("Enter Address: ");
                        string Address = Console.ReadLine();

                        Console.Write("Enter City: ");
                        string City = Console.ReadLine();

                        Console.Write("Enter State: ");
                        string State = Console.ReadLine();

                        Console.Write("Enter Zip Code: ");
                        string Zip = Console.ReadLine();

                        Console.Write("Enter Phone Number: ");
                        string PhoneNumber = Console.ReadLine();

                        Console.Write("Enter Email: ");
                        string Email = Console.ReadLine();

                        Contact newContact = new Contact(FirstName, LastName, Address, City, State, Zip, PhoneNumber, Email);
                        myab.Addcontact(newContact);
                        break;

                    case 2:
                        myab.DisplayContacts();
                        break;

                    case 3:
                        Console.Write("Enter the contact name to update: ");
                        string nameToUpdate = Console.ReadLine();
                        myab.Updatecontact(nameToUpdate);
                        break;

                    case 4:
                        Console.Write("Enter the contact name to delete: ");
                        string deleteName = Console.ReadLine();
                        myab.Deletecontact(deleteName);
                        break;

                    case 5:
                        Console.WriteLine("Exiting...");
                        return;

                    default:
                        Console.WriteLine("Invalid choice, try again.");
                        break;
                }
            }
        }

        static Dictionary<string, Addressbook> addressbooks = new Dictionary<string, Addressbook>();
        static void Main(string[] args)
        {

            addressbooks.Add("pkl", new Addressbook());
            addressbooks.Add("chd", new Addressbook());


            while (true)
            {
                Console.WriteLine("\n1. Create New Address Book \n2. Select Adressbook \n3.List Addressbook \n4.Exit ");
                Console.WriteLine("choose and option");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter name of new Addressbook:");
                        string bookname = Console.ReadLine();
                        if (addressbooks.ContainsKey(bookname))
                        {
                            Console.WriteLine("Addressbook already exists");
                        }
                        else
                        {
                            addressbooks.Add(bookname, new Addressbook());
                            Console.WriteLine($"Address Book '{bookname}' created successfully!");
                        }
                        break;
                    case 2:
                        Console.WriteLine("Enter the address book name to select :");
                        string selectbookname = Console.ReadLine();
                        if (addressbooks.ContainsKey(selectbookname))
                        {
                            Manageaddressbook(addressbooks[selectbookname]);
                        }
                        else
                        {
                            Console.WriteLine("Address book not found");
                        }
                        break;
                    case 3:
                        Console.WriteLine("\nAvailable Address Books:");
                        foreach (var book in addressbooks)
                        {
                            Console.WriteLine(book.Key);
                        }
                        break;
                    case 4:
                        Console.WriteLine("Exiting...");
                        return;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;

                }
            }
        }
    }
}

