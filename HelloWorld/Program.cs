using System;
namespace HelloWorld
{
    
    internal class Program
    {
        
        static void Main(string[] args)
        {
            /*Console.WriteLine("Print on ");   //in chuỗi xuông dòng
            Console.WriteLine("New Line ");
            Console.Write("Print on ");       //in chuỗi bình thường, không xuống
            Console.Write("Same line");
            Console.WriteLine();
            int value = 10;
            //Variable
            Console.WriteLine(value);
            //Literal
            Console.WriteLine(50.05);
            Console.WriteLine("Hello " + "World"); //kết nối chuỗi bằng dấu +
            Console.WriteLine("Value = " + value);
            Console.WriteLine("Value = {0}", value);//Sử dụng Fomatted string giữa chỗ cho biến
            int firstNumber = 6; int seccondNumber = 4; int result = firstNumber+seccondNumber;
            Console.WriteLine("{0} + {1} = {2}", firstNumber, seccondNumber, result); // mỗi một biến được sử dụng sẽ có một placeholder
            */
            string testString;
            Console.Write("Enter a string - ");
            testString = Console.ReadLine();// ReadLine() đọc dòng tiếp theo của input
            Console.WriteLine("You ented '{0}'", testString);
            
            int userInput;
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();// ReadKey() tiếp nhận phím tiếp theo mà user ấn và trả về phím đó
            Console.WriteLine();
            Console.WriteLine("Input using Read() -");
            userInput = Console.Read();//Read() đọc ký tự đầu tiên của input, trả về giá trị ascii;
            Console.WriteLine("Ascii Value = {0}", userInput);
            Console.Read();
            
        }
           
    }
}
