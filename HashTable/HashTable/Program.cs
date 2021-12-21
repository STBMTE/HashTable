using System;

namespace HashTable
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var hash = new HashTable<int, int>();
            for(int i = 0; i < 1000; i++)
            {
                hash.Add(i, 51216 - i);
            }
            var Items = hash.GetItems();
            foreach (var item in Items)
            {
                if (item != 0)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}