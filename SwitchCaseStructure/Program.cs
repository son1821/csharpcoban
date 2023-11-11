// See https://aka.ms/new-console-template for more information
using System.Text;

Console.OutputEncoding = Encoding.UTF8;
Console.WriteLine("Nhập một số từ 1 đến 8:");
var day = Console.ReadLine();
switch (day)
{
    case "2":
        Console.WriteLine("Thứ hai");
        break;
    case "3":
        Console.WriteLine("Thứ ba");
        break;
    case "4":
        Console.WriteLine("Thứ tư");
        break;
    case "5":
        Console.WriteLine("Thứ năm");
        break;
    case "6":
        Console.WriteLine("Thứ sáu");
        break;
    case "7":
        Console.WriteLine("Thứ bảy");
        break;
    case "1":
    case "8":
        Console.WriteLine("Chủ nhật");
        break;
    default:
        Console.WriteLine("Bạn đã nhập sai");
        break;
}
Console.Read();
