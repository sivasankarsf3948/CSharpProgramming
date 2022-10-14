using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstractClasses
{
    public class Tcs:AbstractBase
    {
        //Abstract property defition
        public override string Name { get{return name;} set{name=value;}}
        //Abstract metod definition
        public override void Salary(int dates)
        {
            Display();
            amount=(double)dates*300;
            System.Console.WriteLine(amount);
        }
    }
}