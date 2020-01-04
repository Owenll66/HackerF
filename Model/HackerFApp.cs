using System;
using System.Collections.Generic;
using System.Linq;

using HackerF.Interface;

namespace HackerF.Model
{
    class HackerFApp : CoreInstaller
    {
        private ICommandReader _commandReader;
        private IDelayPrintService _delayPrintService;
        private IAsciiImageService _asciiImageService;

        public HackerFApp() 
        {
            Initialise();
            _commandReader = _container.Resolve<ICommandReader>();
            _delayPrintService = _container.Resolve<IDelayPrintService>();
            _asciiImageService = _container.Resolve<IAsciiImageService>();

            SetUpConsoleLayout();
        }

        public void Start()
        {
            var logo = _asciiImageService.GetHackFLogo();
            _delayPrintService.WavePrint(logo, 100);
            _commandReader.ReadKey();
        }

        private void SetUpConsoleLayout()
        {
            Console.Title = "HackerF";
            Console.ForegroundColor = ConsoleColor.Green;
        }
    }
}
