namespace PhoneBook
{
    internal class PhoneBook : IPhoneBook
    {
        public void ShowAllContacts()
        {
            foreach (var contact in Contacts)
            {
                Console.WriteLine($"{contact.Value.Name} {contact.Value.PhoneNumber}");
            }
        }
    }
}
