
using System;
using System.Collections;

namespace CollegeApplication
{
    public  partial class List<Type>:IEnumerable,IEnumerator
    {
        private int i;
       public IEnumerator GetEnumerator()
       {
        i=-1;
        return (IEnumerator)this;
       }

       public bool MoveNext()
       {
        if(i< _count-1)
        {
            ++i;
            return true;
        }
        Reset();//reset posittion value if no element in list
        return false;
       }
       public void Reset()//reset i for next turn
       {
        i=-1;
       }
       public object Current//return current array position value
       {
        get {return Array[i];}
       }

    }
}