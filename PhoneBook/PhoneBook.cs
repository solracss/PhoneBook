using System.Xml.Linq;

namespace PhoneBook
{
    internal class PhoneBook : IPhoneBook
    {
        private Dictionary<string, Contact> _contacts = new Dictionary<string, Contact>()
        {
        };

        public Dictionary<string, Contact> Contacts
        {
            get { return _contacts; }
            set { _contacts = value; }
        }

        public void AddContact(string name, string phoneNumber)
        {
            var newContact = new Contact(name, phoneNumber);
            Contacts.Add(phoneNumber, newContact);
        }

        public void ShowAllContacts()
        {
            foreach (var contact in Contacts)
            {
                Console.WriteLine($"{contact.Value.Name} {contact.Value.PhoneNumber}");
            }
        }

        public void ShowContactNameForProvidedNumber(string number)
        {
            if (string.IsNullOrEmpty(number))
            {
                Console.WriteLine("Please provide number");
                return;
            }

            var contact = Contacts.FirstOrDefault(c => c.Key == number);
            if (contact.Key == null)
            {
                Console.WriteLine("No contact for the given number");
                return;
            }

            Console.WriteLine($"Contact name for number {number} is {contact.Value.Name}");
        }

        public void ShowNumberForContact(string contactName)
        {
            if (string.IsNullOrEmpty(contactName))
            {
                Console.WriteLine("Please provide name");
                return;
            }

            bool notFound = true;
            foreach (var contact in Contacts.Where(c => c.Value.Name == contactName))
            {
                Console.WriteLine($"Phone number for {contactName} is {contact.Key}");
                notFound = false;
            }

            if (notFound)
            {
                Console.WriteLine($"No contact for {contactName}");
            }
        }
    }
}
