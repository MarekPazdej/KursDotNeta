using System;
using System.Collections.Generic;
using System.Text;

namespace Freight_Forwarder_Assistant_FFA
{
    public class MenuSelection
    {
        public int Id { get; set; }
        public string MenuSelectionName { get; set; }
        public string MenuOfType { get; set; }

        public MenuSelection(int id)
        {
            Id = id;
        }

        public  MenuSelection(int id, string menuSelectionName)
        {
            Id = id;
            MenuSelectionName = menuSelectionName;
        }
    }
}
