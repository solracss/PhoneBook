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
            Console.WriteLine("Adding new contact");
            var name = UserInterface.AskForname();
            var phoneNumber = UserInterface.AskForNumber();
            var newContact = new Contact(name, phoneNumber);
            Contacts.Add(phoneNumber, newContact);
            Console.WriteLine($"\nNew contact is {name} with number {phoneNumber}");
            ReturnToMainMenu();
        }

        public void ShowAllContacts()
        {
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
        }

        public void ShowContactNameForProvidedNumber(string number)
        {
            if (string.IsNullOrEmpty(number))
            {
                Console.WriteLine("Please provide number");
                Console.WriteLine();
                return;
            }

            var contact = Contacts.FirstOrDefault(c => c.Key == number);
            if (contact.Key == null)
            {
                Console.WriteLine("No contact for the given number");
                Console.WriteLine();
                return;
            }

            Console.WriteLine($"Contact name for number {number} is {contact.Value.Name}");
            Console.WriteLine();
        }

        public void ShowNumberForContact(string contactName)
        {
            if (string.IsNullOrEmpty(contactName))
            {
                Console.WriteLine("Please provide name");
                Console.WriteLine();
                return;
            }

            bool notFound = true;
            foreach (var contact in Contacts.Where(c => c.Value.Name == contactName))
            {
                Console.WriteLine($"Phone number for {contactName} is {contact.Key}\n");
                notFound = false;
            }

            if (notFound)
            {
                Console.WriteLine($"No contact for {contactName}");
                Console.WriteLine();
            }
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
                    ShowNumberForContact(UserInterface.AskForNumber());
                    break;

                case "4":
                    ShowContactNameForProvidedNumber(UserInterface.AskForNumber());
                    break;

                case "5":
                    UserInterface.ClearScreen();
                    break;

                case "6":
                    Environment.Exit(0);
                    break;

                default:
                    UserInterface.InvalidOperationMessage();
                    break;
            }
        }
    }
}
