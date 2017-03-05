using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPolymorphism //camel case
{
    class Shape //parent class - dont need main method for parent class - "blueprint" of whole program
    {
        public virtual void Draw() //creating method called draw - pretend calling draw method "virtual" - placeholder
        {
            Console.WriteLine("Performing a class drawing task"); 
        }
    }
}
