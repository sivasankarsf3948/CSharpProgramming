using System;
namespace Interface
{
    class Program 
    {
        public static void Main(string[] args)
        {
            Draw figure=new Draw();
            figure.GetData(1,2);
            figure.CalculateArea();
        }
    }
}
