using System;
using System.Collections.Generic;
using System.Text;

using HackerF.Interface;

namespace HackerF.Model
{
    public delegate void Function();

    public class Hotkey
    {
        public string Name { get; set; }

        public string Description { get ; set; }

        public ConsoleKey key { get; set; }

        public Function ExecutionFunction;
    }
}
