using System;
using System.Diagnostics;
using System.IO;

namespace MainApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main app executing");
            var toolPath = Path.Combine(Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName), "Tool.exe");
            Process.Start(toolPath).WaitForExit();
            Console.WriteLine("Main app finished");
        }
    }
}
