using System;
using System.Collections.Generic;
using System.Linq;

using HackerF.Interface;

namespace HackerF.Model
{
    class HackerFApp : CoreInstaller
    {
        private ICommandReader _commandReader;
        private IPrintService _delayPrintService;
        private IAsciiImageService _asciiImageService;
        private IHotkeyFunctionService _hotkeyFunctionService;

        public HackerFApp() 
        {
            Initialise();
            _commandReader = _container.Resolve<ICommandReader>();
            _delayPrintService = _container.Resolve<IPrintService>();
            _asciiImageService = _container.Resolve<IAsciiImageService>();
            _hotkeyFunctionService = _container.Resolve<IHotkeyFunctionService>();

            var cheatingSheet = new CheatingSheet(_hotkeyFunctionService);
            cheatingSheet.Initialise();

            SetUpConsoleLayout();
        }

        public void Start()
        {
            Console.SetCursorPosition(0, 1);
            
            var logo = _asciiImageService.GetHackFLogo();
            _delayPrintService.WavePrint(logo, 50);

            Console.Clear();

            _commandReader.ReadKey();
        }

        private void SetUpConsoleLayout()
        {
            Console.Title = "HackerF";
            Console.ForegroundColor = ConsoleColor.Green;
        }
    }
}
