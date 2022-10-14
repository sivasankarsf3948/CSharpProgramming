using System;
namespace MediumQn8{
    class Program{
        public static void Main(string[] args)
        {
           System.Console.WriteLine("Enter a string");
           string str=Console.ReadLine();
           string data="";
           for(int i=0;i<str.Length;i++)
           {
               while(Char.IsDigit(str[i]))
               {
                   data=data+str[i];
                   break;
               }
           }
           
           int number=int.Parse(data);
           System.Console.WriteLine("The number is "+number);
           if(number%2==0)
           {
            System.Console.WriteLine(number+" is an even integer");
           }
           else{
            System.Console.WriteLine(number+" is an odd integer");
           }
          // System.Console.WriteLine("hi");
           
        }
    }
}
