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
    }
}
