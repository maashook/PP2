using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void printAns(int[] arr)//method print elements of array twice
        {
            for(int i = 0; i < arr.Length; i++)//loop for printing numbers from the first to the last element of the given array
            {
                Console.Write(arr[i] + " " + arr[i] + " ");//printing numbers twice
            }
        }
        static void Main(string[] args)
        {
            int s = int.Parse(Console.ReadLine());//reading the number and parsing it (it will be our size of array)
            string[] str = Console.ReadLine().Split();//string to read given array and split it by spaces
            int[] arr = new int[s];//array of integers from the "str" string
            for(int i = 0; i < s; i++)//loop to parse numbers to integer
            {
                arr[i] = int.Parse(str[i]);//making integers and fill the array with them
            }
            printAns(arr);//using created method to print numbers twice
            Console.ReadKey();//close console be pressing a key
        }
    }
}
