using System.IO;

namespace TextToFile
{
    public class UserFileReader
    {
        public string ReadFile(string path)
        {
            return File.ReadAllText(path);
        }
    }
}