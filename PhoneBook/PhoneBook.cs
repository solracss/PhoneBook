namespace PhoneBook
{
    internal class PhoneBook : IPhoneBook
    {
        public void AddContact(string number, Contact contact)
        {
            Contacts.Add(number, contact);
        }

        public void ShowAllContacts()
        {
            foreach (var contact in Contacts)
            {
                Console.WriteLine($"{contact.Value.Name} {contact.Value.PhoneNumber}");
            }
        }

        public void ShowContactNameForProvidedNumber(string contactNumber)
        {
            Contact contact = null;

            if (contactNumber == string.Empty)
            {
                Console.WriteLine("Please provide number");
            }
            else if (Contacts.TryGetValue(contactNumber, out contact))
            {
                Console.WriteLine($"Contact name for number {contactNumber} is {contact.Name}");
            }
            else
            {
                Console.WriteLine("No contact for the given number");
            }
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
