using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SealedMethod
{
  public class Puppy:Dog
    {
        public override void MakeSound()
        {
            System.Console.WriteLine("Puppy sound");
        }
    }
}