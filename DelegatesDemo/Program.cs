using System;
using System.IO;

namespace DelegatesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string dirPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            var fileSearcher = new FileSearcher();

            // Named method
            fileSearcher.ListFilesInDirectory(dirPath, FilterTextFiles);

            // Lambda
            fileSearcher.ListFilesInDirectory(dirPath, f => Path.GetExtension(f) == ".txt");

        }

        static bool FilterTextFiles(string filePath)
        {
            return Path.GetExtension(filePath) == ".txt";
        }
    }
}
