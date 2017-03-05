//Liberaries: Stores Classes of information - aka Packages - premade
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddTwoNumbersConsole.App //Project name, folder, container
{//opening brace
    class Program //name of your class
    {
        static void Main(string[] args) //staring point for any program - i.e. key to start (car) - one main method
        {
            int x; //stores on the stack - premative variables
            int y;
            int results;
            Console.Write("\n Enter the first number to be added: "); // command line (write into the command window) question -string
            x = Convert.ToInt32(Console.ReadLine()); //convert above string into integer - console.write is string format - read it from the line

            Console.Write("\n the second number to be added: "); // command line (write into the command window) question -string "\n - new line
            y = Convert.ToInt32(Console.ReadLine()); //convert above string into integer - console.write is string format - read it from the line

            results = x + y;
            Console.Write("\n the result is: " + results); //concatinate two variables (add them together)
            Console.ReadLine(); //pauses the console so you can see results


        }
    }
}
