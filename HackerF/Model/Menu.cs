using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerF.Model
{
    public class Menu : IMenu
    {
        public void AddOption(Option option)
        {
            throw new NotImplementedException();
        }

        public void DeleteOption(Option option)
        {
            throw new NotImplementedException();
        }

        public void Show()
        {
            Console.WriteLine("this is a menu");
        }
    }
}
