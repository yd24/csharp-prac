namespace DataStructuresTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //testing IntStack
            var stack = new IntStack(10);
            for (int i = 0; i < 10; i++)
            {
                stack.Push(i);
                Console.WriteLine(stack.Peek());
            }

            for (int i = 0; i < 10; i++)
            {
                int popped = stack.Pop();
                Console.WriteLine($"{popped} is popped and {stack.Peek()} is next");
            }

            for (int i = 0; i < 20; i++)
            {
                stack.Push(i);
            }

            for (int i = 0; i <= stack.Count(); i++)
            {
                Console.WriteLine(stack.Pop());
            }
        }
    }
}
