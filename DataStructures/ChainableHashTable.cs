using System;
using System.Text;

namespace DataStructures
{
    public class ChainableHashTable<TKey, TValue> : HashTable<TKey, TValue>
    {

        private List<(TKey key, TValue value)>[] chainableArray;

        public ChainableHashTable()
        {
            chainableArray = new List<(TKey key, TValue value)>[length];
        }

        public override void Add(TKey key, TValue value)
        {

            if(loadFactorThresholdReached)
                ReHash();

            int hash = Hash(key);

            if(chainableArray[hash] == null)
                chainableArray[hash] = new List<(TKey key, TValue value)>();

            if(chainableArray[hash].Count <= 0)
                elements++;

            chainableArray[hash].InsertItem((key, value));

            if(hashValues.Count <= count)
                hashValues.InsertItem((key, value));

            count++;

            CalculateLoadFactor();

        }

        public override TValue LookUp(TKey key)
        {
            int hash = Hash(key);

            for(int i = 0; i < chainableArray[hash].Count; i++)
            {

                (TKey key, TValue value) bucket = chainableArray[hash].GetItem(i);

                if(bucket.key.Equals(key))
                    return bucket.value;

            }

            return array[hash];
        }

        protected override void ReHash()
        {


            double increasedLength = (double)length * increaseSizeFactor;

            int newLength = Int32.Parse(Math.Round(increasedLength).ToString());

            chainableArray = new List<(TKey key, TValue value)>[newLength];
            length = newLength;

            CalculateLoadFactor();

            count = 0;
            elements = 0;

            for(int i = 0; i < hashValues.Count; i++)
            {

                (TKey key, TValue value) hash = hashValues.GetItem(i);

                Add(hash.key, hash.value);
            }

        }

    }
}
