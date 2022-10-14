using System;


namespace Stackds
{
    public partial class Stack <Type>
    {
        private Type[] Array{get;set;}
        public int Count { get{return _count;}  }
        private int _count;
        private int _capacity;

        //default

        public Stack()
        {
            _count=0;
            _capacity=4;
            Array=new Type[_capacity];
        }

       //user size give

        public Stack(int size)
        {
            _count=0;
            _capacity=size;
            Array=new Type[_capacity];
        }

        //Add method
        public void Push(Type data)
        {
            if(_count==_capacity)
                GrowSize();
            Array[_count]=data;
            _count++;
        }


        //GrowSize
        public void GrowSize()
        {
             _capacity=_capacity*2;
            Type[] temp=new Type[_capacity] ;
            for(int i=0;i<_count;i++)
            {
                temp[i]=Array[i];
            }
            Array=temp;
        }

        //pop
        public Type Pop()
        {
            Type value=default(Type) ;
            if(_count<0)
            {
                System.Console.WriteLine("Empty stack");
            }
            else if(_count>=0)
            {
                value=Array[_count];
                _count--;
            }
            return value;
        }
        //contains
        public bool Contains(Type data)
        {
            Boolean value=false;
            for(int i=0;i<_count;i++)
            {
                if(Array[i].Equals(data))
                {
                    value=true;
                }
            }
            return value;
        }
        //peak method to show
         public Type Peek()
        {
            Type value=default(Type) ;
            if(_count<0)
            {
                System.Console.WriteLine("Empty stack");
            }
            else if(_count>=0)
            {
                value=Array[_count];
                
            }
            return value;
        }
    }
}