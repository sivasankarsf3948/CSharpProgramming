using System;


namespace DictionaryDs
{
    public partial class KeyValue<TKey,TValue>
    {
        public TKey Key{ get; set; }
        public TValue Value { get; set; }
    }
}