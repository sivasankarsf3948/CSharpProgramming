using System;


namespace VacccineApplication
{
    public partial class List<Type>
    {
        public Type[] Array { get; set; }
        public int Count { get{return _count;}  }
        public int Capacity { get{return _capacity;}  }
        private static int _count=0;
        private static int _capacity=0;
        public  Type this [int i]  {get{return Array[i];}set{Array[i]=value;}}/////

        public List()
        {
            _capacity=4;
            _count=0;
            Array=new Type[_capacity];
        }

        public List(int size)
        {
            _capacity=size;
            _count=0;
            Array=new Type[_capacity];
        }

        public void Add(Type data)
        {
            if(_capacity==_count)
                GrowSize();
            Array[_count]=data;
            _count++;

        }

        public void GrowSize()
        {
            _capacity=_capacity*2;
            Type[] temp=new Type[_capacity];
            for(int i=0;i<_count;i++)
            {
                temp[i]=Array[i];
            }
             Array=temp;
        }
       
    }
}