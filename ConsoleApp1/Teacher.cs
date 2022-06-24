using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Teacher : Employee
    {
        string classId;
        public Teacher(int id, string name, int age, string dob, double salary, bool isMale, string classId) : base(id, name, age, dob, salary, isMale)
        {
            this.ClassId = classId;
        }
        public string ClassId { get => classId; set => classId = value; }

        public void print()
        {
            Console.WriteLine("ID: " + Id + "\nName: " + Name + "\nAge: " + Age + "\nBirth Date: " + Dob + "\nSalary: " + Salary + "\nis Male?: " + IsMale + "\nClassId: " + ClassId);
        }
    }

}
