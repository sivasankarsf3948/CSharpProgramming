using System;


namespace CollegeAdmission
{
    public partial class KeyValue<TKey,TValue>
    {
        public TKey Key{ get; set; }
        public TValue Value { get; set; }
    }
}