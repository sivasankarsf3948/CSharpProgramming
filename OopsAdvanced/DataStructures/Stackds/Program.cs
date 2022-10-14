using System;
namespace Stackds
{
    class Program 
    {
        public static void Main(string[] args)
        {
            Stackds<string> myStack=new Stackds<string>(1);
            myStack.Push(1);
            myStack.Push(1);
            myStack.Pop();
            myStack.Contains(1);
            myStack.Peek();//say top value
        }
    }
}
