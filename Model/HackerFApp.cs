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

        public HackerFApp() 
        {
            Initialise();
            _commandReader = _container.Resolve<ICommandReader>();
            _delayPrintService = _container.Resolve<IDelayPrintService>();

            SetUpConsoleLayout();
        }

        public void Start()
        {
            var logo = GetLogo();
            _delayPrintService.WavePrint(logo, 100, 1);
            _commandReader.ReadKey();
        }

        private void SetUpConsoleLayout()
        {
            Console.Title = "HackerF";
            Console.ForegroundColor = ConsoleColor.Green;
        }

        private List<String> GetLogo()
        {
            var logo = new List<string>();
            logo.Add("██╗  ██╗  █████╗   ██████╗ ██╗  ██╗ ███████╗ ██████╗  ███████╗");
            logo.Add("██║  ██║ ██╔══██╗ ██╔════╝ ██║ ██╔╝ ██╔════╝ ██╔══██╗ ██╔════╝");
            logo.Add("███████║ ███████║ ██║      █████╔╝  █████╗   ██████╔╝ █████╗  ");
            logo.Add("██╔══██║ ██╔══██║ ██║      ██╔═██╗  ██╔══╝   ██╔══██╗ ██╔══╝  ");
            logo.Add("██║  ██║ ██║  ██║ ╚██████╗ ██║  ██╗ ███████╗ ██║  ██║ ██║     ");
            logo.Add("╚═╝  ╚═╝ ╚═╝  ╚═╝  ╚═════╝ ╚═╝  ╚═╝ ╚══════╝ ╚═╝  ╚═╝ ╚═╝     ");
            return logo;
        }
    }
}
