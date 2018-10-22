using System;
using linkedList.classes;


namespace linkedListPalindrome
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Node node1 = new Node(2);
            Node node2 = new Node(4);
            Node node3 = new Node(4);
            Node node4 = new Node(2);
            Node node5 = new Node(300);
            Node node6 = new Node(25);

            LinkedList input = new LinkedList(node1);

            input.Add(node2);
            input.Add(node3);
            input.Add(node4);

            Console.WriteLine(ValidatePalindrome(input));
           

        }

        public static bool ValidatePalindrome(LinkedList input)
        {
            if (input.Current.Next == null)
            {
                return false;
            }

            int counter = 0;
            input.Current = input.Head;

            while (input.Current != null)
            {
                input.Current = input.Current.Next;
                counter++;
            }

            
            object[] test = new object[counter];
            counter = counter - 1;

            input.Current = input.Head;

            while (input.Current != null)
            {
                test[counter--] = input.Current.Value;
                input.Current = input.Current.Next;
            }

            for (int i = 0; i < test.Length/2; i++)
            {
                if ((int)test[i] != (int)test[test.Length - 1 - i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
