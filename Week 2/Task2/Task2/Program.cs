using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task2
{
    class Program
    {
        public static bool isPrime(int a)//функция для определения простого числа
        {
            if (a == 0 || a == 1)//0 и 1 не простые числа, исключаем их
                return false;
            for(int i = 2; i <= Math.Sqrt(a); i++)//проверяем каждое число деля его на числа, меньшие чем квадратный корень данного числа
            {
                if (a % i == 0)//если число делится на какое-то другое кроме себя и единицы
                    return false;//возвращаем false
            }
            return true;//в другом случае число является простым
        }
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("input.txt");//считываем данные из файла input.txt
            string sl = sr.ReadLine();//читаем первую линию из файла
            sr.Close();//закрываем поток
            string[] s = sl.Split();//записываем принятые значения в массив строк, разделив числа по пробелу
            int[] nums = new int[s.Length];//создаем массив для чисел, размер которого это число подстрок из массива выше
            for (int i = 0; i < s.Length; i++)
            {
                nums[i] = int.Parse(s[i]);//парсим каждую подстроку (то есть число, которое принято как стринг) в интеджер
            }
            StreamWriter sw = new StreamWriter("output.txt");//создаем поток для записи чисел в файл output.txt
            for(int i = 0; i < nums.Length; i++)
            {
                if(isPrime(nums[i]) == true)//если элемент массива простое число
                {
                    sw.Write(nums[i] + " ");//то мы записываем его в output через пробел
                }
            }
            sw.Close();//закрываем поток, чтобы все данные из буфера записались
            Console.ReadKey();//консоль не закрывается, пока мы не нажмем любую клавишу
        }
    }
}
