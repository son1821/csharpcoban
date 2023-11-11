// See https://aka.ms/new-console-template for more information
//While: xử lý với điều kiện true
//int a = 1;
//while (a <= 5)
//{
//    Console.WriteLine(a+"");
//    a++;
//}

//Do...While: Chạy trước rồi mới kiểm tra, nếu điều kiện true thì lặp tiếp
//int b;
//do
//{
//    Console.WriteLine("Input b: ");
//    b=Convert.ToInt32(Console.ReadLine());
//} while (b<=5);
//Console.WriteLine("Alright");

//For : xử lý với điều kiện true
//for (int i = 2; i < 6; i++)
//{
//    Console.WriteLine(i + "");
//}

//Foreach:Xử lý phần tử trên mảng
int[] Array = new int[10];
Random  r = new Random();
for(int i = 0;i < 10; i++)
{
    Array[i] = r.Next(1,10);
}
Console.WriteLine("Value of element:");
foreach (int val in Array)
{
    Console.WriteLine(val+"");
}

