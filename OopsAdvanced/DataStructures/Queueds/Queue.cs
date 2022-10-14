using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Queueds
{
    public partial class Queue<Type>
    {
        private Type[] Array{get;set;}
        public int Count { get{return _count;}  }
        private int _head;
        private int _count;
      //  private int _size;
        private int _capacity;
        private int _tail;


        public Queue()
        {
            _count=0;
            _head=0;
            _tail=0;
            _capacity=4;
            Array=new Type[_capacity];

        }
        public Queue(int size)
        {
            _count=0;
            _head=0;
            _tail=0;
            _capacity=size;
            Array=new Type[_capacity];
        }

        //Enqueue(add method)
        public void Enqueue(Type data)
        {
          
            if(_tail==_capacity)
                GrowSize();
            Array[_tail]=data;
            _count++;
            _tail++;
        
        }

        //Grow size
         public void GrowSize()
        {
             _capacity=_capacity*2;
            Type[] temp=new Type[_capacity] ;
            for(int i=0;i<_tail;i++)
            {
                temp[i]=Array[i];
            }
            Array=temp;
        }

        //Dequeue
        public Type Dequeue()
        {
            Type value=default(Type);
            if(_head>_tail)
            {
                System.Console.WriteLine("Empty  queue");
            }
            else
            {
                value=Array[_head];
                _head++;
                _count--;
            }
            return value;
        }

        //peek method 
        public Type Peek()
        {
            Type value=default(Type);
            if(_head>_tail)
            {
                System.Console.WriteLine("Empty  queue");
            }
            else
            {
                value=Array[_head];
             
            }
            return value;
        }
        //contains method 
        public bool Contains(Type data)
        {
            Boolean value=false;
            for(int i=0;i<_count;i++)
            {
                if(data.Equals(Array[i]))
                {
                    value=true;
                }
            }
            return value;
        }
    }
}