using System;


namespace ListDs
{
    public partial class List<Type>
    {
        //insert method
        public void Insert(int index,Type data)
        {
            if(index<_count)
            {
            // _capacity+=2;
                Type[] temp=new Type[_capacity+2];
                
            //  int j=0;
                for(int i=0;i<_count;i++)
                {

                   if(i<index)
                    {
                        temp[i]=Array[i];
                    }
                    if(i==index)
                    {
                        temp[i]=data;
                        _count++;
                    }
                    else if(index<i)//if
                    {
                        temp[i]=Array[i-1];
                    }
                    
                }
                Array=temp;
            }
            else
            {
                System.Console.WriteLine("invalid index");
            }
        }

      
}
    }

    //Remove 
    