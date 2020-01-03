using HackerF.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerF.Interface
{
    public interface IHotkeyMenu
    {
        void Show();

        List<Hotkey> GetHotkeys();
    }
}
