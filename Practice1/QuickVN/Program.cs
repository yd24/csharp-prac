using System;
using System.Linq;
using System.Collections.Generic;

namespace QuickVN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //initial prompt
            Console.WriteLine("You enter a tavern and decide to get a drink.");
            Console.WriteLine("The bartender looks at you with a grumpy expression and asks for your order.");
            Console.WriteLine("You can pick from the following:");

            //list options
            List<string> drinks = new List<string> { "Frosty Ale", "Big Bob's Beer", "Pineapple Cider" };
            for (int i = 0; i < drinks.Count; i++)
            {
                Console.WriteLine($"\t {drinks[i]}");
            }

            //get response
            Console.Write("What is your order: ");
            string response = Convert.ToString(Console.ReadLine());
            bool checkValidResponse = drinks.Contains(response, StringComparer.OrdinalIgnoreCase);

            //ask again if user doesn't make a valid order
            while (!checkValidResponse)
            {
                Console.WriteLine("The bartender just glares at you. Looks like he doesn't have that drink.");
                Console.Write("What is your order: ");
                response = Convert.ToString(Console.ReadLine());
                checkValidResponse = drinks.Contains(response, StringComparer.OrdinalIgnoreCase);
            }

            //finish the prompt
            int index = drinks.FindIndex(drink => drink.Equals(response, StringComparison.OrdinalIgnoreCase));
            Console.WriteLine("The bartender grunts and gets you your drink.");
            Console.WriteLine($"You successfully drank {drinks[index]}!");
        }
    }
}
