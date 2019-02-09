using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static int n;//size of an array
        static int[] a = new int[1000];//creating array fo input numbers
        static public void Repeat()//method for pushing elemnts of the given array into new array
        {
            int[] ans = new int[2 * n];//new array for duplicated numbers
            for (int i = 0; i < n; i++)//loop for giving values to the elements
            {
                ans[i * 2] = a[i];//current element of dupl. array is equal to the current el. of the given arr
                ans[i * 2 + 1] = a[i];//next number of dupl. arr. is equal to the current el. of the given array too

            }
            for (int i = 0; i < 2 * n; i++)//loop for printing answer
            {
                Console.Write(ans[i] + " ");//prints elements of the array with spaces
            }
        }
        static void Main(string[] args)
        {
            n = int.Parse(Console.ReadLine());//reading a value of size and parsing it
            string[] s = Console.ReadLine().Split();//array of strings for our numbers splitted by spaces
            for(int i = 0; i < n; i++)//loop for giving values for the elements of the array
            {
                a[i] = int.Parse(s[i]);//parsing elements of string array into integers
            }
            Repeat();//calling the method
            Console.ReadKey();//close console by pressing a key
        }
    }
}
