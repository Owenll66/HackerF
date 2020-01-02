using HackerF.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerF.Interface
{
    public interface IMenu
    {
        IList<IMenuItem> Items { get; set; }

        void Show();
    }
}
