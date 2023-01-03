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

        public void AddContact()
        {
            Console.Clear();
            Console.WriteLine("Adding new contact\n");
            var name = UserInterface.AskForName();
            var phoneNumber = UserInterface.AskForNumber();
            var newContact = new Contact(name, phoneNumber);
            Contacts.Add(phoneNumber, newContact);
            Console.WriteLine($"\nNew contact is {name} with number {phoneNumber}");
            ReturnToMainMenu();
        }

        public void ShowAllContacts()
        {
            Console.Clear();
            Console.WriteLine("List of contacts in phonebook\n");
            if (Contacts.Count == 0)
            {
                Console.WriteLine("Phonebook is empty");
                Console.WriteLine();
            }
            else
            {
                foreach (var contact in Contacts)
                {
                    Console.WriteLine($"{contact.Value.Name} {contact.Value.PhoneNumber}");
                }
            }

            ReturnToMainMenu();
        }

        public void ShowContactNameForProvidedNumber()
        {
            Console.Clear();
            Console.WriteLine("Searching for name\n");
            var number = HandleEmptyInput(UserInterface.AskForNumber);

            var contact = Contacts.FirstOrDefault(c => c.Key == number);
            if (contact.Key == null)
            {
                Console.WriteLine("\nNo contact for the given number");
                ReturnToMainMenu();
                return;
            }

            Console.WriteLine($"\nContact name for number {number} is {contact.Value.Name}");
            ReturnToMainMenu();
        }

        public void ShowNumberForContact()
        {
            Console.Clear();
            Console.WriteLine("Searching for contact\n");
            var contactName = HandleEmptyInput(UserInterface.AskForName);

            bool notFound = true;
            foreach (var contact in Contacts.Where(c => c.Value.Name == contactName))
            {
                Console.WriteLine($"\nPhone number for {contactName} is {contact.Key}");
                notFound = false;
            }

            if (notFound)
            {
                Console.WriteLine($"\nNo contact for {contactName}");
            }

            ReturnToMainMenu();
        }

        private static string HandleEmptyInput(Func<string> askForInput)
        {
            var str = string.Empty;
            while (string.IsNullOrEmpty(str))
            {
                str = askForInput();
            }

            return str;
        }

        public static void ReturnToMainMenu()
        {
            Console.Write("\r\nPress any key to return to Main Menu");
            Console.ReadKey();
        }

        public void Run(string userInput)
        {
            switch (userInput)
            {
                case "1":
                    AddContact();
                    break;

                case "2":
                    ShowAllContacts();
                    break;

                case "3":
                    ShowNumberForContact();
                    break;

                case "4":
                    ShowContactNameForProvidedNumber();
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
