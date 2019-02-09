using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());//parsing a number into integer, it will be size of an array
            string[,] arr = new string[n, n];//creating a 2d array n*n size
            for(int i = 0; i < n; i++)//loop for lines of pyramid, number of lines is equal to the size of the array
            {
                for(int j = 0; j <= i; j++)//loop for printing columns, number of columns is equal to the order number of the current line
                {
                    arr[i, j] = "[*]";//giving the values to the elements of an array
                    Console.Write(arr[i, j]);//printing required symbol
                }
                Console.WriteLine();//new line after the first lopp ends
            }
            Console.ReadKey();//closing console only by pressing a key
        }
    }
}
