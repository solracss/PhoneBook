using System.Xml.Linq;

namespace PhoneBook
{
    internal interface IPhoneBook
    {
        void ShowAllContacts();

        void AddContact();

        void ShowNumberForContact();

        void ShowContactNameForProvidedNumber();
    }
}
