using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "path";//имя папки для создания файла
            string path1 = "path1";//конечная папка для копирования файла

            string fileName = "Fuck.txt";//название файла

            string source = @"D:\mashok\KBTU\PP2\Week 2\Task4";//путь к директории, в которой будут создаваться папки и файлы
            string sourcePath = Path.Combine(source, path);//путь к первой папке
            string targetPath = Path.Combine(source, path1);//путь ко второй папке

            if (!Directory.Exists(sourcePath))//если такой папки еще нет
            {
                Directory.CreateDirectory(sourcePath);//то мы ее создаем
            }

            string fileSource = Path.Combine(sourcePath, fileName);//путь к исходному файлу

            FileStream fs = File.Create(fileSource);//поток для создания файла по данному пути
            fs.Close();//закрываем поток чтобы не было исключений и ошибок

            if (!Directory.Exists(targetPath))//если такой папки еще нет
            {
                Directory.CreateDirectory(targetPath);//то мы ее создаем
            }

            string fileTarget = Path.Combine(targetPath, fileName);//путь к папке в которую будем копировать файл

            File.Copy(fileSource, fileTarget);//копируем файл в нужную папку
            File.Delete(fileSource);//удаляем оригинал
            }
    }
}
