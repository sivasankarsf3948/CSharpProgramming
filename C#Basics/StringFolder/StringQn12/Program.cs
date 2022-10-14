using System;
using System.Linq;
namespace StringQn12{
    class Program{
     public static void Main(string[] args)
     {
        //System.Console.WriteLine("Enter a string ");
        string str="3 4 8 9 0 2 1";
        var data=str.Split(' ');
        int[] array=new int[data.Length];
        
         //array=str.Split(' ').Select(int.Parse).ToArray();
       int j=0;
       
        
       foreach(string i in data)
       {
         array[j]=int.Parse(i);
        //System.Console.WriteLine(i);
        j++;
       }
      /* foreach(int i in n)
       {
        System.Console.WriteLine();
       }*/
        System.Console.WriteLine("Maximum number is " +array.Max());
        System.Console.WriteLine("Minimum number is " +array.Min());
     }
    }
}
