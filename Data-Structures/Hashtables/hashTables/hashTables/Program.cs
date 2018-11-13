using System;
using hashTables.Classes;

namespace hashTables
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Hash Tables!");

            HashTable ht = new HashTable();
            ht.Table = new Node[1024];
            ht.Size = 1024;

            ht.Add("doggo", "Kodiak");
            ht.Add("cats?", 0);
            ht.Add("vacation", "Patagonia");

            ht.Table[ht.GetHash("doggo")].Next = new Node("gogod", "Tuna");

            Console.WriteLine();
            Console.WriteLine("Your hash table contains:");
            Console.WriteLine("doggo : Kodiak, gogod : Tuna");
            Console.WriteLine("cats? : 0");
            Console.WriteLine("vacation: Patagonia");

            Console.WriteLine();
            Console.WriteLine("Keys confirmed in hash table:");
            Console.WriteLine(ht.Contains("doggo"));
            Console.WriteLine(ht.Contains("gogod"));
            Console.WriteLine(ht.Contains("cats?"));
            Console.WriteLine(ht.Contains("vacation"));

        }
    }
}
