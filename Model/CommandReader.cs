using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

using HackerF.Interface;

namespace HackerF.Model
{
    public class CommandReader : ICommandReader
    {
        private IHotkeyMenu _hotkeyMenu;

        public CommandReader(IHotkeyMenu hotkeyMenu)
        {
            _hotkeyMenu = hotkeyMenu;

            Thread commandReader = new Thread(new ThreadStart(ReadKey));
            commandReader.Start();
        }

        public void ReadKey()
        {
            while (true)
            {
                var key = Console.ReadKey(true);
                checkHotkey(key);

                if (key.Key == ConsoleKey.Escape)
                    System.Environment.Exit(0);
            }
        }

        private void checkHotkey(ConsoleKeyInfo key)
        {
            var hotkey = _hotkeyMenu
                .GetHotkeys()
                .Where(h => h.key == key.Key)
                .FirstOrDefault();

            if (hotkey != null)
                Console.WriteLine(hotkey.Description);
            else
                PrintCodeScript();
        }

        private void PrintCodeScript()
        {
            
        }
    }
}
