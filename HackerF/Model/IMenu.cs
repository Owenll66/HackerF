using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerF.Model
{
    public interface IMenu
    {
        void Show();

        void AddOption(Option option);

        void DeleteOption(Option option);
    }
}
