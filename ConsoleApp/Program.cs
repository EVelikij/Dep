using Common;
using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            IProduct prod = new Product();
            prod.Name = "Test";

            Console.WriteLine(prod.Name.ToString());
            Console.ReadKey();
        }
    }
}
