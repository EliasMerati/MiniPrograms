using System;
using System.IO;
using static System.Console;
using static System.IO.Directory;
using static System.IO.Path;
using static System.Environment;

namespace WorkingWithFileSystems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //OutputFileSystemInfo();
            WorkWithDrives();
        }
        static void OutputFileSystemInfo()
        {
            WriteLine($"{Path.PathSeparator,-33} {PathSeparator}");
            WriteLine($"{Path.DirectorySeparatorChar,-33}{DirectorySeparatorChar}");
            WriteLine($"{Directory.GetCurrentDirectory(),-33}{GetCurrentDirectory()}");
            WriteLine($"{Environment.CurrentDirectory,-33}{CurrentDirectory}");
            WriteLine($"{Environment.SystemDirectory,-33}{SystemDirectory}");
            WriteLine($"{Path.GetTempPath(),-33}{GetTempPath()}");
            WriteLine($"{GetFolderPath(SpecialFolder.MyPictures)}");
            WriteLine($"{GetFolderPath(SpecialFolder.System),-33}{GetFolderPath(SpecialFolder.System)}");
            WriteLine($"{GetFolderPath(SpecialFolder.MyDocuments),-33}{GetFolderPath(SpecialFolder.MyDocuments)}");
            WriteLine($"{GetFolderPath(SpecialFolder.ApplicationData),-33}{GetFolderPath(SpecialFolder.ApplicationData)}");
            WriteLine($"{GetFolderPath(SpecialFolder.Personal),-33}{GetFolderPath(SpecialFolder.Personal)}");
        }

        static void WorkWithDrives()
        {
            WriteLine("{\"NAME\",-30} | {\"TYPE\",-10} | {\"FORMAT\",-7} | {\"SIZE (BYTES)\",18} | {\"FREE SPACE\",18}");
            foreach (DriveInfo drive in DriveInfo.GetDrives())
            {
                if (drive.IsReady)
                {
                    WriteLine($"{drive.Name,-30}{drive.DriveType,-10}{drive.DriveFormat,-7}{drive.TotalSize,18:N0}{drive.TotalFreeSpace,18:N0}");
                }
                else
                {
                    WriteLine($"{drive.Name,-30}{drive.DriveType,-10}");
                }

            }
        }
    }
}
