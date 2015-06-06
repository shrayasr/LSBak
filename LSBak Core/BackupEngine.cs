using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace LSBak_Core
{
    public class BackupEngine
    {
        private void CopyFileToFile(string source, string destination) 
        {
            FileInfo f = new FileInfo(source);
            if (!f.Exists)
                throw new FileNotFoundException("Source file doesn't exist");

            f.CopyTo(destination);
        }

        private void CopyFolderToFolder(string source, string destination)
        {
            DirectoryInfo dir = new DirectoryInfo(source);

            if (!dir.Exists)
                throw new DirectoryNotFoundException("Source Directory doesn't exist");

            if (!Directory.Exists(destination))
                Directory.CreateDirectory(destination);

            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo file in files)
                file.CopyTo(Path.Combine(destination, file.Name), true);

            DirectoryInfo[] dirs = dir.GetDirectories();
            foreach (DirectoryInfo subDir in dirs)
                CopyFolderToFolder(subDir.FullName, Path.Combine(destination, subDir.Name));
        }

        public void Copy(string source, string destination)
        {
            source = source.Trim();
            destination = destination.Trim();

            if (!File.Exists(source) && !Directory.Exists(source))
                throw new ArgumentException("Source doesn't exist");

            FileAttributes attr = File.GetAttributes(source);
            if ((attr & FileAttributes.Directory) == FileAttributes.Directory)
                CopyFolderToFolder(source, destination);
            else
                CopyFileToFile(source, destination);
        }
    }
}
