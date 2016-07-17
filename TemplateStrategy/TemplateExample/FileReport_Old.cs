using System;
using System.IO;
using System.Security.Principal;

namespace TemplateExample
{
    class FileReport_Old
    {
        private string dir;

        public FileReport_Old(string directory)
        {
            dir = directory;
        }

        public void ProduceReport()
        {
            Console.WriteLine("Report on Directory {0}", dir);
            Console.WriteLine("Filename,Size,Last Modified");
            foreach (FileInfo file in new DirectoryInfo(dir).GetFiles())
            {
                // Write File Details
                Console.WriteLine("{0},{1},{2}",
                    file.Name, file.Length, file.LastWriteTime);
            }

            Console.WriteLine("Report ran {0} by {1}", DateTime.Now,
                  WindowsIdentity.GetCurrent().Name);
        }
    }
}
