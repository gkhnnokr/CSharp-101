namespace Enum;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(Days.Sunday); //Sunday
        Console.WriteLine((int)Days.Tuesday); //1
        Console.ReadKey();
    }
}

enum Days
{
    Monday, 
    Tuesday, 
    Wednesday, 
    Thursday, 
    Friday,
    Saturday,
    Sunday
}

