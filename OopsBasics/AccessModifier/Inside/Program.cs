﻿using System;
namespace Inside;
class Program
{
    public static void Main(string[] args)
    {
        First one=new First();
        System.Console.WriteLine(one.PublicNumber);
        System.Console.WriteLine(one.PrivateOutput);
        System.Console.WriteLine(one.InternalNumber);
       // System.Console.WriteLine(one.ProtectedNumber);
        Second two=new Second();
        System.Console.WriteLine(two.PrivateOutput);
        System.Console.WriteLine(one.ProtectedInternaOutput);
    }
}
