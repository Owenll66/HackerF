using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerF.Interface
{
    public interface IPrintService
    {
        void Print(string info);

        void WavePrint(string info, int delay, bool showPercentage = false);

        void DelayPrint(string info, int delay);

        void StaticPrint(string info);

        void BottomToTopClear(string info, int delay);
    }
}
