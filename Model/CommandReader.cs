﻿using System;
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

        private IFileReader _fileReader;
        private IPrintService _delayPrintService;

        public CommandReader(IFileReader fileReader, IPrintService delayPrintService)
        {
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
                CheckHotkey(key);

                if (key.Key == ConsoleKey.Escape)
                    System.Environment.Exit(0);
            }
        }

        private void CheckHotkey(ConsoleKeyInfo key)
        {
            var hotkey = CheatingSheet.HotKeys
                .Where(h => h.key == key.Key)
                .FirstOrDefault();

            if (hotkey != null)
                hotkey.ExecutionFunction.Invoke();
            else
                PrintCodeScript();
        }

        private void PrintCodeScript(int typeSpeed = 2)
        {
            if (_currentScriptPosition + typeSpeed > _script.Length)
                _currentScriptPosition = 0;

            _delayPrintService.DelayPrint(_script.Substring(_currentScriptPosition, typeSpeed), 30);

            _currentScriptPosition = _currentScriptPosition + typeSpeed;
        }
    }
}
