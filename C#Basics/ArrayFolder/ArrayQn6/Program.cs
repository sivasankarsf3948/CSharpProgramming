using System;
namespace ArrayQn6
{
    class Program{
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter the size of array");
            int size =int.Parse(Console.ReadLine());
            
            int[] numbers=new int[size];

            //getting user input

            System.Console.WriteLine("Enter array elements");
            for(int i=0;i<numbers.Length;i++)
            {
                numbers[i]=int.Parse(Console.ReadLine());
            }
           
            //sorting of array elements

            int temp=0;
            for(int i=0;i<numbers.Length;i++)
            {
                for(int j=i+1;j<numbers.Length;j++)
                {
                    if(numbers[i]>numbers[j])
                    {
                      temp=numbers[i];
                      numbers[i]=numbers[j];
                      numbers[j]=temp;
                    }
                }
            }
            System.Console.WriteLine("Elements of array in ascending order");
            foreach(int i in numbers)
            {
                System.Console.WriteLine(i);
            }
            
        }
    }
}

