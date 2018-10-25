using stackAndQueue.classes;
using System;
using System.Collections.Generic;

namespace multiBracketValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string test = "dog";
            Console.WriteLine(test.Length);
            

            Console.WriteLine(MultiBracketValidation("()[[Extra Characters]]")); 
        }

        public static bool MultiBracketValidation(string input)
        {
            char[] inputArray = input.ToCharArray();
            Stack<char> stack = new Stack<char>();
            char character;

            if (inputArray[0] == ')' || inputArray[0] == ']' || inputArray[0] == '}')
            {
                return false;
            }

            for (int i = 0; i < input.Length; i++)
            {
                if (inputArray[i] == '(' || inputArray[i] == '[' || inputArray[i] == '{')
                {
                    stack.Push(input[i]);
                    continue;
                }

                switch (inputArray[i])
                {
                    case ')':
                        character = stack.Peek();
                        stack.Pop();
                        if (character == '{' || character == '[') return false;
                        break;

                    case '}':
                        character = stack.Peek();
                        stack.Pop();
                        if (character == '(' || character == '[') return false;
                        break;

                    case ']':
                        character = stack.Peek();
                        stack.Pop();
                        if (character == '{' || character == '(') return false;
                        break;
                }
            }

            return true;
        }
    }
}
