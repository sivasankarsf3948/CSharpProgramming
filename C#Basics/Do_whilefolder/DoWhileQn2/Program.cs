using System;
namespace DoWhileQn2
{
    class Program{
        public static void Main(string[] args)
        {
            int sum=0,number;
            do{
            System.Console.WriteLine("Enter a number");
            number=int.Parse(Console.ReadLine());
            if(number>0){
             sum=sum+number;
            }

            }while(number>=0);
            System.Console.WriteLine("The sum is "+sum);
            
        }
    }
}
