using System;
using System.Collections.Generic;
using System.Linq;

using HackerF.Interface;

namespace HackerF.Model
{
    public class CheatingSheet : IHotkeyMenu
    {
        private List<Hotkey> _hotkeys { get; set; }

        public CheatingSheet() 
        {
            _hotkeys = new List<Hotkey>();
            InitialiseCheatingSheet();
        }

        private void InitialiseCheatingSheet() 
        {
            var initialHotkeys = new List<Hotkey>
            {
                new Hotkey() { HotkeyName = "F1", Description = "Plant Bomb", key = ConsoleKey.F1},
                new Hotkey() { HotkeyName = "F2", Description = "Install Virus", key = ConsoleKey.F2}
            };

            _hotkeys.AddRange(initialHotkeys);
        }

        public void Show()
        {
            for (var i = 0; i < _hotkeys.Count(); i++)
            {
                Console.WriteLine($"{_hotkeys[i].HotkeyName}: {_hotkeys[i].Description}");
            }
        }

        public List<Hotkey> GetHotkeys()
        {
            return _hotkeys;
        }
    }
}