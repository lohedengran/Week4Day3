using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DelegatesDemo
{
    class FileSearcher
    {
        public void ListFilesInDirectory(string dirPath, Func<string, bool> predicate)
        {
            string[] filePaths = Directory.GetFiles(dirPath);
            foreach (var filePath in filePaths)
            {
                if (predicate(filePath))
                    Console.WriteLine(filePath);
            }
        }
    }
}
