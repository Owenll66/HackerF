using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerF.Interface
{
    public interface IPrintService
    {
        void Print(List<string> info);

        void WavePrint(List<string> info, int delay);

        void DelayPrint(string text, int delay);
    }
}
