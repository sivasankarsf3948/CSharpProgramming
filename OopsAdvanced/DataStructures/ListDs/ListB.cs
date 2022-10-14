using System;


namespace ListDs
{
    public  partial class List<Type>
    {
          public void RemoveAt(int index)
            {
               
             Type[] temp=new Type[_count-1];
             for(int i=0;i<_count;i++)
             {
                if(i<index)
                {
                    temp[i]=Array[i];
                }
                if(i==index)
                {
                    continue;
                }
                if(i>index)
                {
                    temp[--i]=Array[i]; 
                }
                
               
             }
             _count--;
             Array=temp;
        }

        public void Display()
        {
            foreach(Type i in Array)
            {
                System.Console.WriteLine(i);
            }
          
        }

        //Remove
        public void Remove(Type value)
        {
             Type[]  temp=new Type[_count];
            for(int i=0;i<_count;i++)
            {
                if(!value.Equals(Array[i]))
                {
                    temp[i]=Array[i];
                }
               
                if(value.Equals(Array[i]))
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