namespace Struct;

class Program
{
    static void Main(string[] args)
    {
        Rectangle rectangle = new Rectangle();
        rectangle.Shorta = 5;
        rectangle.Longa = 10;

        Console.WriteLine("Class Area: {0}",rectangle.CalculateArea());

        Rectangle_Struct rectangle_Struct;

        rectangle_Struct.Shorta = 10;
        rectangle_Struct.Longa = 20;

        Console.WriteLine("Struct Area: {0}", rectangle_Struct.CalculateArea());
        Console.ReadLine();

    }

    class Rectangle
    {
        public int Shorta;
        public int Longa;

        //public Rectangle()
        //{
        //    Shorta = 5;
        //    Longa = 10;
        //}

        public long CalculateArea()
        {
            return this.Shorta*this.Longa;
        }
    }

    struct Rectangle_Struct
    {
        public int Shorta;
        public int Longa;

        //public Rectangle_Struct(int Shorta, int Longa)
        //{
        //    Shorta = 5;
        //    Longa = 10;
        //}

        public long CalculateArea()
        {
            return this.Shorta * this.Longa;
        }
    }
}