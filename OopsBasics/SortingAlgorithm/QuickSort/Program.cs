using System;
namespace QuickSort
{
    class  Program{
        public static void Main(string[] args)
        {
            int[] array={18,19,1,5,7,3,20};
            //passing to method for sorting 
            QuickSort(array,0,array.Length-1);
            //printing sorted array
            foreach(int i in array)
            {
                System.Console.Write(i+" ");
            }
            //Quick sort method
           static void QuickSort(int[] array, int low , int high)
            {
                if(low>=high)
                return ;
                int start=low;
                int end=high;
                int middle=(start+end)/2;
                int pivot =array[middle];

                while(start<=end)
                {
                    while(array[start]<pivot)
                    {
                        start++;
                    }
                    while(array[end]>pivot)
                    {
                        end--;
                    }
                    //swapping
                    if(start<=end)
                    {
                        int temp=array[start];
                        array[start]=array[end];
                        array[end]=temp;
                        start++;
                        end--;
                    }
                    

                }
                 QuickSort(array,low,end);
                 QuickSort(array,start,high);
            }
           
        }
    }
}
