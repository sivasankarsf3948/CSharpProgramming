using System;
using System.Collections;

namespace CollegeAdmission
{
    public partial class KeyValue<TKey,TValue>:IEnumerable,IEnumerator
    {
        private static int i;
        public IEnumerator GetEnumerator()
        {
            i=-1;
            return (IEnumerator)this;
        }
        public bool MoveNext()
        {
            if(i<Count-1)
            {
                return true;
            }
            Reset();
            return false;
        }
        public void Reset()
        {
            i=-1;
        }
        public object Current{
        get{return Array[i];}}
    }
}