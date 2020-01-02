using System;
using System.Collections.Generic;
using System.Linq;

using HackerF.Interface;

namespace HackerF.Model
{
    class HackerFApp : CoreInstaller
    {
        private IMenu CheatSheet { get; set; }

        public HackerFApp() 
        {
            Initialise();
            CheatSheet.Show();
        }

        public HackerFApp(IMenu menu)
        {
            CheatSheet = menu;
        }
    }
}
