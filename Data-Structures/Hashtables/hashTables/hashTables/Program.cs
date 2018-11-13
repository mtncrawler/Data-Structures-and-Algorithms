using System;
using hashTables.Classes;

namespace hashTables
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            HashTable ht = new HashTable();
            ht.Table = new Node[1024];
            ht.Size = 1024;

            ht.Add("doggo", "Kodiak");

            Console.WriteLine(ht.Table[ht.GetHash("doggo")].Value);

        }
    }
}
