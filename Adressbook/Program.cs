namespace Adressbook
{
    internal class Program
    {
        static List<Contact> listcontacts = new List<Contact>();
        static void Main(string[] args)
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

            Contact newContact = new Contact(FirstName, LastName, Address, City, State, Zip, PhoneNumber, Email);
            Console.WriteLine("Contact details");
            Console.WriteLine(newContact);

        }
    }
}

