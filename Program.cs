using System.IO;
using static System.Console;
using static System.IO.DriveInfo;

namespace DriveInfoApp
{
    class Program
    {
        static void Main()
        {
            WriteLine("***** Fun with DriveInfo *****\n");

            // Get info regarding all drives.
            DriveInfo[] myDrives = GetDrives();
            // Now print drive stats.
            foreach (DriveInfo d in myDrives)
            {
                WriteLine($"Name: {d.Name}");
                WriteLine($"Type: {d.DriveType}");

                // Check to see whether the drive is mounted.
                if (d.IsReady)
                {
                    WriteLine($"Free space: {d.TotalFreeSpace}");
                    WriteLine($"Format: {d.DriveFormat}");
                    WriteLine($"Label: {d.VolumeLabel}");
                }
                WriteLine();
            }
            ReadLine();
        }
    }
}