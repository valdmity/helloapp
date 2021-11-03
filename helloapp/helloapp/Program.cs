using System;

namespace helloapp
{
    internal class Program
    {
        public static void GreetBlack()
        {
            Console.WriteLine("hello black");
        }
        
        public static void GreetWhite()
        {
            Console.WriteLine("hello white");
        }
        
        public static void Main(string[] args)
        {
            Console.WriteLine("hello everyone");
            GreetWhite();
            GreetBlack();
        }
    }
}