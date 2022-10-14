using System;
namespace WhileloopQuestion6
{
    class Program{
        public static void Main(string[] args)
        {
            int i=1;
            
            while(i<=100)
            {
                System.Console.WriteLine("The number is  :"+i);
                if(i%2==0)
                {
                    System.Console.WriteLine("The number is even");
                }
                else{
                    System.Console.WriteLine("The number is odd");
                }
                int j=2,count=0;
                while(j<i)
                {
                    if(i%j==0)
                    {
                        
                        count++;
                    }
                    
                 j++;
                }
                if(count==0 && i!=1)
                {
                    System.Console.WriteLine("The number is prime");
                }
                else if(i==1)
                {
                   System.Console.WriteLine("The numer 1 is neither prime nor composite");
                }
                else{
                    System.Console.WriteLine("The number is not prime");
                }
                i++;
            }
        }
    }
}
