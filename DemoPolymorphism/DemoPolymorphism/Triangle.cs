using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPolymorphism
{
    class Triangle : Shape //inheriting
    {
        public override void Draw() //drawing from base class 
        {
            Console.WriteLine("Drawing a triangle");
            base.Draw();
        }
    }
}
