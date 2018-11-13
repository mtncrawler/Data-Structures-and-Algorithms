using System;
using System.Collections.Generic;
using System.Text;

namespace hashTables.Classes
{
    public class HashTable
    {
        public Node[] Table { get; set; }

        public 

        public int GetHash(string key)
        {
            int hashValue = 0;

            for (int i = 0; i < key.Length; i++)
            {
                hashValue += key[i];
            }
            
            return hashValue % key.Length;
        }
    }
}
