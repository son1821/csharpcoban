// See https://aka.ms/new-console-template for more information
using OOP;

Person person1 = new Person();
person1.Name = "Nguyen Van A";
person1.Age = 30;
person1.SayName();
Person person2 = new Person("Nguyen Van B", 26);
person2.SayName();
Console.Read();