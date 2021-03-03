using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    public class TreeHashTable<TKey, TValue>: HashTable<TKey, TValue> where TKey : IComparable<TKey>
    {

        private BucketTreeEntry<TKey, TValue>[] bucketArray;

        public TreeHashTable()
        {
            bucketArray = new BucketTreeEntry<TKey, TValue>[length];
        }

        public override void Add(TKey key, TValue value)
        {

            if(loadFactorThresholdReached)
                ReHash();

            int hash = Hash(key);

            if(bucketArray[hash] == null)
            {

                bucketArray[hash] = new BucketTreeEntry<TKey, TValue>(key, value);
                elements++;
            }
            else
            {

                bucketArray[hash].Add(key, value);
            }


            if(hashValues.Count <= count)
                hashValues.InsertItem((key, value));

            count++;

            CalculateLoadFactor();

        }

        public override TValue LookUp(TKey key)
        {
            int hash = Hash(key);

            if(bucketArray[hash].Tree.Root.isEmpty)
                return bucketArray[hash].Head;

            return bucketArray[hash].Find(key);
        }

        protected override void ReHash()
        {

            double increasedLength = (double)length * increaseSizeFactor;

            int newLength = Int32.Parse(Math.Round(increasedLength).ToString());

            bucketArray = new BucketTreeEntry<TKey, TValue>[newLength];
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
