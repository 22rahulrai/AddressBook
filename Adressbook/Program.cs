namespace Adressbook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Addressbook myab = new Addressbook();

            Contact c1 = new Contact("rahul", "rai", "123", "Panchkula", "HR", "62701", "10", "rahul@gmail.com");
            Contact c2 = new Contact("john", "martin", "292", "Panchkula", "HR", "62701", "20", "john@gmail.com");
            myab.Addcontact(c1);
            myab.Addcontact(c2);

            while (true)
            {
                Console.WriteLine("\n1. Add Contact\n2. Display Contacts\n3. Update Contact\n4. Delete Contact\n5. Exit");
                Console.Write("Choose an option: ");

                int choice=int.Parse(Console.ReadLine());

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
    }
}
