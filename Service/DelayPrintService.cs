using HackerF.Interface;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerF.Service
{
    public class DelayPrintService : IDelayPrintService
    {
        public void DelayPrintText(string text, int delay)
        {
            
        }

        public void WavePrint(List<string> info, int delay, int processingWidth)
        {
            var totalwidth = info.Max(s => s.Length);
            for (int i = 0; i < totalwidth; i += processingWidth) 
            {
                foreach (var s in info)
                    Console.WriteLine($"\r {s.Substring(i, Math.Min(i + processingWidth, s.Length - 1))}");
                System.Threading.Thread.Sleep(100);
            }
        }
    }
}
