using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace Ecommerce
{
    public static class Files
    {
        //creating folder and file
        public static void CreateFiles()
        {
            if(!Directory.Exists("Commerce"))
            {
                Directory.CreateDirectory("Commerce");
            }
            if(!File.Exists("Commerce/Order.csv"))
            {
                File.Create("Commerce/Order.csv");
  
            }
            if(!File.Exists("Commerce/Product.csv"))
            {
                File.Create("Commerce/Product.csv");
            }
            if(!File.Exists("Commerce/Customer.csv"))
            {
                File.Create("Commerce/Customer.csv");
            }
        }
        //Read files 
        public static void ReadFiles()
        {
            //order files
            string[] order= File.ReadAllLines("Commerce/Order.csv");
            foreach(string line in order)
            {
                OrderDetails orders=new OrderDetails(line);
                OrderDetails.orderList.Add(orders);
            }
          
        }
        //write files 
        public static void WriteFiles()
        {
            string[] customer=new string[CustomerDetails.customerList.Count];
            for(int i=0;i<CustomerDetails.customerList.Count;i++)
            {
                customer[i]=CustomerDetails.customerList[i].CustomerId+","+CustomerDetails.customerList[i].Name+","+CustomerDetails.customerList[i].Email+","+CustomerDetails.customerList[i].City+","+CustomerDetails.customerList[i].MobileNumber;
            }
            File.WriteAllLines("Commerce/Customer.csv",customer);
        }
    }
}