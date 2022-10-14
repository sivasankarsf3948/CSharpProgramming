using System;
namespace BasicQuestion10
{
    class Program
    {
        public static void Main(string[] args)
        {
            int value1=15;
            int value2=20;
            System.Console.Write("Is value 1 > value 2                   :");
            System.Console.WriteLine("a. {0}",value1>value2);
            System.Console.Write("Is value 1 < value 2                   :");
            System.Console.WriteLine("b. {0}",value1<value2);
            System.Console.Write("Is value 1 >= value 2                  :");
            System.Console.WriteLine("c. {0}",value1>=value2);
            System.Console.Write("Is value 1 <= value 2                  :");
            System.Console.WriteLine("d. {0}",value1<=value2);
            System.Console.Write("Is value 1 != value 2                  :");
            System.Console.WriteLine("e. {0}",value1!=value2);
            System.Console.Write("Is value 1 <= value 2                  :");
            System.Console.WriteLine("f. {0}",value1<=value2);
            System.Console.Write("Is value1>=10 && value2>=10            :");
            System.Console.WriteLine("g. {0}",value1>=10 && value2>=10);
            System.Console.Write("Is value1>=10 || value2>=30            :");
            System.Console.WriteLine("h. {0}",value1>=10 || value2>=30);
            System.Console.Write("Is !value1>20                          :");
            System.Console.WriteLine("i. {0}",!(value1>20));
             System.Console.Write("Is value1==15                          :");
            System.Console.WriteLine("j. {0}",value1==15?"True":"False");
            System.Console.Write("Is value1++                            :");
            System.Console.WriteLine("k. {0}",value1++);
            System.Console.Write("Is value1--                            :");
            System.Console.WriteLine("l. {0}",value1--);

            
        }
    }
}
