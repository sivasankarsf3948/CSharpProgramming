using System;
namespace ArrayQn5
{
    class Program{
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter the size of array");
            int size =int.Parse(Console.ReadLine());
            
            int[] numbers=new int[size];
            int[] even=new int[size];
            int[] odd=new int[size];

            //getting user input

            System.Console.WriteLine("Enter array elements");
            for(int i=0;i<numbers.Length;i++)
            {
                numbers[i]=int.Parse(Console.ReadLine());
            }
            int j=0,k=0;
            for(int i=0;i<numbers.Length;i++)
            {
                if(numbers[i]%2==0)
                {
                    even[j]=numbers[i];
                    j++;
                }
                else{
                    odd[k]=numbers[i];
                    k++;
                }
            }
            //printing even elements
            System.Console.WriteLine("The even numbers are");
            foreach(int i in even)
            {
                if(i!=0)
                System.Console.WriteLine(i);
            }
            //printing odd numbers
             System.Console.WriteLine("The odd numbers are");
            foreach(int i in odd)
            {
                if(i!=0)
                System.Console.WriteLine(i);
            }
            
            
           
            
        }
    }
}

