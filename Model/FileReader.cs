using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

using HackerF.Interface;

namespace HackerF.Model
{
    public class FileReader : IFileReader
    {
        public string ReadFile(string fileLocation)
        {
            if (File.Exists(fileLocation))
                return File.ReadAllText(fileLocation);

            throw new Exception("Opps Hacker Scripts Not found...");
        }
    }
}
