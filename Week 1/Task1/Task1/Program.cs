using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static public bool isPrime(int a)//function to determine if number is prime
        {
            if (a == 1 || a == 0)//0 and 1 are not prime
                return false;
            else
            {
                for (int i = 2; i <= Math.Sqrt(a); i++)//the first prime number is 2 that's why we start i from 2
                                                       //and if number isn't divided by number <= its square root we can conclude
                                                       //that it won't be divided by any other withput remainder
                for(int i = 2; i <= Math.Sqrt(a); i++)//the first prime number is 2 that's why we start i from 2
                    //and if number isn't divided by number <= its square root we can conclude
                    //that it won't be divided by any other without remainder
                    //Math.Sqrt(a) gives us square root of "a"
                {
                    if (a % i == 0)//if number can be divided by any other 
                        return false;//number without remainder - it's not prime
                }
                return true;//else the number is prime
            }
        }
        static void Main(string[] args)
        {
            int s = int.Parse(Console.ReadLine());//the size of an array
            string nums = Console.ReadLine();//string for numbers
            string[] arr = nums.Split();//splitting written numbers by space
            int[] numbers = new int[s];//adding numbers into array
            for (int i = 0; i < s; i++)
            {
                numbers[i] = int.Parse(arr[i]);//parsing added numbers into integers
            }
            int cnt = 0;//counter for prime numbers
            for (int i = 0; i < s; i++)
            {
                if (isPrime(numbers[i]) == true)//if the number is prime then conter + 1
                {
                    cnt++;
                }
            }
            Console.WriteLine(cnt);//writing counter in console
            for (int i = 0; i < s; i++)
            {
                if (isPrime(numbers[i]) == true)//checking for prime all numbers in array
                    Console.Write(numbers[i] + " ");//if prime then show it in console
            }
            Console.ReadLine();//close console by preesing a key
        }
    }
}
