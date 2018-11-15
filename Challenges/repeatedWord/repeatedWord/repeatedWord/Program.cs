using System;
using hashTables.Classes;

namespace repeatedWord
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string input = "It was a queer sultry summer and the summer they electrocuted the Rosenbergs and I didn’t know what I was doing in New York...";

            Console.WriteLine(RepeatedWord(input));
            
        }

        public static string RepeatedWord(string input)
        {
            HashTable ht = new HashTable();
            ht.Table = new Node[1024];
            ht.Size = 1024;

            foreach (var item in input.Split(' '))
            {
                if(ht.Table[ht.GetHash(item)] == null)
                {
                    ht.Add(item, item);
                } else
                {
                    return item;
                }
            }

            return null;
        }
    }
}
