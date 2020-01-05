using HackerF.Interface;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerF.Service
{
    public class PrintService : IPrintService
    {
        public void Print(string original)
        {
            var rows = SplitToList(original);
            AdjustLength(rows);

            var output = "";
            foreach (var s in rows)
                output = output + s + "\n";
            
            Console.Write(output);
        }

        public void DelayPrint(string txt, int delay)
        {
            for (int i = 0; i < txt.Length; i++)
            {
                Console.Write(txt[i]);
                System.Threading.Thread.Sleep(delay);
            }
        }

        public void WavePrint(string original, int delay, bool showPercentage = false)
        {
            Console.CursorVisible = false;

            var rows = SplitToList(original);
            AdjustLength(rows);

            var cursorLeftStart = Console.CursorLeft;
            var cursorTopStart = Console.CursorTop;

            var totalwidth = rows[0].Length;

            for (int i = 0; i <= totalwidth; i += 1)
            {
                var output = "";
                foreach (var s in rows) 
                {
                    if (showPercentage) 
                    {
                        Console.SetCursorPosition(cursorLeftStart + totalwidth + 2, cursorTopStart);
                        Console.Write(((decimal) i / (decimal) totalwidth * 100).ToString("#.##") + "%");
                    }
                    output = output + $"{s.Substring(0, i)}\n";
                }

                Console.SetCursorPosition(cursorLeftStart, cursorTopStart);
                Console.Write(output);

                System.Threading.Thread.Sleep(delay);
            }
            Console.CursorVisible = true;
        }

        private List<string> SplitToList(string original)
        {
            return original.Split("\n").ToList();
        }

        private void AdjustLength(List<String> lines)
        {
            var maxlength = lines.Max(l => l.Length);
            for (int i = 0; i < lines.Count; i++)
            {
                var lineLength = lines[i].Length;
                lines[i] = lines[i] + new string(' ', maxlength - lineLength);
            }
        }

        public void StaticPrint(string original)
        {
            var cursorLeftPos = Console.CursorLeft;
            var cursorTopPos = Console.CursorTop;

            Print(original);

            Console.SetCursorPosition(cursorLeftPos, cursorTopPos);
        }
    }
}
