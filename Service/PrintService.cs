using HackerF.Interface;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerF.Service
{
    public class PrintService : IPrintService
    {
        public void Print(string info)
        {
            var rows = SplitToList(info);
            AdjustLength(rows);

            var output = "";
            foreach (var s in rows)
                output = output + s + "\n";
            
            Console.Write(output);
        }

        public void DelayPrint(string info, int delay)
        {
            for (var i = 0; i < info.Length; i++)
            {
                Console.Write(info[i]);
                System.Threading.Thread.Sleep(delay);
            }
        }

        public void WavePrint(string info, int delay, bool showPercentage = false)
        {
            Console.CursorVisible = false;

            var rows = SplitToList(info);
            AdjustLength(rows);

            var cursorLeftStart = Console.CursorLeft;
            var cursorTopStart = Console.CursorTop;

            var totalwidth = rows[0].Length;

            for (var i = 0; i <= totalwidth; i += 1)
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

        private List<string> SplitToList(string info)
        {
            return info.Split("\n").ToList();
        }

        private void AdjustLength(List<String> lines)
        {
            var maxlength = lines.Max(l => l.Length);
            for (var i = 0; i < lines.Count; i++)
            {
                var lineLength = lines[i].Length;
                lines[i] = lines[i] + new string(' ', maxlength - lineLength);
            }
        }

        public void StaticPrint(string info)
        {
            var cursorLeftPos = Console.CursorLeft;
            var cursorTopPos = Console.CursorTop;

            Print(info);

            Console.SetCursorPosition(cursorLeftPos, cursorTopPos);
        }

        public void BottomToTopClear(string info, int delay)
        {
            Console.CursorVisible = false;
            var rows = SplitToList(info);
            AdjustLength(rows);

            var totalwidth = rows[0].Length;

            for (var i = 0; i < rows.Count; i++) 
            {
                var result = string.Join("\n", rows.GetRange(0, rows.Count - i)) + "\n";
                for (var j = 0; j < i; j++) 
                {
                    result += new string(' ', totalwidth) + "\n";
                }

                StaticPrint(result);

                System.Threading.Thread.Sleep(delay);
            }

            Console.CursorVisible = true;
        }
    }
}
