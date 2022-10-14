using System;
namespace ArrayList
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<int> myList=new List<int>();
            myList.Add(1);
            myList.Add('c');
            myList.Add(6);
            myList.Add(9);
            System.Console.WriteLine(myList.Contains(0));
            System.Console.WriteLine(myList.IndexOf(6));
            //  siva.Insert(0,5);
            //  siva.Remove(1);
            // siva.RemoveAt( 2);
            // siva.Contains(6);

            for(int i=0; i<myList.Count;i++)
            {
                System.Console.WriteLine(myList[i]);
            }

        }
    }
}
