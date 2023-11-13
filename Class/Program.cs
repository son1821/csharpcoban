using System;
namespace Class
{

    class Program
    {
        public static void Main(string[] args)
        {
            //Animal dog = new Animal(); //khởi tạo object
            //dog.Weight = 1;//gán giá trị thuộc tính của object
            //dog.Height = 2;
            //Animal cat = new Animal() ;
            //cat.Weight = 3;
            //cat.Height = 4;
            //dog.Run(); //gọi phương thức của đối tượng
            //cat.Run();
            Cat blackCat = new Cat();
            Cat whiteCat = new Cat(3,4);
            blackCat.Write();
            whiteCat.Write();
           
            Console.ReadKey();


        }



    }
    class Animal // lớp
    {
        public double Weight; //thuộc tính
        public double Height; // thuộc tính
        public void Run() //phương thức 
        {
            Console.WriteLine("Weight: {0}, Height: {1}", Weight, Height);
        }
    }
    class Cat
    {
       
        public double Weight;
        public double Height;
        public Cat() //Contructor không tham số
        {
            Weight = 2;
            Height = 3;
        }
        public Cat(double weight, double height) //Contructor có tham số
        {
            Weight = weight;
            Height = height;
        }
        public void Write()
        {
            Console.WriteLine("Weight: {0}, Height: {1}", Weight, Height);
        }

    }


}
