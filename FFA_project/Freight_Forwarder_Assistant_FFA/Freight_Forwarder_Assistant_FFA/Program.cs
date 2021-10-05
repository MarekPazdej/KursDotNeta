using System;

namespace Freight_Forwarder_Assistant_FFA
{
    class Program
    {
        //Stała
        public const string FILE_NAME = @"D:\szkolaDotNeta\FFA_project\ImportFile.xlsx";

        static void Main(string[] args)
        {
            MenuSelectionService menuSelection = new MenuSelectionService();
            menuSelection = Initialize(menuSelection);

            Console.WriteLine("Welcome to FFA (Fright Forwarder Assistant)\n");
            Console.WriteLine("Please select an option: \n");
            var mainMenu = menuSelection.GetmenuSelectionByMenuOfType("Main");
            for (int i = 0; i < mainMenu.Count; i++)
            {
                Console.WriteLine($"{mainMenu[i].Id}. {mainMenu[i].MenuSelectionName}");
            }
            //Console.WriteLine("1. Add new client.");
            //Console.WriteLine("2. Add new forwarder.");
            //Console.WriteLine("3. Add new order/route.");
            //Console.WriteLine("4. Raports.");
            //Console.WriteLine("Please select the menu number."); 
        }

        private static MenuSelectionService Initialize(MenuSelectionService menuSelection)
        {
            menuSelection.AddNewSelectionToMenu(1, "Add new client", "Main");
            menuSelection.AddNewSelectionToMenu(2, "Add new carrier", "Main");
            menuSelection.AddNewSelectionToMenu(3, "Show cargo route", "Main");
            menuSelection.AddNewSelectionToMenu(4, "Reports", "Main");
            menuSelection.AddNewSelectionToMenu(5, "Delete options", "Main");
            return menuSelection;
        }
    }
}
