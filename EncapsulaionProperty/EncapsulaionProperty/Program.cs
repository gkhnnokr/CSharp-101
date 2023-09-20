using System;
using System.Globalization;

namespace Encapsulation;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("*****Student 1******");
        Student student1 = new Student("Gökhan", "Okur", 5, "IT");
        student1.ClassNoUp();
        student1.StudentsInfo();

        Console.WriteLine("*****Student 2******");
        Student student2 = new Student("İlkay", "Seki", 3, "IT");
        student2.ClassNoDown();
        student2.StudentsInfo();
        student2.ClassNoDown();
        student2.StudentsInfo();
        student2.ClassNoDown();
        student2.StudentsInfo();

    }

    class Student
    {
        private string name;
        private string surname;
        private int classNo;
        private string departman;

        public string Name { get => name; set => name = value; }

        public string Surname { get => surname; set => surname = value; }

        public int Class
        {
            get => classNo;
            set
            {
                if(value < 1)
                {
                    Console.WriteLine("at least one");
                    classNo = 1;
                }
                else  
                    classNo = value;
            }
        }

        public string Departman { get => departman; set => departman = value; }

        public Student(string name, string surname, int classNo, string departman)
        {
            Name = name;
            Surname = surname;
            Class = classNo;
            Departman = departman;
        }

        public Student() { }

        public void StudentsInfo()
        {
            Console.WriteLine("***Student Info***");
            Console.WriteLine("Student Name: {0}", this.Name);
            Console.WriteLine("Student Surname: {0}", this.Surname);
            Console.WriteLine("Student Class No: {0}", this.Class);
            Console.WriteLine("Student Departman: {0}", this.Departman);
            Console.ReadKey();
        }

        public void ClassNoUp()
        {
            this.Class = this.Class+1;
        }

        public void ClassNoDown()
        {
            this.Class = this.Class-1;
        }
    }
}

