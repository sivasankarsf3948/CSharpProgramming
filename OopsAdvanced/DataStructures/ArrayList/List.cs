using System;


namespace ArrayList
{
    public partial class List<Object>//public class ArrrayList//name change to arraylist
    {
        private Object[] Array {get; set;}//public dynamic [] Array
        private int _count;
        private int _capacity;
        public int Count { get{return _count;}  }
        public int Capacity { get{return _capacity;} }
        public  Object this [int i] { get {return Array[i];} set{Array[i]=value;} }//public dynamic this [int i]

        public List()//all rt to methods public dynamic this [int i ] not in constructor
        {
            _capacity=4;
            _count=0;
            Array =new Object[_capacity];
        }

         public List(int size)
        {
            _capacity=size;
            _count=0;
            Array =new Object[_capacity];
        }
    }
}