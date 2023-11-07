using System;
namespace HelloWorld
{
    class Student
    {
        public string StudentName { set; get; }
    }
    internal class Program
    {
        static void ChangeReferenceType(Student std2)
        {
            std2.StudentName = "Barry";
        }
        static void ChangeValue(int x)                        
        {
            x = 3;
            Console.WriteLine("X = "+x);    
        }
        static void Main(string[] args)
        {
            Student std1 = new Student();
            std1.StudentName = "Shark";
            ChangeReferenceType(std1);
            Console.WriteLine(std1.StudentName);
            //int i = 5;
            ////Console.WriteLine(i);
            //ChangeValue(i);
            ////Console.WriteLine("I = "+i);
            Console.Read();
        }
    }
}
