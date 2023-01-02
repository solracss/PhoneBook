namespace PhoneBook
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("MENU");
            Console.WriteLine("1: Add new contact");
            Console.WriteLine("2: Show all contacts");
            Console.WriteLine("3: Show number for contact");
            Console.WriteLine("4: Show contact name for number");
            Console.WriteLine();
            Console.WriteLine("Choose your action");

            var phoneBook = new PhoneBook();
            phoneBook.ShowAllContacts();
            var input = Console.ReadLine();

            phoneBook.ShowContactNameForProvidedNumber(input);
        }
    }
}
