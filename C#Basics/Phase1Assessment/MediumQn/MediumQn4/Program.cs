using System;
namespace MediumQn4
{
    class Program
    {
        public static void Main(string[] args)
        {
          
            int remainder,temp;
            int sum=0;
          
            for(int i=1;i<1000;i++)
            {
              temp=i;
              sum=0;
              remainder=0;
              while(temp>0)
              { remainder=temp%10;
               if(i<10)
               {
                 sum+=remainder;
                }
               else if(i<100)
               {
                 sum=sum+remainder*remainder;
               }
               else{
                 sum=sum+remainder*remainder*remainder;
               }
              temp=temp/10;
              }
              if(sum==i)
              System.Console.Write(i+" ");
            }
    
        }
       }   }

