using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstractClasses
{
    public abstract class AbstractBase
    {
        protected string name ;//normal field
        public abstract string Name { get; set; } //abstract property
        public double amount { get; set; }
        

        //normal method
        public void Display()
        {
            System.Console.WriteLine("Name     :"+name);
        }
        
        //abstract method
        public abstract void Salary(int dates);//abstract method
        
        

    }
}