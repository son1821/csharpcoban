// See https://aka.ms/new-console-template for more information
using System.ComponentModel.Design;
using System.Text;

//Console.OutputEncoding = Encoding.UTF8;

//Bai1:

//Console.WriteLine("Giải phương trình ax+b=0 :");
//Console.Write("Nhập a:");
//double a = double.Parse(Console.ReadLine());
//Console.Write("Nhập b:");
//double b = double.Parse(Console.ReadLine());
//if (a != 0)
//{
//    double x = -b / a;
//    Console.WriteLine("Phương trình có một nghiệm là: {0}", x);
//} else if (b != 0){
//    Console.WriteLine("Phương trình vô nghiệm");
//}else
//{
//    Console.WriteLine("Phương trình vô số nghiệm");
//}

//Bai2:
//Console.WriteLine("Nhập a:");
//double a = double.Parse(Console.ReadLine());
//Console.WriteLine("Nhập b:");
//double b = double.Parse(Console.ReadLine());
//Console.WriteLine("Nhập c:");
//double c = double.Parse(Console.ReadLine());
//if(a != 0)
//{
//    double delta = b * b - 4 * a * c;
//    Console.WriteLine("Delta = {0}" , delta);
//    if (delta < 0)
//    {
//        Console.WriteLine("Phương trình vô nghiệm");
//    }
//    else if (delta == 0)
//    {
//        double x1 = -b / (2 * a);
//        double x2 = x1;
//        Console.WriteLine("Phương trình có nghiệm là : {0} , {1}", x1, x2);
//    }
//    else
//    {
//        double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
//        double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
//        Console.WriteLine("Phương trình có nghiệm là:  " + x1 +"," + x2);
//    }

//}
//else
//{
//    Console.WriteLine("Giải phương trình bx+c =0");
//}

//Bai 3:
//Console.WriteLine("Nhập số giai thừa:");
//uint factorialNumber = uint.Parse(Console.ReadLine());
//uint factorial = 1;

//if (factorialNumber == 0)
//{
//    Console.WriteLine("Giai thừa = 1");
//}
//else
//{
//   for (uint i = 1; i <= factorialNumber; i++)
//    {
//        factorial *= i;
//    }
//    Console.WriteLine("Giai Thừa = {0} ",factorial );
//}



//Bai 4:
using System;
namespace Baitapchuong2
{

    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập n");
            int n = int.Parse(Console.ReadLine());
            int numberOfPrime = 0;
            for (int i = 1; i <= n; i++)
            {
                if (IsPrime(i))
                {
                    numberOfPrime++;

                }
            }
            Console.WriteLine(":Tổng số nguyên tố có từ 1 đến {0} là {1}", n, numberOfPrime);
            Console.Read();
        }
        static bool IsPrime(int number)
        {
            int count = 0;
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    count++;
                }
            }
            return count == 2;

        }
    }
}

//Bai 5:

