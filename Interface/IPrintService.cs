using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerF.Interface
{
    public interface IPrintService
    {
        void WavePrint(List<string> info, int delay);

        void DelayPrintText(string text, int delay);
    }
}
