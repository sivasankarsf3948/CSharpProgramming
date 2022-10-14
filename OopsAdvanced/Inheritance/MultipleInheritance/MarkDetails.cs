using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultipleInheritance
{
    public interface IMarkDetails
    {
         int Physics { get; set; }
        int Chemistry { get; set; }
        int Maths { get; set; }
        int Total { get; set; }
        double Average { get; set; }
        void GetMark(int physics,int chemistry,int maths);
        
        //
        
        void Calculate();//Method declaration only present
        
        
        void ShowMark();
        
        
        
    }
}