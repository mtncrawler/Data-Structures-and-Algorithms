using linkedList.classes;
using System;

namespace findKthValue
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Node node1 = new Node("banana");
            Node node2 = new Node(79);
            Node node3 = new Node(true);
            Node node4 = new Node("friyah");
            Node node5 = new Node(300);

            LinkedList testList = new LinkedList(node1);
            testList.Add(node2);
            testList.Add(node3);
            testList.Add(node4);
            testList.Add(node5);

            testList.Print();

            Console.WriteLine(FindKthValue(testList, 3));
            
        }

        public static object FindKthValue(LinkedList testList, int k)
        {
            if( k < 0)
            {
                return "Exception: Please enter a non-negative number.";
            }

            testList.Current = testList.Head;
            int counter = 0;

            while (testList.Current.Next != null)
            {
                testList.Current = testList.Current.Next;
                counter++;
            }

            if ( k > counter )
            {
                return "Exception: Invalid k value.";
            }

            testList.Current = testList.Head;
            while (counter > k)
            {
                testList.Current = testList.Current.Next;
                counter--;
            }

            return testList.Current.Value;
        }
    }
}
