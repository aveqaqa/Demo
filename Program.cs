using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace ReadAndWritePoc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            var readPath = ConfigurationManager.AppSettings["readPath"];
            var writePath = ConfigurationManager.AppSettings["writePath"];
            
            var reader = new FileReader();
            var text = reader.Read(readPath);

            var writer = new FileWriter();
            writer.Write(writePath,text);
        }
    }
}
