using System;
namespace ForQn9
{
    class Program{
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter a number");
            int number=int.Parse(Console.ReadLine());
            int temp=number,num=number;
            int remainder,count=0,rem;

            //finding the digits
            for(int i=0;number>0;i++)
            {
               remainder=number%10;
               count++;
               number=number/10; 
            }
            System.Console.WriteLine("The number of digits are "+count);

            //armstrong number
            int product=1,sum=0;
            for(int i=0;num>0;i++)
            {
               rem=num%10;
               //multiplying values based on digit count
               for(int j=0;j<count;j++)
               {
                 product=product*rem;
               }
               sum=sum+product;
               num=num/10; 
               product=1;
            }
            if(temp==sum)
            {
                System.Console.WriteLine("The number is Armstrong");
            }
            else{
                System.Console.WriteLine("The number is not an Armstrong");
            }
            
        }
    }
}
