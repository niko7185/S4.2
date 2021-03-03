using System;
using System.Text;

namespace DataStructures
{
    public class BucketEntry<TKey, TValue> 
    {

        public TValue Head { get; set; }

        public List<(TKey key, TValue value)> Chain { get; set; }


        public BucketEntry()
        {
            Chain = new List<(TKey key, TValue value)>();
        }

        public BucketEntry(TValue value)
        {

        }

        public void Add(TKey key, TValue value)
        {

            if(Chain == null)
                return;

            if(Chain.Count <= 0)
            {
                Head = value;
            }

            Chain.InsertItem((key, value));

        }

        public void Insert()
        {

        }

    }
}
