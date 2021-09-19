using System;

namespace Freight_Forwarder_Assistant_FFA
{
    class Program
    {
        //Stała
        public const string FILE_NAME = @"D:\szkolaDotNeta\FFA_project\ImportFile.xlsx";

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to FFA (Fright Forwarder Assistant");
            Console.WriteLine("Please select an option: ");
            Console.WriteLine("1. Add new client.");
            Console.WriteLine("2. Add new forwarder.");
            Console.WriteLine("3. Add new order/route.");
            Console.WriteLine("4. Raports.");
            Console.WriteLine("Please select the menu number.");

            string choice = Console.ReadLine();

            Console.WriteLine($"You chose the number {choice} menu.");

            int chosenOption = 0;
            int.TryParse(choice, out chosenOption);

        }
    }
}
