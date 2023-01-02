namespace PhoneBook
{
    internal static class UserInterface
    {
        internal static void ShowMainMenu()
        {
            Console.WriteLine("MENU");
            Console.WriteLine("1: Add new contact");
            Console.WriteLine("2: Show all contacts");
            Console.WriteLine("3: Show number for contact");
            Console.WriteLine("4: Show contact name for number");
            Console.WriteLine("5: Clear screen");
            Console.WriteLine("6: Exit Application");
            Console.WriteLine();
            Console.Write("Choose your action: ");
        }

        internal static string AskForname()
        {
            Console.Write("Please provide Name: ");
            return Console.ReadLine();
        }

        internal static string AskForNumber()
        {
            Console.Write("Please provide Number: ");
            return Console.ReadLine();
        }

        internal static void ClearScreen()
        {
            Console.Clear();
        }

        internal static void InvalidOperationMessage()
        {
            Console.WriteLine("Invalid operation");
            Console.WriteLine();
        }
    }
}
