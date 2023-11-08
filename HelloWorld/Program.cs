using System;
namespace HelloWorld
{
    
    internal class Program
    {
        
        static void Main(string[] args)
        {
            int myInt = 5;
            double myDouble = myInt;//Sử dụng Implicit Casting chuyển đổi kiểu dữ liệu nhỏ hơn sang kiểu dữ liệu lớn hơn
            Console.WriteLine(myInt);
            Console.WriteLine(myDouble);
            //Sử dụng Explicit chuyển đổi kiểu dữ liệu lớn hơn sang kiểu dữ liệu nhỏ hơn
            //Casting chuyển 1 giá trị từ kiểu này sang kiểu khác hoặc xuất ra lỗi
            int five = 6;
            var doubleFive = (double)five;
            Console.WriteLine(five);
            Console.WriteLine(doubleFive);
            char a = 'l';
            var valuaA = (int)a;
            Console.WriteLine(valuaA);
            float myFloat = 3.27f;
            decimal myDecimal = (decimal)myFloat;
            Console.WriteLine(myDecimal);
            //Conversion chuyển một kiểu đối tượng sang kiểu khác, ít lỗi hơn nhưng chậm hơn
            decimal deFive = Convert.ToDecimal(five);
            Console.WriteLine(deFive);
            decimal myMoney = 4.48M;
            int myMoney1 = Convert.ToInt32(myMoney);
            Console.WriteLine(myMoney1);
            //Parsing chuyển một chuỗi sang kiểu nguyên thủy
            string testString = "102023";
            int intValue = int.Parse(testString);
            Console.WriteLine(intValue);
            //string testString1 = "một hai ba bốn";
            //double doubleValue = double.Parse(testString1);
            //Console.WriteLine(doubleValue);//Báo lỗi
      
            string value = "5.5.8";
            decimal result;
            bool isValue = decimal.TryParse(value, out result);//Sử dụng TryParse để kiểm tra
            Console.WriteLine(isValue);
            Console.WriteLine(result);
            
           
        }
           
    }
}
