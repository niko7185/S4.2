using System;
using System.Text;

namespace DataStructures
{
    public class BucketEntry<TKey, TValue> 
    {

        private List<(TKey key, TValue value)> chain;
        private TValue head;


        public virtual TValue Head => head;

        public List<(TKey key, TValue value)> Chain => chain;


        public BucketEntry()
        {
            chain = new List<(TKey key, TValue value)>();
        }

        public virtual void Add(TKey key, TValue value)
        {

            if(Head == null || Head.Equals(0))
            {
                head = value;
            }
            else
            {
                chain.InsertItem((key, value));
            }

        }

    }
}
