using System;
using System.Collections.Generic;
using System.Linq;

using HackerF.Interface;

namespace HackerF.Service
{
    class AsciiImageService : IAsciiImageService
    {
        public List<string> GetHackFLogo()
        {
            var logo = new List<string>();
            logo.Add("██╗  ██╗  █████╗   ██████╗ ██╗  ██╗ ███████╗ ██████╗  ███████╗     ");
            logo.Add("██║  ██║ ██╔══██╗ ██╔════╝ ██║ ██╔╝ ██╔════╝ ██╔══██╗ ██╔════╝");
            logo.Add("███████║ ███████║ ██║      █████╔╝  █████╗   ██████╔╝ █████╗      ");
            logo.Add("██╔══██║ ██╔══██║ ██║      ██╔═██╗  ██╔══╝   ██╔══██╗ ██╔══╝   ");
            logo.Add("██║  ██║ ██║  ██║ ╚██████╗ ██║  ██╗ ███████╗ ██║  ██║ ██║ ");
            logo.Add("╚═╝  ╚═╝ ╚═╝  ╚═╝  ╚═════╝ ╚═╝  ╚═╝ ╚══════╝ ╚═╝  ╚═╝ ╚═╝ ");
            return logo;
        }
    }
}
