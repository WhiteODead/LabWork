using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace Лабораторная_работа_13
{
    static class SDUDiskInfo
    {
        public static long DriveFreeSpace(string name)
        {
            DriveInfo driveInfo = new DriveInfo(name);
            return driveInfo.TotalFreeSpace;
        }
        public static string DriveFormat(string name)
        {
            DriveInfo driveInfo = new DriveInfo(name);
            return driveInfo.DriveFormat;
        }
        public static void Drives()
        {
            DriveInfo[] driveInfos = DriveInfo.GetDrives();
            foreach(DriveInfo x in driveInfos)
            {
                Console.Write($"\nИмя диска: {x.Name}\n");
                Console.Write($"Объём: {x.TotalSize}\n");
                Console.Write($"Доступный объём: {x.TotalFreeSpace}\n");
                Console.Write($"Метка тома: {x.VolumeLabel}\n");
            }
        }
    }
}
