using System;
namespace Methods
{

    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Số lượng con mèo đang có :{0}", Cat.Count);
            Cat blackCat = new Cat();
            Console.WriteLine("Số lượng con mèo đang có :{0}", Cat.Count);
            Cat whiteCat = new Cat();
            Console.WriteLine("Số lượng con mèo đang có :{0}", Cat.Count);
            Console.WriteLine("Tổng của 2 số là: {0}", Cat.Sum(3, 4));
            Console.WriteLine("Màu sắc hôm nay là :{0}", MauSac.MauChuDao);
            Console.ReadLine();
        }
      
    }
    class Cat
    {
        private double Weight;// khởi tạo thuộc tính
        private double Height;
        public double weight //đóng gói
        {
            get { return Weight; }
            set { Weight = value; }
        }
        public double height
        {
            get { return Height; }
            set { Height = value; }
        }
        public static int Count = 0;//khởi tạo biến tính Count
        public Cat()//khởi tạo contructor
        {
            weight = 300;
            height = 200;
            Count++;
        }
        public static double Sum (double Number1, double Number2)// khởi tạo phương thức tĩnh
        {
            return Number1 + Number2;
        }
    }
    class MauSac
    {
        public static string MauChuDao;
        static MauSac()
        {
            DateTime dateTime = DateTime.Now;
            switch(dateTime.DayOfWeek)
            {
                case DayOfWeek.Sunday:
                    MauChuDao = "Yelow";
                    break;
                case DayOfWeek.Saturday:
                    MauChuDao = "Green";
                    break;
                case DayOfWeek.Friday:
                    MauChuDao = "Black";
                    break;
                case DayOfWeek.Thursday:
                    MauChuDao = "Pink";
                    break;
                case DayOfWeek.Wednesday:
                    MauChuDao = "Purple";
                    break;
                case DayOfWeek.Tuesday:
                    MauChuDao = "Red";
                    break;
                default:
                    MauChuDao = "Blue";
                    break;
            }
        }
    }
}

