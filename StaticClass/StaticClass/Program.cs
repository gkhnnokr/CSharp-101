using System;

namespace StaticClass;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Student Count: {0}", Student.StudentCount);
        Student student1 = new Student("Gökhan", "Okur", "HR");
        Console.WriteLine("Student Count: {0}", Student.StudentCount);
        

        Console.WriteLine("Plus : {0}", Process.Plus(100, 200));
        Console.WriteLine("Minus : {0}", Process.Minus(100, 200));
        Console.ReadKey();
    }

    class Student
    {
        private static int studentCount;

        public static int StudentCount { get => studentCount; }

        private string Name;

        private string Surname;

        private string Departman;

        static Student()
        {
            studentCount = 0;


        }

        public Student(string name, string surname, string departman)
        {
            this.Name = name;
            this.Surname = surname;
            this.Departman = departman;
            studentCount += 1;
        }
    }

    static class Process
    {
        public static int Plus(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int Minus(int num1, int num2)
        {
            return num1 - num2;
        }
    }
}

