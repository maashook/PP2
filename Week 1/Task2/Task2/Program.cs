using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Student
    {
        public string name;
        public string id;
        public int year;

        public Student(string name, string id)
        {
            this.name = name;
            this.id = id;
        }

        public void Print()
        {
            Console.WriteLine("Student's name: " + name + Environment.NewLine + "Student's ID: " + id + Environment.NewLine + "Student's year was increased: " + ++year);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student maashok = new Student("Mariya", "18BD110992");
            maashok.year = 1;
            maashok.Print();
            Console.ReadKey();
        }
    }
}
