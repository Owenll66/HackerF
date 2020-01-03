using System;
using System.Collections.Generic;
using System.Linq;

using HackerF.Interface;

namespace HackerF.Model
{
    public class CheatingSheet : IMenu
    {
        public List<Hotkey> Items { get; set; }

        public CheatingSheet() 
        {
            Items = new List<Hotkey>();
            InitialiseCheatingSheet();
        }

        private void InitialiseCheatingSheet() 
        {
            var initialHotkeys = new List<Hotkey>
            {
                new Hotkey() { HotkeyName = "F1", Description = "Plant Bomb"},
                new Hotkey() { HotkeyName = "F2", Description = "Install Virus"}
            };

            Items.AddRange(initialHotkeys);
        }

        public void Show()
        {
            for (var i = 0; i < Items.Count(); i++)
            {
                Console.WriteLine($"{Items[i].HotkeyName}: {Items[i].Description}");
            }
        }
    }
}