// See https://aka.ms/new-console-template for more information
const double Pi = 3.14;
Console.Write("Inport raidus:  ");
string inportRadius = Console.ReadLine();
double radius = double.Parse(inportRadius);
double circleArea = radius * radius * Pi;
Console.WriteLine("Circle Area = {0} ",circleArea);
Console.Read();


