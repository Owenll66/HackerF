using System;
using System.Collections.Generic;
using System.Linq;

using HackerF.Interface;

namespace HackerF.Model
{
    public class CheatingSheet
    {
        public static List<Hotkey> HotKeys { get; set; }
        private IHotkeyFunctionService _hotkeyFunctionService { get; set; }

        public CheatingSheet(IHotkeyFunctionService hotkeyFunctionService) 
        {
            _hotkeyFunctionService = hotkeyFunctionService;
        }

        public void Initialise() 
        {
            HotKeys = new List<Hotkey>();
            var initialHotkeys = new List<Hotkey>
            {
                new Hotkey
                { 
                    Name = "F1",
                    Description = "Plant Bomb", key = ConsoleKey.F1,
                    ExecutionFunction = _hotkeyFunctionService.PlantBomb
                },

                new Hotkey() 
                { 
                    Name = "F2", 
                    Description = "Install Virus", 
                    key = ConsoleKey.F2,
                    ExecutionFunction = _hotkeyFunctionService.InstallVirus
                },

                new Hotkey
                {
                    Name = "F9",
                    Description = "Show Hacking Menu", key = ConsoleKey.F9,
                    ExecutionFunction = _hotkeyFunctionService.ShowMenu
                }
            };

            HotKeys.AddRange(initialHotkeys);
        }
    }
}