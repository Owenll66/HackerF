using System;
using System.Collections.Generic;
using System.Linq;

using HackerF.Interface;

namespace HackerF.Service
{
    class AsciiImageService : IAsciiImageService
    {
        public string GetHackFLogo()
        {
            var logo = "";
            logo += "██╗  ██╗  █████╗   ██████╗ ██╗  ██╗ ███████╗ ██████╗  ███████╗     \n";
            logo += "██║  ██║ ██╔══██╗ ██╔════╝ ██║ ██╔╝ ██╔════╝ ██╔══██╗ ██╔════╝\n";
            logo += "███████║ ███████║ ██║      █████╔╝  █████╗   ██████╔╝ █████╗      \n";
            logo += "██╔══██║ ██╔══██║ ██║      ██╔═██╗  ██╔══╝   ██╔══██╗ ██╔══╝   \n";
            logo += "██║  ██║ ██║  ██║ ╚██████╗ ██║  ██╗ ███████╗ ██║  ██║ ██║ \n";
            logo += "╚═╝  ╚═╝ ╚═╝  ╚═╝  ╚═════╝ ╚═╝  ╚═╝ ╚══════╝ ╚═╝  ╚═╝ ╚═╝ \n";
            return logo;
        }

        public string GetProcessBar1()
        {
            return "██████████████████████████████████████████████████";
        }

        public string GetProcessBarEdges1(string processBar) 
        {
            var processBarEdges = "|";

            for (var i = 0; i < processBar.Length; i++)
            {
                processBarEdges += " ";
            }

            processBarEdges += "|";

            return processBarEdges;
        }
    }
}
