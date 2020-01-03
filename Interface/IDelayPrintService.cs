using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerF.Interface
{
    interface IDelayPrintService
    {
        void WavePrint(List<string> info, int delay, int width);

        void DelayPrintText(string text, int delay);
    }
}
