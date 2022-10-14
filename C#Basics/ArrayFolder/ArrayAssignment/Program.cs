using System;
namespace ArrayAssignment
{
    class Program{
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter the size of array");
            int size=int.Parse(Console.ReadLine());
            string[] names=new string[size];
            //getting names
            System.Console.WriteLine("Enter names");
            for(int i=0;i<names.Length;i++)
            {
                names[i]=Console.ReadLine();
                
            }
            
            //printing names
            System.Console.WriteLine("Printing by for loop");
            for(int i=0;i<names.Length;i++)
            {
                System.Console.WriteLine(names[i]);
            }
            System.Console.WriteLine(" ");

            //search names in for loop
            System.Console.WriteLine("Enter a name to search");
            string user_name=Console.ReadLine();
            int count=0,step=0;
            for(int i=0;i<names.Length;i++)
            {
                if(names[i]==user_name)
                {
                    System.Console.WriteLine("The name is present in the array and it's index is {0}",i);
                    count++;
                }
               
            }
             if(count==0)
                {
                    System.Console.WriteLine("The name is not present in the array");
                }
            System.Console.WriteLine(" ");

            //search names in foreach loop
            foreach(string i in names)
            {
                if(i==user_name)
                {
                    System.Console.WriteLine("The name was presented in the array");
                    step++;
                }
               
            }
             if(step==0){
                    System.Console.WriteLine("The name was not presented in the array");
                }
            
        }
    }
}