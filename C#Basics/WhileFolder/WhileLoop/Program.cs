using System;
namespace WhileLoop
{
    class Program{
        public static void Main(string[] args)
        {
            //printing  even number
            int i=0;
            while(i<=25)
            {
                if(i%2==0){
                 System.Console.WriteLine(i);
                }
              i++;
            }
            //valid input
           
            
            
                 System.Console.WriteLine("Enter a number");
                 int b;
                 bool number=int.TryParse(Console.ReadLine(),out b);
                 
                while(number==false)
                {
                   System.Console.WriteLine("Your input is invalid Enter a vild input");
                   number=int.TryParse(Console.ReadLine(),out b);
                
                }
                System.Console.WriteLine("Your input is correct");
                System.Console.WriteLine("Your number is{0}",b);

               
                
            
        }
    }
}