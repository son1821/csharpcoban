// See https://aka.ms/new-console-template for more information
string inportA;
Console.Write("Inport The Value of a: ");
inportA = Console.ReadLine();
string inportB;
Console.Write("Inport The Value of b: ");
inportB = Console.ReadLine();
int a = int.Parse(inportA);
int b = int.Parse(inportB);
int total = a + b;
Console.WriteLine("Sum of {0} and {1} is: {2}", a, b, total);
Console.Read();