using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadAndWritePoc
{
    internal class FileReader
    {
        public string Read(string path)
        {
            return File.ReadAllText(path);
        }
    }
}
