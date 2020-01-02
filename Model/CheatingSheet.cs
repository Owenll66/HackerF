using System;
using System.Collections.Generic;
using System.Linq;

using HackerF.Interface;

namespace HackerF.Model
{
    public class CheatingSheet : IMenu
    {
        public IList<IMenuItem> Items { get; set; }

        public CheatingSheet(IList<IMenuItem> menuItems) 
        {
            Items = menuItems;
        }

        public void Initialise()
        {
            
        }

        public void Show()
        {
            for (var i = 0; i < Items.Count(); i++)
            {
                Console.WriteLine($"{i} Hotkey: {Items[i].Description}");
            }
        }
    }
}
