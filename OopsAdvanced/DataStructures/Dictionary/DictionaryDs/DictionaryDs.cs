using System;


namespace DictionaryDs
{
    public partial class KeyValue<TKey,TValue>
    {
        public int Count { get{return _count;} }
        //public int Capacity { get{return _capacity;}  }
        public int Size { get{return _capacity;}  }
        private int _count=0;
        private int _capacity=0;
        public KeyValue<TKey,TValue> [] Array{get;set;}

        //methods 
        public bool ContainsKey(TKey key)
        {
          
            bool cmp =LinearSearch(key,out int position);
       
                return cmp;
       
           
        }
        //ElementAt
         public KeyValue<TKey,TValue> ElementAt(int index)
         {
            KeyValue<TKey,TValue> output=null;
            if(index>-1 && index<Count)
            {
                output =Array[index];
            }
            else
            {
                System.Console.WriteLine("Tried to access Out of Bond");
            }
            return output;
         }

        //Remove
        public void Remove(TKey key)
        {
            KeyValue<TKey,TValue>[] temp=new KeyValue<TKey,TValue>[Count];
            bool cmp =LinearSearch(key,out int position);
            
            if(cmp)
            {
               for(int i=0;i<Count-1;i++)
               {
                if(i<position)
                {
                    temp[i]=Array[i];
                }
                else if(i>=position)
                {
                    temp[i]=Array[i+1];
                }
               }
               Array=temp;
               _count--;
            }
            else
            {
                System.Console.WriteLine("Invalid key");
            }
            
        }
        //contains value
        public bool ContainsValue(TValue value)
        {
            foreach(KeyValue<TKey,TValue> element in Array)
            {
                if(element.Value.Equals(value))
                {
                    return true;
                }
            }
            return false;
        }

         public void Add(TKey key,TValue value)
        {
        if(_count==_capacity)
        {
            Expand();
        }
       // int position=LinearSearch(key)
       bool temp=LinearSearch(key,out int index);
       if(temp==true)//already present key cannot  another use  because of unique key needed
       {
        System.Console.WriteLine("Duplicate key");
       }
       if(temp==false)
       {
         KeyValue <TKey,TValue>  entry=new KeyValue<TKey,TValue>() ;
         entry.Key=key;
         entry.Value=value;
         Array[_count]=entry;
         _count++;
       }
        

        }

        public void Expand()
        {
            _capacity=_capacity*2;
            KeyValue<TKey,TValue> [] temp=new  KeyValue<TKey,TValue>[_capacity];
            for(int i=0;i<Count;i++)
            {
                temp[i]=Array[i];
            }
            Array=temp;
        }

        public void Display()
        {
            foreach(KeyValue<TKey,TValue> element in Array)
            {
                if(element!=null)
                {
                    System.Console.WriteLine("Key:"+element.Key+"\t"+"Value:"+element.Value);
                }
            }
        }

        //Key search method
        public bool LinearSearch(TKey key,out int index)
        {
            index=0;
            for(int i=0;i<_count;i++)
            {
                if(key.Equals(Array[i].Key))
                {
                    index=i;
                    return true;
                }

            }
            return false;
        }

        //indexers
        public TValue this [TKey key]
        {
            get//here change that object property get see, set update
            {
                TValue output=default(TValue);//defitely return 1 value default return specialized data type
                int index=0;
                bool temp=LinearSearch(key,out index);
                if(temp)
                {
                    output=Array[index].Value;
                }
                else{System.Console.WriteLine("Invlid key");}
                return output;
            }
            set
            {
                int position=0;
                bool temp=LinearSearch(key,out position);
                if(temp)
                {
                    Array[position].Value=value;

                }
                else
                {
                    System.Console.WriteLine("Invalid key");
                }
            }
        }
   





    }
}