using System;
namespace SelectionSort
{
    class program
    {
        public static void Main(string[] args)
        {
            int[] array={18,19,1,5,7,3,20};
            int minValue,minIndex,temp;
            //sort by selection sort
            for(int i=0;i<array.Length;i++)
            {
                minValue=array[i];
                minIndex=i;
                for(int j=i+1;j<array.Length;j++)
                {
                    if(minValue>array[j])
                    {
                        minValue=array[j];
                        minIndex=j;
                    }
                }
                if(array[i]>minValue)
                {
                    temp=array[i];
                    array[i]=array[minIndex];
                    array[minIndex]=temp;
                }
            }

            //print sorted array
            foreach(int element in array)
            {
                System.Console.Write(element+"\t");
            }
            
        }
    }
}
