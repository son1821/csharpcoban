namespace Interface
{
    class Program
    {
        public static void Main(string[] args)
        {
            IName name = new Animal();
            name.Name();
            IName a = new Animal();
            Console.WriteLine("Số a ={0}", a.a(2));
            Console.ReadLine();
        }
    }
    interface IName
    {
        void Name();
        int a(int x);
    }
    class Animal:IName
    {
        public void Name()
        {
            Console.WriteLine("Animal");
        }
        public int a(int x)
        {
            return x;
        }
    }
}