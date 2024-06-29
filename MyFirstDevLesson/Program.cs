using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstDevLesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Part 1 Print a string to the console
            //hint: Console.WriteLine("Hello World!");

            //Part 2 Get user input and print it to the console
            //hint: Console.ReadLine();

            //Part 3 Get two inputs from the user and print them on separate lines
            //hint: use \n to create a new line

            Console.WriteLine("Hello world!");
            Console.WriteLine("Please write your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Please enter your age and country: ");
            int age = int.Parse(Console.ReadLine());
            string country = Console.ReadLine();
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Hello, my name is " +  name);
            Console.WriteLine("I'm " + age +"\nI'm from " + country);
            Console.ReadKey();
        }
    }
}
