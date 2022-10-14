using System;


namespace ArrayList
{
    public partial class List<Object>
    {
       public void RemoveAt(int index) 
       {
        Object[] temp=new Object[_count-1];
        for(int i=0;i<_count-1;i++)
        {
            if(i<index)
            {
                temp[i]=Array[i];
            }
           /* if(i==index)
            {
                continue;
            }*/
            if(i>=index)
            {
                temp[i]=Array[i+1]; 
            }
        }
        Array=temp;
        _count--;
       }


       //index of
       public int IndexOf(Object value)
       {
        int i;
        
        for( i=0;i<_count;i++)
        {
            if(Array[i].Equals(value))
            {
             
                
                break;
            }
        }
         return i;
       }

       //contains
       public bool  Contains(Object value)
       {
        for(int i=0;i<_count;i++)
        {
            
            if(Array[i].Equals(value))
            {
                return true;
            }
        }
        return false;
       }
    }
}