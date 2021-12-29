using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace Лабораторная_работа_13
{
    static class SDUDirInfo
    {
        public static int CountOfFiles(string path)
        {
            return Directory.GetFiles(path).Length;
        }
        public static DateTime CreationTime(string path)
        {
            return Directory.GetCreationTime(path);
        }
        public static int CountOfDirectories(string path)
        {
            return Directory.GetDirectories(path).Length;
        }
        public static void ParentDirectories(DirectoryInfo directory)
        {
            try
            {
                ParentDirectories(directory.Parent);
                Console.WriteLine($"\n{directory.Parent.FullName}");
            }
            catch (Exception e)
            {
            }
        }
    }
}
