using Microsoft.VisualBasic;
using System;
namespace HelloWorld
{
    
    internal class Program
    {
        const int MyNumber4 = 16;// Sử dụng constants khai báo một biến không thay đổi
        const double Pi = 3.14159;
        const string HeadLine = "Chao Mung Ban!";
        const string MyPhoneNumber = "123456789";
        static void Main(string[] args)
        {
            Console.WriteLine("My Phone Number : {0}", MyPhoneNumber);
            Console.ReadLine();
        }
           
    }
}
