using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Teacher teacher1 = new Teacher(1, "Mohammed", 24, "28/1/1992", 1323.21, true, "C01");
            Student student1 = new Student(1, "Ahmed", 18, "C01");

            teacher1.print();
            Console.WriteLine("\n===============\n");
            student1.print();
        }
    }
}
