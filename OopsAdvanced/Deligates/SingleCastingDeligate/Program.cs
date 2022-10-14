using System;
namespace SingleCastingDeligate
{
    public delegate int Calculator(int n);//call add method have int return type & 1 arg 
    class Program 
    {
        static int value=10;
        public static int AddNum(int number){value+=number;return value;}
        public static int MultNum(int number){value*=number;return value;}
        public static int GetNum(){return value;}
        public static void Main(string[] args)
        {
            //create deligate objects
            Calculator nc1=new Calculator(AddNum);//deligate parameter is mtd
            Calculator nc2=new Calculator(MultNum);
            //calling method using deligates
            nc1(25);
            System.Console.WriteLine("Value of Num: {0}",GetNum());
            nc2(5);
            System.Console.WriteLine("Value of Num: {0}",GetNum());
            Console.ReadKey();
        }
    }
}
