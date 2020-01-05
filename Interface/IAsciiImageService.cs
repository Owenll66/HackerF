using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerF.Interface
{
    public interface IAsciiImageService
    {
        string GetHackFLogo();

        string GetProcessBar1();

        string GetProcessBarEdges1(string processBar);
    }
}