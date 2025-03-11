namespace Adressbook
{
    internal class Program
    {
        static List<Contact> listcontacts = new List<Contact>;
        static void Main(string[] args)
        {

            Contact newcontact = new Contact("rahul", "rai", "123  ", "Panchkula", "HR", "62701", "217 - 555 - 1234", "john@gmai.com");
            listcontacts.Add(newcontact);
            Console.WriteLine("new contact added");
        }
    }
}

//Ability to create a Contacts in Address
//Book with first and last names, address,
//city, state, zip, phone number and
//email…
//- Program is written using IDE like Visual Studio
//- Every UC is in a separate Git Branch and then merged with main
//- Naming Convention, Indentation, etc Code Hygiene will be checked during
//Review
//- Git Check In Comments and Version History will be monitored