using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    public class HeadHashTable<TKey, TValue>: HashTable<TKey, TValue>
    {

        private BucketEntry<TKey, TValue>[] bucketArray;

        public HeadHashTable()
        {
            bucketArray = new BucketEntry<TKey, TValue>[length];
        }

        public override void Add(TKey key, TValue value)
        {

            if(loadFactorThresholdReached)
            {
                
                CalculateLoadFactor();

                ReHash();
            }

            int hash = Hash(key);

            if(bucketArray[hash] == null)
                bucketArray[hash] = new BucketEntry<TKey, TValue>();

            if(bucketArray[hash].Head == null || bucketArray[hash].Head.Equals(0))
                elements++;

            bucketArray[hash].Add(key, value);

            if(hashValues.Count <= count)
                hashValues.InsertItem((key, value));

            count++;

            CalculateLoadFactor();

        }

        public override TValue LookUp(TKey key)
        {
            int hash = Hash(key);

            if(bucketArray[hash].Chain.Count < 1)
                return bucketArray[hash].Head;

            for(int i = 0; i < bucketArray[hash].Chain.Count; i++)
            {

                (TKey key, TValue value) bucket = bucketArray[hash].Chain.GetItem(i);

                if(bucket.key.Equals(key))
                    return bucket.value;

            }

            return bucketArray[hash].Head;
        }

        protected override void ReHash()
        {

            double increasedLength = (double)length * increaseSizeFactor;

            int newLength = Int32.Parse(Math.Round(increasedLength).ToString());

            bucketArray = new BucketEntry<TKey, TValue>[newLength];
            count = 0;
            elements = 0;

            for(int i = 0; i < hashValues.Count; i++)
            {

                (TKey key, TValue value) hash = hashValues.GetItem(i);

                Add(hash.key, hash.value);
            }

            length = newLength;
        }
    }
}
