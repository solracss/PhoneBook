namespace PhoneBook
{
    internal static class UserInterface
    {
        internal static void ShowMainMenu()
        {
            var logo = @"   ____                      _        ____  _                      _                 _
  / ___|___  _ __  ___  ___ | | ___  |  _ \| |__   ___  _ __   ___| |__   ___   ___ | | __
 | |   / _ \| '_ \/ __|/ _ \| |/ _ \ | |_) | '_ \ / _ \| '_ \ / _ | '_ \ / _ \ / _ \| |/ /
 | |__| (_) | | | \__ | (_) | |  __/ |  __/| | | | (_) | | | |  __| |_) | (_) | (_) |   <
  \____\___/|_| |_|___/\___/|_|\___| |_|   |_| |_|\___/|_| |_|\___|_.__/ \___/ \___/|_|\_\
                                                                                          ";
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Clear();
            Console.WriteLine(logo);
            Console.WriteLine(" ************* MENU ******************");
            Console.WriteLine(" *  1: Add new contact               *");
            Console.WriteLine(" *  2: Show all contacts             *");
            Console.WriteLine(" *  3: Show number for contact       *");
            Console.WriteLine(" *  4: Show contact name for number  *");
            Console.WriteLine(" *  5: Exit Application              *");
            Console.WriteLine(" *************************************");
            Console.WriteLine();
            Console.Write(" Choose your action and press enter: ");
        }

        internal static string AskForName()
        {
            Console.Write(" Please provide Name: ");
            return Console.ReadLine();
        }

        internal static string AskForNumber()
        {
            Console.Write(" Please provide Number: ");
            return Console.ReadLine();
        }

        internal static void ClearScreen()
        {
            Console.Clear();
        }

        internal static void InvalidOperationMessage()
        {
            Console.WriteLine("\n Invalid operation");
            PhoneBook.ReturnToMainMenu();
        }
    }
}
