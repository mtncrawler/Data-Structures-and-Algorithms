using System;
using stackAndQueue.classes;

namespace stackAndQueue
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Stacks and Queues!");
            Console.WriteLine();

            Node node1 = new Node(10);
            Node node2 = new Node(20);
            Node node3 = new Node(30);
            Node node4 = new Node(40);
            Node node5 = new Node(50);
            Node node6 = new Node(60);

            Stack myStack = new Stack(node1);
            myStack.Push(node2);
            myStack.Push(node3);

            Queue myQueue = new Queue(node4);
            myQueue.Enqueue(node5);
            myQueue.Enqueue(node6);

            Console.WriteLine("This is your stack: ");
            Console.WriteLine($"{myStack.Peek().Value}");
            myStack.Pop();
            Console.WriteLine($"{myStack.Peek().Value}");
            myStack.Pop();
            Console.WriteLine($"{myStack.Peek().Value}");
            myStack.Pop();
            Console.WriteLine();

            Console.WriteLine("This is your queue: ");
            Console.WriteLine($"{myQueue.Peek().Value}");
            myQueue.Dequeue();
            Console.WriteLine($"{myQueue.Peek().Value}");
            myQueue.Dequeue();
            Console.WriteLine($"{myQueue.Peek().Value}");
            myQueue.Dequeue();

        }
    }
}
