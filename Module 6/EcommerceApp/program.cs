using System;

namespace EcommerceApp
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("=== E-commerce System Test Menu ===");
                Console.WriteLine("1. Run Unit Tests");
                Console.WriteLine("2. Run Integration Tests");
                Console.WriteLine("3. Exit");
                Console.Write("Please select an option: ");

                var option = Console.ReadLine();
                if (option == "1")
                {
                    Console.WriteLine("Unit tests can be run from the Test Explorer in Visual Studio.");
                }
                else if (option == "2")
                {
                    Console.WriteLine("Integration tests can be run from the Test Explorer in Visual Studio.");
                }
                else if (option == "3")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid option. Please try again.");
                }

                Console.WriteLine("Press any key to return to the menu...");
                Console.ReadKey();
            }
        }
    }
}
