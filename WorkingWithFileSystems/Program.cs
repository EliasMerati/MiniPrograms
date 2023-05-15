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
            OutputFileSystemInfo();
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
    }
}
