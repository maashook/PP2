using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Student//creating a class "Student"
    {
        public string name;//creating public string name
        public string id;//creating public string id
        public int year;//creating public integer year

        public Student(string name, string id)//constructor which takes two parameters (name and id)
        {
            this.name = name;//equating variables of class to the variables of constructor
            this.id = id;
        }

        public void Increment()//method which increments the year of study and prints name, id and year
        {
            year++;//incrementing the year
            Console.WriteLine("Student: {0}; ID: {1}; Increased Year: {2}", name, id, year);//printing values
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student maashok = new Student("Mariya Mordvinova", "18BD110992");//creating new instance of the class "Student" name maashok with two parameters
            maashok.year = 1;//giving value to the instance's year
            maashok.Increment();//calling a method for instance
            Console.ReadKey();//closing console by pressing a key
        }
    }
}