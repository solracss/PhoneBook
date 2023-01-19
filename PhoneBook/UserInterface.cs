using System.Text.RegularExpressions;

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
            var regex = new Regex(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{3,7})$");
            Console.Write("\n Please provide Number ");
            Console.Write("(Accepting only \"0-9\" \".\" \"-\"): ");
            var number = Console.ReadLine();
            bool isMatch = regex.IsMatch(number);
            while (!regex.IsMatch(number))
            {
                Console.Write(" Wrong format, please provide valid number: ");
                number = Console.ReadLine();
            }
            return number;
        }

        internal static void InvalidOperationMessage()
        {
            Console.WriteLine("\n Invalid operation");
            Console.Write("\n Press any key to return to Main Menu...");
            Console.ReadKey();
        }
    }
}
