using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Student
    {
        int StudentId;
        string StudentName;
        int StudentAge;
        string classId;

        public Student(int studentId, string studentName, int studentAge, string classId)
        {
            StudentId1 = studentId;
            StudentName1 = studentName;
            StudentAge1 = studentAge;
            this.ClassId = classId;
        }
        public int StudentId1 { get => StudentId; set => StudentId = value; }
        public string StudentName1 { get => StudentName; set => StudentName = value; }
        public int StudentAge1 { get => StudentAge; set => StudentAge = value; }
        public string ClassId { get => classId; set => classId = value; }

        public void print()
        {
            Console.WriteLine("ID: " + StudentId + "\nName: " + StudentName + "\nAge: " + StudentAge + "\nClass: " +  classId);
        }

    }
}
