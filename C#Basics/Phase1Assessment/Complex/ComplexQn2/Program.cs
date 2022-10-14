using System;
namespace ComplexQn2{
    class Program{
        public static void Main(string[] args)
        {
            
         //System.Console.WriteLine(Fact(3));
         System.Console.WriteLine("Enter the serie end limit");
         int limit=int.Parse(Console.ReadLine());
         
        double answer=0,sum=1;
         for(int i=1;i<=limit;i++)
         {
        //  denominator=Fact(i)+Power(i+1);
          answer=Math.Pow(2,i)/Fact(i);
          sum+=answer;
        

         }
         System.Console.WriteLine("Output Is "+sum);

           //Fact method
            int Fact(int value)
            {
                int fact=1;
                for(int i=value;i>1;i--)
                {
                    fact=fact*i; 
                }
                return fact;
            }
            //Power method
           
            

        }
    }
}
