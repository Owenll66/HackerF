using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

using HackerF.Interface;

namespace HackerF.Model
{
    public class CommandReader : ICommandReader
    {
        public CommandReader()
        {
            Thread commandReader = new Thread(new ThreadStart(ReadKey));
            commandReader.Start();
        }

        public void ReadKey()
        {
            while (true) 
            {
                var key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.F1)
                {
                    Console.WriteLine("Hey you just pressed F1");
                }
            }
        }
    }
}
