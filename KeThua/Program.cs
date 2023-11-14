using System;
namespace KeThua
{

    internal class Program
    {
        public static void Main(string[] args)
        {
            Cat cat = new Cat();
            cat.Infor();
            Cat cat1 = new Cat(500,600,2);
            cat1.Infor();
            Console.ReadLine();
        }
       

    }
    class Animal
    {
        protected int Weight;
        protected int Height;
        protected int Foot;
        public void Infor()
        {
            Console.WriteLine("Weight :{0}, Height: {1}, Foot: {2}",Weight, Height,Foot);
        }
        public Animal() { }
        public Animal(int w, int h, int f)
        {
            Weight = w;
            Height = h;
            Foot = f;
        }
    }
}

