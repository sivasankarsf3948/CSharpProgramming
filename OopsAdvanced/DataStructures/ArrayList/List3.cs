using System;

namespace ArrayList
{
    public partial class List<Object>
    {
        public void Remove(Object data)
        {
            
            Object[] temp=new Object[_capacity];
            for(int i=0;i<_count;i++)
            {
                
                if(!data.Equals(Array[i]))
                {
                    temp[i]=Array[i];
                }
                if(data.Equals(Array[i]))
                {
                    for(int j=i;j<_count;j++)
                    {
                        temp[j]=Array[j+1];
                    }
                    
                    break;
                }
            }
            _count--;
            Array=temp;
           
        }
    }
}