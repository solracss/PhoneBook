namespace PhoneBook
{
    internal class PhoneBookManager
    {
        private IPhoneBook phoneBook;

        public PhoneBookManager(IPhoneBook phoneBook)
        {
            this.phoneBook = phoneBook;
        }

        public void Run(string userInput)
        {
            switch (userInput)
            {
                case "1":
                    phoneBook.AddContact();
                    break;

                case "2":
                    phoneBook.ShowAllContacts();
                    break;

                case "3":
                    phoneBook.ShowNumberForContact();
                    break;

                case "4":
                    phoneBook.ShowContactNameForProvidedNumber();
                    break;

                case "5":
                    Environment.Exit(0);
                    break;

                default:
                    UserInterface.InvalidOperationMessage();
                    break;
            }
        }
    }
}
