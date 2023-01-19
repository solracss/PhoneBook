namespace PhoneBook
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var phoneBook = new PhoneBookManager(new PhoneBook());
            while (true)
            {
                UserInterface.ShowMainMenu();
                var userInput = Console.ReadLine();
                phoneBook.Run(userInput);
            }
        }
    }
}
