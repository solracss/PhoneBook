using Castle.MicroKernel.Registration;
using Castle.Windsor;

namespace PhoneBook
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var container = new WindsorContainer();
            container.Register(Component.For<IPhoneBook>().ImplementedBy<PhoneBook>());
            container.Register(Component.For<PhoneBookManager>());
            var phoneBook = container.Resolve<PhoneBookManager>();

            while (true)
            {
                UserInterface.ShowMainMenu();
                var userInput = Console.ReadLine();
                phoneBook.Run(userInput);
            }
        }
    }
}
