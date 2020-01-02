using System;
using System.Collections.Generic;
using System.Text;

using HackerF.Interface;

namespace HackerF.Model
{
    public class Hotkey : IMenuItem
    {
        public string HotkeyName { get; set; }

        public string Description { get ; set; }
    }
}
