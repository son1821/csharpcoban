using KeThua;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeThua
{
    internal class Class1
    {
        
    }
    class Cat : Animal
    {
       public Cat() {
            Weight = 200;
            Height = 300;
            Foot = 4;
        }
        public Cat(int w , int h , int f ):base(w,h,f) {
        
        
         }
        
    }

}
