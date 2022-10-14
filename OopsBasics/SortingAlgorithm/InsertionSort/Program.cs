using System;
namespace InsertionSort
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] array={18,19,1,5,7,3,20};
            int fix,temp;
            //sort by insertion
            for(int i=1;i<array.Length;i++)
            {
                fix=array[i];
                for(int j=i-1;j>=0;j--)
                {
                    if(fix<array[j])
                    {
                        temp=array[j];
                        array[j]=array[j+1];
                        array[j+1]=temp;
                    }
                }

            }

            //printing array
            foreach(int element in array)
            {
                System.Console.Write(element+"\t");
            }
        }
    }
}
