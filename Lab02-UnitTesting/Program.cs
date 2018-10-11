using System;

namespace Lab02_UnitTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            Interface();
        }

        public static void Interface()
        {
            string userMenuSelection;
            Console.WriteLine("1. View Balance");
            Console.WriteLine("2. Withdraw Money");
            Console.WriteLine("3. Add Money");
            Console.WriteLine("4. Exit");
            userMenuSelection = Console.ReadLine();

            switch(userMenuSelection)
            {
                case "1":
                    Console.WriteLine("You have selected view balance");
                    break;
                case "2":
                    Console.WriteLine("You have selected to withdraw");
                    break;
                case "3":
                    Console.WriteLine("You have selected to add money");
                    break;
                case "4":
                    Console.WriteLine("You have selected to exit");
                    break;
                default:
                    Console.WriteLine("You have selected something off the menu");
                    break;
            }
        }

    }
}
