using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetterAddTwoNumbersConsoleApp
{
    class Program
    {
        //global variables
        static int number1;
        static int number2;

        //constructor to create two variables for each object
        public Program(int x, int y)
        {
            number1 = x;
            number2 = y;
        }

        public int add2numbers() { //created function on top of static
            return (number1 + number2);
        }
            
        static void Main(string[] args) //start key of the program - only one "static"
        {
            Program values = new Program(3, 5); //created an object - called class name - value goes into class memory in heap - created using "new" key word


            int result = values.add2numbers(); //integer that stores a function/method
            Console.WriteLine("\n The Result of " + number1 + " + " + number2 + " is " + result);

            Console.ReadLine();
        }
    }
}
