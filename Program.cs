using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeApp
{
    class Program_1
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            string firstName = "Bob";
            int number = 32;
            float value = 5.32F;

            Console.WriteLine($"This is the order for {firstName}. He ordered {number} cheeseburgers.");
            Console.WriteLine($"His total comes to: ${value * number}.");
            
            Console.ReadLine();
        }
    }
}
