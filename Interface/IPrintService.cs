using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerF.Interface
{
    public interface IPrintService
    {
        void Print(string info);

        void WavePrint(string info, int delay, bool showPercentage = false);

        void DelayPrint(string text, int delay);

        void StaticPrint(string text);
    }
}
