using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task1
{
    class Program
    {
        public static bool isPalindrome(string s)//метод для определения является ли строка палиндромом
        {
            if (s.Length == 1)//если вводимое слово это буква
                return true;//значит это палиндром
            else if(s[0] == s[s.Length - 1])//в другом случае, если первый символ строки равен последнему
            {
                return isPalindrome(s.Substring(1, s.Length - 2));//то мы рекурсивно возвращаем метод от строки укороченной с начала и с конца на один символ
            }
            return false;//если строка не прошла проверку то возвращаем false
        }
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("input.txt");//создаем переменную для чтения данных с файла input.txt
            string sl = sr.ReadLine();//читаем первую строку
            if (isPalindrome(sl) == true)//если метод от прочтенной строки возвращает true
                Console.WriteLine("Yes");//то выводим на консоль Yes
            else//в обратном случае
                Console.WriteLine("No");//вывод No
            Console.ReadKey();//консоль закрывается при нажатии клавиши
        }
    }
}
