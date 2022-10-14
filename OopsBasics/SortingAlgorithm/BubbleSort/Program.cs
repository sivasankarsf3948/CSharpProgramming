using System;
namespace BubbleSort
{
    class Program
    {
        public static void Main(string[] args)
        {
            int temp,size;
            int[] array={18,19,15,7,3,20,1};
            size=array.Length;
            for(int i=0;i<array.Length;i++)
            {
                for(int j=0;j<size-1;j++)
                {
                    if(array[j]>array[j+1])
                    {
                        temp=array[j];
                        array[j]=array[j+1];
                        array[j+1]=temp;
                    }
                }
                size--;
            }


            System.Console.WriteLine("The sorted array is ");
               //printing array
            foreach(int element in array)
            {
                System.Console.Write(element+"\t");
            }
        }

     
    }
}
