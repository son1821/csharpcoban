using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Person
    {
        public Person() { }
        public Person(string name, ushort age) 
        { 
        Name = name;
            Age = age;
        }
        public string Name { set; get; }
        public ushort Age {  set; get; }  
        public void SayName()
        {
            Console.WriteLine(this.Name);
            Console.WriteLine(this.Age);
        }

    }
}
