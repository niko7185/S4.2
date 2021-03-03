using System;
using System.Text;

namespace DataStructures
{
    public class HashTable<TKey, TValue>: LinearDataStructure<TValue>
    {

        protected readonly double loadFactor = 0.8;
        protected readonly double increaseSizeFactor = 1.5;

        protected double actualLoadFactor;
        protected int elements;
        protected List<(TKey key, TValue value)> hashValues;

        protected bool loadFactorThresholdReached => loadFactor <= actualLoadFactor;

        public HashTable() : base(1000)
        {
            hashValues = new List<(TKey key, TValue value)>();
        }

        public virtual void Add(TKey key, TValue value)
        {

            if(loadFactorThresholdReached)
            {
                double increasedLength = (double)length * increaseSizeFactor;

                int newLength = Int32.Parse(Math.Round(increasedLength).ToString());

                ResizeTo(newLength);

                CalculateLoadFactor();

                ReHash();
            }

            int hash = Hash(key);

            if(array[hash] == null || array[hash].Equals(0))
                elements++;

            array[hash] = value;

            if(hashValues.Count <= count)
                hashValues.InsertItem((key, value));

            count++;

            CalculateLoadFactor();

        }

        public virtual TValue LookUp(TKey key)
        {
            int hash = Hash(key);

            return array[hash];
        }

        protected void CalculateLoadFactor()
        {
            actualLoadFactor = Math.Round((double)elements / (double)length, 2);
        }

        protected int Hash(TKey key)
        {

            int hashCode = key.GetHashCode();

            var mask = hashCode >> 31;

            hashCode = hashCode ^ mask;

            hashCode -= mask;

            hashCode %= length;

            return hashCode;

        }

        protected virtual void ReHash()
        {

            array = new TValue[length];
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
