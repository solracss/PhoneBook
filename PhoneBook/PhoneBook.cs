namespace PhoneBook
{
    internal class PhoneBook : IPhoneBook
    {
        private Dictionary<string, Contact> contacts { get; }

        public PhoneBook()
        {
            contacts = new Dictionary<string, Contact>()
            {
                { "123456789", new Contact("James", "123456789") }
            };
        }

        public void AddContact()
        {
            Console.Clear();
            Console.WriteLine(" ***** Adding new contact *****\n");
            var name = UserInterface.AskForName();
            var phoneNumber = UserInterface.AskForNumber();
            if (contacts.ContainsKey(phoneNumber))
            {
                Console.WriteLine(" Number already in phonebook");
            }
            else
            {
                var newContact = new Contact(name, phoneNumber);
                contacts.Add(phoneNumber, newContact);
                Console.WriteLine($"\n New contact is \"{name}\" with number \"{phoneNumber}\"");
            }

            ReturnToMainMenu();
        }

        public void ShowAllContacts()
        {
            Console.Clear();
            Console.WriteLine(" *****List of contacts in phonebook *****\n");
            if (contacts.Count == 0)
            {
                Console.WriteLine(" Phonebook is empty");
            }
            else
            {
                var i = 1;
                foreach (var contact in contacts)
                {
                    Console.WriteLine($" {i}.\t{contact.Value.Name} {contact.Value.PhoneNumber}");
                    i++;
                }
            }

            ReturnToMainMenu();
        }

        public void ShowContactNameForProvidedNumber()
        {
            Console.Clear();
            Console.WriteLine(" ***** Searching for name *****\n");
            var number = HandleEmptyInput(UserInterface.AskForNumber);

            var contact = contacts.FirstOrDefault(c => c.Key == number);
            if (contact.Key == null)
            {
                Console.WriteLine("\n No contact for the given number");
                ReturnToMainMenu();
                return;
            }

            Console.WriteLine($"\n Contact name for number \"{number}\" is \"{contact.Value.Name}\"");
            ReturnToMainMenu();
        }

        public void ShowNumberForContact()
        {
            Console.Clear();
            Console.WriteLine(" ***** Searching for contact *****\n");
            var contactName = HandleEmptyInput(UserInterface.AskForName);

            if (!contacts.Any(c => c.Value.Name == contactName))
            {
                Console.WriteLine($"\n No contact for \"{contactName}\"");
            }
            else
            {
                foreach (var contact in contacts.Where(c => c.Value.Name == contactName))
                {
                    Console.WriteLine($"\n Phone number for \"{contactName}\" is \"{contact.Key}\"");
                }
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
            Console.Write("\n Press any key to return to Main Menu...");
            Console.ReadKey();
        }
    }
}
