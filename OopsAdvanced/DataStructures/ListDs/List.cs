using System;


namespace ListDs
{
    public partial class List<Type>
    {
        //generic 
        private Type[] Array{get;set;}
        public int Count { get{return _count;}  }
        public int Capacity { get{return _capacity;}  }
        private int _count;
        private int _capacity;

        public Type this [int i]{get{return Array[i];} set{Array[i]=value;}}

        
        //default for without size default 4 increase double need more calci below
        public List()
        {
            _count=0;
            _capacity=4;
            Array =new Type[_capacity];
        }
        
        //if user give static size
       public List(int size)
        {
            _count=0;
            _capacity=size;
            Array =new Type[_capacity];
        } 
        //method to append element in a list
        public void Add(Type data)
        {
            if(_count==_capacity)
                GrowSize();
            Array[_count]=data;
            _count++;
        }

        public void GrowSize()
        {
            _capacity=_capacity*2;
            Type[] Array1=new Type[_capacity] ;
            for(int i=0;i<_count;i++)
            {
                Array1[i]=Array[i];
            }
            Array=Array1;
           
        }



    }
}