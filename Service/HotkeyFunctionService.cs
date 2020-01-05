using System;
using System.Collections.Generic;
using System.Linq;

using HackerF.Interface;
using HackerF.Model;

namespace HackerF.Service
{
    public class HotkeyFunctionService : IHotkeyFunctionService
    {
        public HotkeyFunctionService() 
        {

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
    }
}
