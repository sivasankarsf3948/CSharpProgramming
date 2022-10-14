using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Interface
{
    public interface IRectangle
    {
         int Length { get; set; }
         int Breadth { get; set; }
        //public int Area { get; set; }
         
         
        void GetData(int length,int breadth);
         void CalculateArea();
         
         
        
        
    }
}