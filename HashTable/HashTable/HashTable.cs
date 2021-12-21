using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    class HashTable <TKey, TValue>
    {
        private TValue[] Items = new TValue[2000];
        private TValue DelitSimbol {get; set;} 

        public TValue[] GetItems()
        {
            return Items;
        }
        
        public HashTable(TValue delitSimbol){
        DelitSimbol = delitSimbol;
       } 

        public void Add(TKey key, TValue item)
        {
            int HashCode = HashFucntion(key);
            int index = HashCode % 999;
            while (index < Items.Length)
            {
                if (!Items[index].Equals(0) && !Items[index].Equels(DeliteSymbol))
                {
                    index++;
                }
                else
                {
                    Items[index] = item;
                    break;
                }
            }
        }

        public bool Search(TKey key, TValue value)
        {
            int hashKey = HashFucntion(key);
            int breakCounter = 0;
            for(int i = hashKey; i < Items.Length; i++)
            {
                if (Items[i].Equals(value))
                {
                    return true;
                }
                if (Items[i].Equals(0))
                {
                    breakCounter++;
                }
                if(breakCounter >= 3)
                {
                    break;
                }
            }
            return false;
        }

        public void Deleat(TKey key, TValue value)
        {
            int hashKey = HashFucntion(key);
            for(int i = hashKey; i < Items.Length; i++)
            {
                if (Items[i].Equals(value))
                {
                    Items[i] = DeliteSimbol;
                    break;
                }
            }
        }

        public int HashFucntion(TKey key)
        {
            var Random = new Random();
            string Item = Convert.ToString(key);
            int result = 0;
            for(int i = 0; i < Item.Length; i++)
            {
                result = ((((Item[i] << 55) - i) >> 12) * i) % Items.Length - 1; 
            }
            return Math.Abs(result);
        }
    }
}
