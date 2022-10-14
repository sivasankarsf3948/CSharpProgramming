using System;
namespace ExceptionHandling;
class Program{
    public static void Main(string[] args)
    {
        try
        {
            System.Console.WriteLine("Enter number 1");
            int number1=int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter number 2");
            int number2=int.Parse(Console.ReadLine());
            int output=number1/number2;
            System.Console.WriteLine(output);
        }
        catch(DivideByZeroException e)
        {
            System.Console.WriteLine("An excepion Occured :{0}",e.Message);
            System.Console.WriteLine("An excepion Occured :{0}",e.StackTrace);
        }catch(FormatException e)
        {
            System.Console.WriteLine("An exception occured :{0}",e.Message);
            System.Console.WriteLine("An exception occured :{0}",e.StackTrace);
        }
        catch(Exception e)
        {
            System.Console.WriteLine(e.Message);
            System.Console.WriteLine(e.StackTrace);
        }
        finally
        {
            System.Console.WriteLine("All Exception Handled properly");
        }

    }
}
