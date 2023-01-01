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
    }
}
