using HackerF.Interface;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerF.Service
{
    public class PrintService : IPrintService
    {
        public void DelayPrintText(string text, int delay)
        {
            for (int i = 0; i < text.Length; i++) 
            {
                Console.Write(text[i]);
                System.Threading.Thread.Sleep(delay);
            }
        }

        public void WavePrint(List<string> info, int delay)
        {
            AdjustLength(info);

            var totalwidth = info[0].Length;

            for (int i = 0; i <= totalwidth ; i += 1) 
            {
                var output = "";
                foreach (var s in info) 
                    output = output + $"{s.Substring(0, i)}\n";
                    
                Console.SetCursorPosition(0, 3);
                Console.Write(output);

                System.Threading.Thread.Sleep(80);
            }
        }

        private void AdjustLength(List<String> lines)
        {
            var maxlength = lines.Max(l => l.Length);
            for (int i = 0; i < lines.Count; i++)
            {
                var lineLength = lines[i].Length;
                for (int j = 0; j < maxlength - lineLength; j++) 
                {
                    lines[i] = lines[i] + " ";
                }
            }
        }
    }
}
