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

        public void Add(TKey key, TValue value)
        {

            if(Head == null || Head.Equals(0))
            {
                Head = value;
            }
            else
            {
                Chain.InsertItem((key, value));
            }

        }

    }
}
