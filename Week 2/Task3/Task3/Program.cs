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
        static void PrintSpaces(int lvl)//����� ��� �������� � ����� ����������
        {
            for (int i = 0; i < lvl; i++)
                Console.Write(" ");
        }
        static void DirectoryTree(DirectoryInfo dir, int lvl)//����� ��� ��������� ���� ������ � ����������
        {
            FileInfo[] files = dir.GetFiles();//������ ��� ��������� ���� ���� ������ � ����������
            DirectoryInfo[] dirs = dir.GetDirectories();//������ ��� ��������� ���� ���� ����������
            foreach(FileInfo file in files)//���� ��� ������ �������� � ���������
            {
                PrintSpaces(lvl);//����� ��������
                Console.WriteLine(file.Name);//����� ����
            }
            foreach(DirectoryInfo direct in dirs)//���� ��� ������ ����������
            {
                PrintSpaces(lvl);//����� ��������
                Console.WriteLine(direct.Name);//����� ��������
                DirectoryTree(direct, lvl++);//��� �������� � ��������� ���������� ���������� ��������� ��� �� �� �������� ������ ������ ������������
            }
        }
        static void Main(string[] args)
        {
            DirectoryInfo path = new DirectoryInfo("D:/mashok/KBTU/PP2/");//��������� ���� ���������� ������� ����� �����������
            DirectoryTree(path, 0);//�������� �����, ��������� ������ ����� 0
            Console.ReadKey();//�������� ������� ����� ������� �������
        }
    }
}
