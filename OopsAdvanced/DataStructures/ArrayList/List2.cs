using System;


namespace ArrayList
{
    public partial class List<Object>
    {
        public void Insert(int index,Object data)
        {
            if(_capacity==_count)
                GrowSize();
            Object[] temp=new Object[_capacity];
            _count++;
            for(int i=0; i<_count;i++)
            {
                if(i<index)
                {
                    temp[i]=Array[i];
                }
                else if(i==index)
                {
                    temp[i]=data;
                }
                else
                {
                    temp[i]=Array[i-1];
                }
            }
           // _count++;
            Array=temp;
        }
    }
}