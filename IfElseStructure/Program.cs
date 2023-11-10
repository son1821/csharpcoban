// See https://aka.ms/new-console-template for more information
using System.Text;

Console.OutputEncoding = Encoding.UTF8;
//Console.Write("Nhập vào một số:");
//double number = double.Parse(Console.ReadLine());
//if(number % 2 == 0)
//{
//    Console.WriteLine("Số bạn nhập là số chẵn");
//}else
//{
//    Console.WriteLine("Số bạn nhập là số lẻ");
//}
//Console.WriteLine("Mời bạn nhập giá của sản phẩm:");
//double price = double.Parse(Console.ReadLine());
//Console.WriteLine("Đã bao gồm thuế VAT chưa? y/n");
//string awser = Console.ReadLine();
//bool includeVat = awser == "y" ? true : false;
//if (includeVat == false)
//{
//    price += (price * 0.1);
//}
//Console.WriteLine("Giá của sản phẩm là: {0}", price);
/*chỉ Chỉ số BMI từ 18,5 đến 24,9. 
Chỉ số BMI dưới 18,5 được coi là thiếu cân,
trong khi chỉ số BMI từ 25 đến 29,9 được coi là thừa cân 
và chỉ số BMI từ 30 trở lên được coi là béo phì.
BMI = cân nặng (kg) / chiều cao² (m)*/
Console.Write("Nhập cân nặng của bạn(kg):");
double weight = double.Parse(Console.ReadLine());
Console.WriteLine("Nhập chiều cao của b(m):");
double height = double.Parse(Console.ReadLine());
double bmi = weight / (height * height);
Console.WriteLine("chỉ số BMI của b là: {0}", bmi);
if (bmi > 30)
{
    Console.WriteLine("Bạn đã bị béo phì");
}else if (25 <= bmi && bmi <= 29.9){
    Console.WriteLine("Bạn đã thừa cân");
}else if (18.5 <= bmi && bmi <= 24.9)
{
    Console.WriteLine("Bạn cân đối");
}
else
{
    Console.WriteLine("Bạn bị thiếu cân");
}

Console.Read();