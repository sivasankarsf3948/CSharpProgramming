using System;

namespace DictionaryDs
{
    public partial class KeyValue<TKey,TValue>
    {
        public KeyValue(int size)
        {
           if(size==0)
           {
            _capacity=size;_count=0;
            Array = new KeyValue<TKey,TValue>[_capacity];
           }
           else if(size>0)//dbt
           {
            _capacity=_capacity*2;
             Array = new KeyValue<TKey,TValue>[_capacity];
             _count=0;
           }

        }

        public KeyValue()
        {
            _capacity=4;
            _count=0;
             Array = new KeyValue<TKey,TValue>[_capacity];
        }
    }
   
}