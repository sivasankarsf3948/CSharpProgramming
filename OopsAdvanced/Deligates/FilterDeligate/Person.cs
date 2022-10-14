using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilterDeligates
{
    //Multiple conditions in dynamic
    public delegate bool FilterDeligate(Person p);//Our delegate
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}