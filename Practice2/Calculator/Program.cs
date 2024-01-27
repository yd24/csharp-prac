using System.Diagnostics;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Basic Calculator!");
            Console.WriteLine("This calculator can perform addition, subtraction, multiplication, and division.");
            Console.WriteLine();
            Console.Write("Please enter your calculation: ");

            string response = Convert.ToString(Console.ReadLine());
        }
    }
}
