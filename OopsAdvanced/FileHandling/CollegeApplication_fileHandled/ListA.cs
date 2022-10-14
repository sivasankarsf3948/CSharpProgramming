using System;


namespace CollegeApplication
{
    public partial class List<Type>
    {
        //insert method
        public void Insert(int index,Type data)
        {
            _capacity++;
            Type[] temp=new Type[_capacity];
          //  int j=0;
            for(int i=0;i<_capacity;i++)
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
                if(i>index)
                {
                    temp[i]=Array[--i];
                }
                
            }
            Array=temp;
        }
        public void AddRange(List<Type> list)
        {
            int j=0;
            if(_capacity<_count+list.Count)
            {
                _capacity=_capacity+list.Count;
                Type[] temp=new Type[_count];
                for(int i=0;i<_count;i++)
                {
                    temp[i]=Array[i];
                }
                Array=temp;
            }
            for(int i=_count;i<list.Count;i++)
            {
                Array[i]=list[j];
            }
            _count+=list.Count;
        }

        /*public void AddRange(List<Type> data)
        {
            foreach(Type value in data)
            {
                this.Add(value);
            }
        }*/


      
}
    }

    //Remove 
    