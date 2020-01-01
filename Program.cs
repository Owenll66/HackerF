using System;
using System.Linq;

namespace HackerF
{
    class Program
    {
        static void Main(string[] args)
        {
            var menu = CoreInstaller.getInstance().Initialise();

            menu.Show();
        }
    }
}
