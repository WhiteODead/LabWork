using System;
using System.IO;
namespace Лабораторная_работа_13
{
    class Program
    {
        static void Main(string[] args)
        {

            //Задание 2
            //-------------------------------------------------------------------------------------------------------------------
            OutputInfo.Output("Информация о свободном месте на диске", new Func<string, long>(SDUDiskInfo.DriveFreeSpace), @"C");

            OutputInfo.Output("Информация о файловой системе", new Func<string, string>(SDUDiskInfo.DriveFormat), @"C");

            OutputInfo.Output("Информация о дисках", new Action(SDUDiskInfo.Drives));
            //-------------------------------------------------------------------------------------------------------------------

            //Задание 3
            //-------------------------------------------s------------------------------------------------------------------------
            OutputInfo.Output("Полный путь до файла", new Func<string, string>(SDUFileInfo.PathToFile), @"..\files\sdulogfile.txt");

            OutputInfo.Output("Информация о расширении, размере и имени файла", new Action<string>(SDUFileInfo.LNE), @"..\files\sdulogfile.txt");

            OutputInfo.Output("Дата создания и изменения файла", new Action<string>(SDUFileInfo.CreationTime), @"..\files\sdulogfile.txt");
            //-------------------------------------------------------------------------------------------------------------------

            //Задание 4
            //-------------------------------------------------------------------------------------------------------------------
            OutputInfo.Output("Количество файлов в каталоге", new Func<string, int>(SDUDirInfo.CountOfFiles), @"D:\Университет\Объектно-ориентированное программирование\Лабораторные работы\Лабораторная работа 13");

            OutputInfo.Output("Дата создания каталога", new Func<string, DateTime>(SDUDirInfo.CreationTime), @"D:\Университет");

            OutputInfo.Output("Количество подкаталогов", new Func<string, int>(SDUDirInfo.CountOfDirectories), @"D:\Университет");

            //OutputInfo.Output("Список родительских каталогов", new Action<DirectoryInfo>(SDUDirInfo.ParentDirectories), new DirectoryInfo(@"D:\Университет\Объектно-ориентированное программирование\Лабораторные работы\Лабораторная работа 13"));

            OutputInfo.Output("Список файлов и папок заданного диска", new Action<string>(SDUFileManager.ListOfFaD), @"D");

            OutputInfo.Output("Создание директория, текстового файла", new Action(SDUFileManager.NewDirectory));
            
        }
    }
}
