using System;

namespace Program1
{
    public class Program
    {
        static void Main(string[]args)
        {
            Console.WriteLine("Imput your name:");
            string name = Console.ReadLine();
            Console.WriteLine("Hi, " + name);
            Console.WriteLine("Press <Enter> for exit");
            Console.ReadLine();
        }    
    }

}