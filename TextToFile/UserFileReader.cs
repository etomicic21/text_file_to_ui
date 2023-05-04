using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextToFile
{
    public class UserFileReader
    {
        public string ReadFile(string directory)
        {
            return File.ReadAllText(directory);
        }
    }
}
