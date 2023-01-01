namespace PhoneBook
{
    internal interface IPhoneBook
    {
        void ShowAllContacts();

        void AddContact(string number, Contact contact);

        void ShowNumberForContact(string contactName);

        void ShowContactNameForProvidedNumber(string contactNumber);
    }
}
