namespace DataStructuresTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //testing IntStack
            Console.WriteLine("Testing Stack data structure.");
            var stack = new IntStack(10);

            Console.WriteLine("Testing Push and Peek method.");
            for (int i = 0; i < 10; i++)
            {
                stack.Push(i);
                Console.WriteLine(stack.Peek());
            }

            Console.WriteLine("Testing Pop and Peek method.");
            for (int i = 0; i < 10; i++)
            {
                int popped = stack.Pop();
                Console.WriteLine($"{popped} is popped and {stack.Peek()} is next");
            }

            Console.WriteLine("Testing dynamic resizing.");
            for (int i = 0; i < 20; i++)
            {
                stack.Push(i);
            }

            for (int i = 0; i <= stack.Count(); i++)
            {
                Console.WriteLine(stack.Pop());
            }

            Console.WriteLine("Stack test complete.");

            //testing IntLinkedList
            Console.WriteLine("Testing Linked List data structure.");
            var list = new IntLinkedList();

            Console.WriteLine("Testing AddLast method.");
            list.AddLast(1);
            list.AddLast(2);

            ListNode? current = list.head;
            while (current != null)
            {
                Console.WriteLine(current.val);
                current = current.next;
            }


            Console.WriteLine("Testing AddFirst method.");
            list.AddFirst(3);
            list.AddFirst(4);

            current = list.head;
            while (current != null)
            {
                Console.WriteLine(current.val);
                current = current.next;
            }

            Console.WriteLine("Testing Remove method.");
            list.Remove(1);
            current = list.head;
            while (current != null)
            {
                Console.WriteLine(current.val);
                current = current.next;
            }
            list.Remove(1);

            Console.WriteLine("Testing RemoveFirst method.");
            list.RemoveFirst();
            current = list.head;
            while (current != null)
            {
                Console.WriteLine(current.val);
                current = current.next;
            }

            Console.WriteLine("Testing RemoveLast method.");
            list.RemoveLast();
            current = list.head;
            while (current != null)
            {
                Console.WriteLine(current.val);
                current = current.next;
            }

            Console.WriteLine("Testing Clear method.");
            list.Clear();
            list.RemoveFirst();
            list.RemoveLast();
            current = list.head;
            while (current != null)
            {
                Console.WriteLine(current.val);
                current = current.next;
            }

            Console.WriteLine("Linked List test complete.");
        }
    }
}
