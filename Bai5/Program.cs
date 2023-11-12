// See https://aka.ms/new-console-template for more information
using System;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Bai5
{

    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Nhập vào n:");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++) 
            {
            Console.WriteLine(""+fibonacy(i));
            }
            Console.Read(); 
        }
        static int fibonacy(int n)
        {
            int f0 = 0;
            int f1 = 1;
            int fn = 1;
            int i;
            if (n < 0)
            {
                return 0;
            }
            else if (n==0||n == 1)
            {
                return n;
            }
            else
            {
                for (i = 2; i < n; i++)
                {
                    f0 = f1;
                    f1 = fn;
                    fn = f0 + f1;
                }
            }
            return fn;
        }
    }
}
