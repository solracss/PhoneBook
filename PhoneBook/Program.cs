namespace PhoneBook
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var uih = new UserInputHandler();
            var phoneBook = new PhoneBook(uih);
            while (true)
            {
                UserInterface.ShowMainMenu();
                var userInput = Console.ReadLine();
                phoneBook.Run(userInput);
            }
        }
    }
}
