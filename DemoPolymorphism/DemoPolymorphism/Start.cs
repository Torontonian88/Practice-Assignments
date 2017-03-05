using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPolymorphism
{
    class Start //create the object from the memory
    {
        static void Main(string[] arg) //start key of program
        {
            Shape s = new Circle(); //creating object in the memory varible "s"and calling shape called circle

            s.Draw(); //calling variable "s" to draw circle all draw method both from child and parent

            Console.ReadLine(); //read above line
        }
    }
}
