using System;
using System.Collections.Generic;
using System.Text;

namespace Freight_Forwarder_Assistant_FFA
{
    public class MenuSelectionService
    {
        private List<MenuSelection> menuSelections;

        public MenuSelectionService()
        {
            menuSelections = new List<MenuSelection>();
        }

        public void AddNewSelectionToMenu (int id, string menuSelectionName, string menuOfType)
        {
            MenuSelection menuSelection = new MenuSelection(id, menuSelectionName){Id = id, MenuSelectionName = menuSelectionName, MenuOfType = menuOfType };
            menuSelections.Add(menuSelection);
        }

        public List<MenuSelection> GetmenuSelectionByMenuOfType(string menuOfType)
        {
            List<MenuSelection> result = new List<MenuSelection>();
            foreach (var menuSelection in menuSelections)
            {
                if (menuSelection.MenuOfType == menuOfType)
                {
                    result.Add(menuSelection);
                }
            }
            return result;
        }
    }
}
