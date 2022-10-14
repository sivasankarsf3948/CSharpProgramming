using System;


namespace MovieTicketBooking
{
    public partial class List<Type> 
    {
        private  static int _count;
        private static int _capacity;
        
        private Type[] Array { get; set; } 
        public int Count { get{return _count;}  }
        public int Capacity { get{return _capacity;}  }
        public Type this [int i]{ get {return Array[i];} set{Array[i]=value;} }
      
       public List()
       {
        _count=0;
        _capacity=4;
        Array=new Type[_capacity];

       }
       public List(int size)
       {
        _count=0;
        _capacity=size;
        Array=new Type[_capacity];
       }


       //add method
       public void Add(Type data)
       {
         if(_capacity==_count)
         {
            GrowSize();
         }
         Array[_count]=data;
         _count++;
       }

       public void GrowSize()
       {
        _capacity*=2;
        Type[] temp=new Type[_capacity];
        for(int i=0;i<_count;i++)
        {
            temp[i]=Array[i];
        }
        Array=temp;
       }

    }
}