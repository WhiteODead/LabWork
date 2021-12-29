using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.IO.Compression;
namespace Лабораторная_работа_13
{
    static class SDUFileManager
    {
        public static void ListOfFaD(string name)
        {
            DriveInfo drive = new DriveInfo(name);
            foreach (string x in Directory.GetDirectories(drive.Name))
                Console.WriteLine(x);
            foreach (string x in Directory.GetFiles(drive.Name))
                Console.WriteLine(x);
        }
        public static void NewDirectory()
        {
            Directory.CreateDirectory(@"D:\SDUInspect");
            File.WriteAllText(@"D:\SDUInspect\sdudirinfo.txt", "text");
            try
            {
                File.Copy(@"D:\SDUInspect\sdudirinfo.txt", @"D:\SDUInspect\sdudirinfocopy.txt");
            }
            catch(Exception e)
            {

            }
            File.Delete(@"D:\SDUInspect\sdudirinfo.txt");

        }
    }
}
