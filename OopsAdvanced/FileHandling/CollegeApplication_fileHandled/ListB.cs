using System;


namespace CollegeApplication
{
    public  partial class List<Type>
    {
          public void RemoveAt(int index)
            {
                System.Console.WriteLine("Hi");
             Type[] temp=new Type[_count-1];
             for(int i=0;i<_capacity;i++)
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
                Array=temp;
               
             }
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
             Type[]  temp=new Type[_count-1];
            for(int i=0;i<_count;i++)
            {
               
                if(value.Equals(Array[i]))
                {
                    for(int j=i+1;j<Count;j++)
                    {
                        temp[i]=Array[j];
                        i++;
                    }
                    break;
                }
               
                
            }
            Array=temp;

        }

    }
}