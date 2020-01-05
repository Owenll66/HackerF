using System;
using System.Collections.Generic;
using System.Linq;

using HackerF.Interface;
using HackerF.Model;

namespace HackerF.Service
{
    public class HotkeyFunctionService : IHotkeyFunctionService
    {
        private IPrintService _printService;
        private IAsciiImageService _asciiImageService;

        public HotkeyFunctionService(IPrintService printService, IAsciiImageService asciiImageService) 
        {
            _printService = printService;
            _asciiImageService = asciiImageService;
        }

        public void ShowMenu()
        {
            var hotKeys = CheatingSheet.HotKeys;

            string title = "\n -------------------------------------------- \n";
            title += "|                Hacking Menu                |\n";
            title += " -------------------------------------------- \n";
            Console.Write(title);
            for (var i = 0; i < hotKeys.Count(); i++)
            {
                Console.WriteLine(String.Format("| {0, -5} | {1, -34} |", hotKeys[i].Name, hotKeys[i].Description));
            }
            Console.Write(" -------------------------------------------- \n");
        }

        public void InstallVirus()
        {
            var processBar = _asciiImageService.GetProcessBar1();
            var processBarEdges = _asciiImageService.GetProcessBarEdges1(processBar);

            Console.WriteLine();

            var edgeWidth = (processBarEdges.Length - processBar.Length) / 2;
            var cursorTop = Console.CursorTop;
            
            _printService.Print(processBarEdges);

            Console.SetCursorPosition(Console.CursorLeft + edgeWidth, cursorTop);
            
            _printService.WavePrint(processBar, 100);
        }
    }
}
