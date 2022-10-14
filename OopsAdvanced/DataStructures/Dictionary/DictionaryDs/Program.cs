using System;
namespace DictionaryDs
{
    class Program 
    {
        public static void Main(string[] args)
        {
         KeyValue<int,string> keys=new KeyValue<int,string>();

         keys.Add(1,"siva");
         keys.Add(2,"sankar");
         keys.Display();
         

        }
    }
}