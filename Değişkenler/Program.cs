using System;

namespace Değişkenler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Informs user by writing directions on the terminal
            Console.WriteLine("You gotta give me something, write anything: ");

            //Creates a variable to store user input
            string inputString;

            //Stores user input into a variable
            inputString = Console.ReadLine();

            //Customary greetings of every new programmers first code
            Console.WriteLine("Hello World!");

            //Prints out user input on the terminal
            Console.WriteLine(inputString);
        }
    }
}
