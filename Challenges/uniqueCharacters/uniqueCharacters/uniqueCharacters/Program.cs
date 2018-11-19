using hashTables.Classes;
using System;

namespace uniqueCharacters
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Unique Characters!");

            string input = "letsgohome";

            Console.WriteLine($"Does {input} have unique characters?");
            Console.WriteLine(UniqueCharacters(input));

        }

        public static bool UniqueCharacters(string input)
        {
            HashTable ht = new HashTable
            {
                Table = new Node[1024],
                Size = 1024
            };

            foreach (var item in input.ToLower())
            {
                if (ht.Contains(item.ToString())) return false;             
                else ht.Add(item.ToString(), item);
            }

            return true;
        }

        
    }
}
