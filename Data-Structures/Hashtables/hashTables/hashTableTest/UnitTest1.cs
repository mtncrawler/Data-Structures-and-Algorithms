using hashTables.Classes;
using System;
using Xunit;

namespace hashTableTest
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("doggie", 200)]
        [InlineData("Happies", true)]
        [InlineData("cats?", "Sandwich")]
        public void AddKeyValueToHashTable(string key, object value)
        {
            HashTable ht = new HashTable();
            ht.Table = new Node[1024];
            ht.Size = 1024;
            ht.Add(key, value);

            Assert.Equal(value, ht.Table[ht.GetHash(key)].Value);
        }

        [Theory]
        [InlineData("doggie", 200)]
        [InlineData("Happies", true)]
        [InlineData("cats?", "Sandwich")]
        public void FindValueFromKey(string key, object value)
        {
            HashTable ht = new HashTable();
            ht.Table = new Node[1024];
            ht.Size = 1024;
            ht.Add(key, value);

            Assert.Equal(value, ht.Find(key));
        }

        [Theory]
        [InlineData("doggie", 200)]
        [InlineData("Happies", true)]
        [InlineData("cats?", "Sandwich")]
        public void HashTableContainsKey(string key, object value)
        {
            HashTable ht = new HashTable();
            ht.Table = new Node[1024];
            ht.Size = 1024;
            ht.Add(key, value);

            Assert.True(ht.Contains(key));
        }

        [Theory]
        [InlineData("toto", "Lunch")]
        [InlineData("binary", "Nerd")]
        public void Collisions(string key, object value)
        {
            HashTable ht = new HashTable();
            ht.Table = new Node[1024];
            ht.Size = 1024;
            Node inline = new Node(key, value);
            ht.Add(key, value);
            ht.Add(inline.Key, inline.Value);

            Node n1 = new Node(key, value);
            n1.Next = inline;

            Assert.Equal(n1.Next.Value, ht.Table[ht.GetHash(key)].Next.Value);
        }
    }
}
