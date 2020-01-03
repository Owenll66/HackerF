using System;
using System.Collections.Generic;
using System.Linq;

using HackerF.Interface;

namespace HackerF.Model
{
    class HackerFApp : CoreInstaller
    {
        private ICommandReader _commandReader;

        public HackerFApp() 
        {
            Initialise();
            _commandReader = _container.Resolve<ICommandReader>();

            SetUpConsoleLayout();
        }

        public void Start() 
        {
            _commandReader.ReadKey();
        }

        private void SetUpConsoleLayout()
        {
            Console.Title = "HackerF";
            Console.ForegroundColor = ConsoleColor.Green;
        }
    }
}
