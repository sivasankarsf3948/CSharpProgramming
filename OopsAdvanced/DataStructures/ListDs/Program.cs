using System;
namespace ListDs
{
    class Program 
    {
        public static void Main(string[] args)
        {
            List<int> data=new List<int>();
            data.Add(1);
            data.Add(2);
            data.Add(6);
            data.Add(9);
           
            data.Insert(0,5);
            
             data.Remove(1);
              data.RemoveAt(3);
            for(int i=0;i<data.Count;i++)
            {
                System.Console.WriteLine(data[i]);
            }

             /*    foreach(int value in data)
            {
                System.Console.WriteLine(value);
            }*/
            
          
           
             
           
           
           // data.Display();
           // data.Remove(13);
       

           // for(int i=0;i<7;i++){data.AddElement(1);}
            //foreach(int i in )
            
        }
    }
}