using System.Xml.Linq;

namespace PhoneBook
{
    internal interface IPhoneBook
    {
        void ShowAllContacts();

        void AddContact(string name, string phoneNumber);

        void ShowNumberForContact(string contactName);

        void ShowContactNameForProvidedNumber(string contactNumber);
    }
}
