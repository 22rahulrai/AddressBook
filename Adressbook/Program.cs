namespace Adressbook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Addressbook myab = new Addressbook();

            Contact c1 = new Contact("rahul", "rai", "123  ", "Panchkula", "HR", "62701", "10", "rahul@gmai.com");
            Contact c2 = new Contact("john", "martin", "292  ", "Panchkula", "HR", "62701", "20", "john@gmai.com");
            myab.Addcontact(c1);
            myab.Addcontact(c2);

            while (true)
            {
                Console.WriteLine("\n1. Add Contact\n2. Display Contacts\n3. Update Contacts\n4. Exit");
                Console.Write("Choose an option: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 1)
                {
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

                    Contact newcontact = new Contact(FirstName, LastName, Address, City, State, Zip, PhoneNumber, Email);

                    myab.Addcontact(newcontact);
                }
                else if (choice == 2)
                {
                    myab.DisplayContacts();
                }
                else if (choice == 3)
                {
                    Console.WriteLine("Enter the contact name to update contact");
                    string nametoupdate = Console.ReadLine();
                    myab.Updatecontact(nametoupdate);
                }
                else if (choice == 4)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid choice, try again.");
                }
            }
        }
    }
}
