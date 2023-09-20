using System;

namespace InstanceFieldsProperty;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("*****Student 1******");
        Student student1 = new Student("Gökhan", "Okur", 241, "IT");
        student1.StudentInfo();

        Console.WriteLine("*****Student 2******");
        Student student2 = new Student("İlkay", "Seki", 240, "IT");
        student2.StudentInfo();

    }

    class Student
    {
        public string Name;
        public string Surname;
        public int No;
        public string Departman;

        public Student(string name, string surname, int no, string departman) // Constructor 
        {
            this.Name = name;
            this.Surname = surname;
            this.No = no;
            this.Departman = departman;
        }


        public void StudentInfo()
        {
            Console.WriteLine("Student Name: {0}", Name);
            Console.WriteLine("Student Surname: {0}", Surname);
            Console.WriteLine("Student No: {0}", No);
            Console.WriteLine("Student Departman: {0}", Departman);
            Console.ReadKey();
        }
    }
}
