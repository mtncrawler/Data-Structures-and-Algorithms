using System;
using System.Collections.Generic;
using System.Text;

namespace hashTables.Classes
{
    public class HashTable
    {
        public Node[] Table { get; set; }

        public int Size { get; set; }

        public int GetHash(string key)
        {
            decimal hashValue = 0;

            for (int i = 0; i < key.Length; i++)
            {
                hashValue += key[i];
            }

            return (int)Math.Ceiling(hashValue * 599 / Size);
        }

        public void Add(string key, object value)
        {
            int idx = GetHash(key);

            if (Table[idx] == null)
            {
                Table[idx] = new Node(key, value);
            } else
            {
                Table[idx].Next = new Node(key, value);
            }
        }

        public object Find(string key)
        {
            return Table[GetHash(key)].Value;
        }


    }
}
