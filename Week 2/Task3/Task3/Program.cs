using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task3
{
    class Program
    {
        static void PrintSpaces(int lvl)//метод для отступов в новой директории
        {
            for (int i = 0; i < lvl; i++)
                Console.Write(" ");
        }
        static void DirectoryTree(DirectoryInfo dir, int lvl)//метод для просмотра всех файлов и директорий
        {
            FileInfo[] files = dir.GetFiles();//массив для получения имен всех файлов в директории
            DirectoryInfo[] dirs = dir.GetDirectories();//массив для получения имен всех директорий
            foreach(FileInfo file in files)//цикл для вывода названий с отступами
            {
                PrintSpaces(lvl);//вывод отступов
                Console.WriteLine(file.Name);//вывод имен
            }
            foreach(DirectoryInfo direct in dirs)//цикл для вывода директорий
            {
                PrintSpaces(lvl);//вывод отступов
                Console.WriteLine(direct.Name);//вывод названий
                DirectoryTree(direct, lvl++);//при переходе в следующую директорию рекурсивно выполняем все те же действия только отступ прибавляется
            }
        }
        static void Main(string[] args)
        {
            DirectoryInfo path = new DirectoryInfo("D:/mashok/KBTU/PP2/");//указываем путь директории которую хотим просмотреть
            DirectoryTree(path, 0);//вызываем метод, начальный отступ равен 0
            Console.ReadKey();//закрытие консоли после нажатия клавиши
        }
    }
}
