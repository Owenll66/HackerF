using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;

using HackerF.Interface;

namespace HackerF.Model
{
    public class CommandReader : ICommandReader
    {
        private readonly string _hackScriptLocaton = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"HackerScripts\HackerScript1.txt");
        private static int _currentScriptPosition;
        private static string _script;

        private IHotkeyMenu _hotkeyMenu;
        private IFileReader _fileReader;
        private IDelayPrintService _delayPrintService;

        public CommandReader(IHotkeyMenu hotkeyMenu, IFileReader fileReader, IDelayPrintService delayPrintService)
        {
            _hotkeyMenu = hotkeyMenu;
            _fileReader = fileReader;
            _delayPrintService = delayPrintService;

            _script = _fileReader.ReadFile(_hackScriptLocaton);
            _currentScriptPosition = 0;
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

        private void PrintCodeScript(int typeSpeed = 2)
        {
            if (_currentScriptPosition + typeSpeed > _script.Length)
                _currentScriptPosition = 0;

            _delayPrintService.DelayPrintText(_script.Substring(_currentScriptPosition, typeSpeed), 30);

            _currentScriptPosition = _currentScriptPosition + typeSpeed;
        }
    }
}
