using System;
namespace Methods
{

    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Sum of 4 and 5 = {0}",Add(4,5) );
            Mutiple(4, 5);
            Console.ReadLine();
        }
        public static int Add(int x, int y)
        {
            return x + y;
        }
        public static void Mutiple(int x, int y)
        {
            Console.WriteLine("Mutiple of {0} and {1} = {2} ",x,y,x * y);
        }

    }
}

