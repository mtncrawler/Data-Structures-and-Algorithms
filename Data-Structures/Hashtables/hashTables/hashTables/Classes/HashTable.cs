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
            int idx = GetHash(key);

            if (Table[idx].Key == key) return Table[idx].Value;
            else
            {
                Node current = Table[idx];
                while (current != null)
                {
                    if (Table[idx].Key == key) return Table[idx].Value;
                    else current = current.Next;
                }
            }

            return null;
        }

        public bool Contains(string key)
        {
            int idx = GetHash(key);
            
            Node current = Table[idx];
            while (current != null)
            {
                if (current.Key == key) return true;
                else current = current.Next;
            }

            return false;
        }
    }
}
