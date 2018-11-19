using hashTables.Classes;
using System;

namespace uniqueCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

        }

        public static bool UniqueCharacters(string input)
        {
            HashTable ht = new HashTable();
            ht.Table = new Node[1024];
            ht.Size = 1024;

            foreach (var item in input.ToLower().ToCharArray().ToString())
            {
                if (ht.Contains(item.ToString())) return false;
                else ht.Add(item.ToString(), item);
            }

            return true;
        }

        
    }
}
