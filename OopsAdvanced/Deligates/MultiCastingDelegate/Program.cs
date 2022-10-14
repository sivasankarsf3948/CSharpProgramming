using System;
namespace MultiCastingDeligate
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
            //Multicasting 
            //create deligate objects
            Calculator nc;//
            Calculator nc1=new Calculator(AddNum);//deligate parameter is mtd
            Calculator nc2=new Calculator(MultNum);
            nc=nc1;
            nc+=nc2;
            //calling method using deligates
           nc(5);
            System.Console.WriteLine("Value of Num: {0}",GetNum());
            Console.ReadKey();
        }
    }
}

