using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPolymorphism
{
    class Circle : Shape //inheriting from parent class "shape" //Java would be this class circle extends shape
    {
        public override void Draw() //draw is a method
        {
            Console.WriteLine("Drawing a Circle"); //calling the same method but the outcome is different
            base.Draw();
        }
    }
}
