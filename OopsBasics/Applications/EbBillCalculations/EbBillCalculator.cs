using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EbBillCalculations
{
    public class EbBillCalculator
    {
        private static int _sid=1000;
        public string UserName { get; set; }
        public string MeterId { get;  }
        public long  Phone { get; set; }
        public string Mail { get; set; }
        public double UnitsUsed { get; set; }
        
        
        
        public EbBillCalculator(string name,long phone,string mail)
        {
            _sid++;
            MeterId="EB"+_sid;
            UserName=name;
            Phone=phone;
            Mail=mail;
            
        }
       
        
       public double CalculateAmount(double units) 
       { 
        double amount=0;

        if(units<=100)
        {
          amount=0;
        }
        else if(units>100 && units<=200)
        {
         amount=units*3;
        }
        else if(units>200 && units<=400)
        {
          amount=units*5;
        }
        else{
          amount=units*6;
        }
        return amount;
       }
        
        
        
    }
}