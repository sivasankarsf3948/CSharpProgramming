using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce
{
    public class OrderDetails
    {
        private static int s_orderId=1000;
        public static List<OrderDetails> orderList=new List<OrderDetails>();
        public string OrderId { get; set; }
        public int Quantity { get; set; }
        
        
        public string CustomerId { get; set;} 
        public string ProductId { get; set; }
        public double TotalPrice { get; set; }
        public DateTime PurchaseDate { get; set; }
        public OrderStatus Status { get; set; }
        
        
        
        
        
       //constructor
       public OrderDetails(string customerId,string productId,double price,DateTime date,int quantity,OrderStatus status)
       {
        s_orderId++;
        OrderId="OID"+s_orderId;
        CustomerId=customerId;
        ProductId=productId;
        TotalPrice=price;
        PurchaseDate=date;
        Quantity=quantity;
        Status=status;

       }
       //file constructor
       public OrderDetails(string data)
       {
        string[] value=data.Split(',');
        s_orderId=int.Parse(value[0].Remove(0,3));
        OrderId=value[0];
        CustomerId=value[1];
        ProductId=value[2];
        TotalPrice=int.Parse(value[3]);
        PurchaseDate=DateTime.Parse(value[4],null);
        Quantity=int.Parse(value[5]);
        Status=Enum.Parse<OrderStatus>(value[6]);

       }
        
        

        //defaultMethod
        public static void DefaultMethod()
        {
            orderList.Add(new OrderDetails("CID1001","PID101",20000,DateTime.Now,2,OrderStatus.Ordered));
            orderList.Add(new OrderDetails("CID1002","PID103",40000,DateTime.Now,2,OrderStatus.Ordered));
        }



        //Ordered history
        public static void OrderHistory()
        {
            foreach(OrderDetails order in orderList)
            {
                if(Operations.s_currentUser==order.CustomerId)
                {
                    System.Console.WriteLine($"Customer Id : {order.CustomerId}\tProduct Id  :{order.ProductId}\tTotal Price :{order.TotalPrice}\tOrdered date{DateTime.Now}\t Order Status  :{order.Status}");
                }
            }
       
        }  


       
    }
}