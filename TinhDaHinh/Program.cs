
namespace TinhDaHinh
{
    class Program
    {
        public static void Main(string[] args)
        {
            Animal dog = new Dog();
            Animal cat = new Cat();
            dog.Name();
            cat.Name();
            Human asian = new Asian();
            asian.Name();
            Console.ReadLine();
        }
    }
     class Animal
    {
        public virtual void Name()
        {
            Console.WriteLine("DONG VAT");
        }
    }
    class Dog : Animal
    {
        public override void Name()
        {
            Console.WriteLine("CHO");
        }

    }
    class Cat : Animal
    {
        public override void Name()
        {
            Console.WriteLine("MEO");
        }
    }
    abstract class Human
    {
        public abstract void Name();
    }
     class Asian : Human
    {
        public override void Name()
        {
            Console.WriteLine("Nguoi Chau A");
        }
    }
}
