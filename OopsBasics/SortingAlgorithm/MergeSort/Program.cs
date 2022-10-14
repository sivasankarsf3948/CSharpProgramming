using System;
namespace MergeSort
{
    class Program 
    {
        public static void Main(string[] args)
        {

            int[] array={5,8,2,9,3,1};
            int count=array.Length;
            MergeSort(array,0,count-1);
            foreach(int i in array)
            {
                System.Console.WriteLine(i);
            }

        }



        public static void MergeSort(int[] array,int left,int right)
        {
            int middle;
            if(right>left)
            {
                middle=(right+left)/2;
                MergeSort(array,left,middle);
                MergeSort(array,middle+1,right);
                Sort(array,left,middle+1,right);

            }
        }

        public static void Sort(int[] number,int left,int middle,int right)
        {
            int[] temp=new int[100];
            int i,limit,flag,position;
            limit=middle-1;
            position=left;
            flag=right-left+1;

            while(left<=limit && middle<= right)
            {
                if(number[left]<=number[middle])
                {
                    temp[position++]=number[left++];
                }
                else{
                    temp[position++]=number[middle++];
                }
            }
            while(left<=limit)
            {
                temp[position++]=number[left++];
            }
            while(middle<=right)
            {
                temp[position++]=number[middle++];
            }
            for ( i=0;i<flag;i++)
            {
                number[right]=temp[right];
                right--;
            }

        }
    }

}