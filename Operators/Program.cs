//Arithmetic: Toán tử số học

int i = 3;//Increment: Toán tử tăng
Console.WriteLine(i);
Console.WriteLine(i++);
Console.WriteLine(i);
Console.WriteLine(++i);
int x = 5;//Decrement: Toán tử giảm
Console.WriteLine(x);
Console.WriteLine(x--);
Console.WriteLine(x);
Console.WriteLine(--x);
Console.WriteLine(5*2);//Multiplication: Toán tử nhân
Console.WriteLine(0.5 * 0.5);
Console.WriteLine(5 / 1);//Division: Toán tử chia
Console.WriteLine(5 / 0.3);
Console.WriteLine(5 % 4);//Remainde: Lấy số dư
Console.WriteLine(5 + 4); //Addition: Phép cộng
Console.WriteLine(0.5 + 5);
Console.WriteLine(5-3);//Subtraction: Phép trừ
Console.WriteLine(5 - 0.3);

//Assignment: Toán tử gán
int b = 4;
b += 1;
Console.WriteLine(b);
b -= 1;
Console.WriteLine(b);
b *= 2;
Console.WriteLine(b);
b /= 2;
Console.WriteLine(b);
b %= 3;
Console.WriteLine(b);

//Comparison: Toán tử so sánh
int c = 1, d = 2 - 1;
Console.WriteLine(c == d);
int e = 3, f = 4;
Console.WriteLine(e != f);
Console.WriteLine(e < f);
Console.WriteLine(e > c);
Console.WriteLine(e >= d);
Console.WriteLine(e <= f);

//  Logical: Toán tử logic
bool passed = true;
Console.WriteLine(!passed);//logic phủ định
Console.WriteLine(!false);
Console.WriteLine(true^true);//logic mũ
Console.WriteLine(true^false);
Console.WriteLine(false^false);
Console.WriteLine(false^true);
bool check = true;// logic and
bool check1 = true & check;
Console.WriteLine(check1);
bool check2 = false & check;
Console.WriteLine(check2);
bool check3 = false | check;//logic or
Console.WriteLine(check3);
bool check4 = true | check;
Console.WriteLine(check4);
bool check5 = true &&  check;// logic and and
Console.WriteLine(check5);
bool check6 = true || check;//logic oror
Console.WriteLine(check6);