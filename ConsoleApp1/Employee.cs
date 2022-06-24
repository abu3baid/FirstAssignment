using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Employee
    {
        int id;
        string name;
        int age;
        string dob;
        double salary;
        bool isMale;

        public Employee(int id, string name, int age, string dob, double salary, bool isMale)
        {
            this.Id = id;
            this.Name = name;
            this.Age = age;
            this.Dob = dob;
            this.Salary = salary;
            this.IsMale = isMale;
        }
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public string Dob { get => dob; set => dob = value; }
        public double Salary { get => salary; set => salary = value; }
        public bool IsMale { get => isMale; set => isMale = value; }
    }
}
