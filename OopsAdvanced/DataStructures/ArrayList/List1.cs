using System;

namespace ArrayList
{
    public partial class List<Object>
    {
        //add method 
        public void Add(Object data)
        {
            if(_capacity==_count)
            {
                GrowSize();
            }
            Array[_count]=data;
            _count++;
        }
        public void GrowSize()
        {
            _capacity=_capacity*2;
            Object[] temp=new Object[_capacity];
            for(int i=0;i<_count;i++)
            {
                temp[i]=Array[i];
            }
            Array=temp;
        }
    }
}