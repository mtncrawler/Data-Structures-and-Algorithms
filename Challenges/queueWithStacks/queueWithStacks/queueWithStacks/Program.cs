using stackAndQueue.classes;
using System;
using System.Collections.Generic;
using queueWithStacks.classes;

namespace queueWithStacks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            QueueWithStacks();
        }

        public static void QueueWithStacks()
        {

            Node node1 = new Node(10);
            Node node2 = new Node(20);
            Node node3 = new Node(30);

            QueueWithStacks queue = new QueueWithStacks(node1);

            queue.Enqueue(node2);
            queue.Enqueue(node3);

            Console.WriteLine($"The front node value: {queue.Front.Value}");

            queue.Dequeue();
            Console.WriteLine($"The value of the removed node : {queue.Front.Value}");
      
        }
    }
}
