using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace Лабораторная_работа_13
{
    static class SDUFileInfo
    {
        public static string PathToFile(string path)
        {
            FileInfo fileInfo = new FileInfo(path);
            return fileInfo.FullName;
        }
        public static void LNE(string path)
        {
            FileInfo fileInfo = new FileInfo(path);
            Console.WriteLine($"\nРазмер: {fileInfo.Length}");
            Console.WriteLine($"Расширение: {Path.GetExtension(fileInfo.FullName)}");
            Console.WriteLine($"Имя: {fileInfo.Name}");
        }
        public static void CreationTime(string path)
        {
            FileInfo fileInfo = new FileInfo(path);
            Console.WriteLine($"\nДата создания: {fileInfo.CreationTime}");
            Console.WriteLine($"Дата изменения: {fileInfo.LastWriteTime}");
        }
    }
}
