using System.Xml.Linq;

namespace PhoneBook
{
    internal interface IPhoneBook
    {
        void ShowAllContacts();

        void AddContact();

        void ShowNumberForContact(string contactName);

        void ShowContactNameForProvidedNumber(string contactNumber);
    }
}
