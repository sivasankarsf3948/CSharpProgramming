using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce
{
    public enum OrderStatus{Default,Ordered,Cancelled}
    public class ProductClass
    {
       public static List<ProductClass> productList=new List<ProductClass>();
        public  static int s_productId=100;
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
        public  double Stock { get; set; }
        public OrderStatus Status { get; set; }
        public double ShippingDuration { get; set; }
        

        
        //constructor
        public ProductClass(string productName,double stock,double price,double shipDuration )
        {
            s_productId++;
            ProductName=productName;
            Stock=stock;
            Price=price;
            ShippingDuration=shipDuration;
            ProductId="PID"+s_productId;

        }
        
        
        //DefaultMethod
        public static void DefaultMethod()
        {
           ProductClass.productList.Add(new ProductClass("Mobie",10,10000,3));
            ProductClass.productList.Add(new ProductClass("Tablet",05,15000,2));
            ProductClass.productList.Add(new ProductClass("Camera",03,20000,4));
            ProductClass.productList.Add(new ProductClass("iPhone",05,50000,6));
            ProductClass.productList.Add(new ProductClass("Laptop",03,40000,3));
        }

        //purchase method
        public static void Purchase()
        {
            foreach(ProductClass product in productList)
            {
                System.Console.WriteLine($"Product ID                 : {product.ProductId}");
                System.Console.WriteLine($"Product Name               : {product.ProductName}");
                System.Console.WriteLine($"Product Available stock    : {product.Stock}");
                System.Console.WriteLine($"Product Price              : {product.Price}");
                System.Console.WriteLine($"Product Shipping duration  : {product.ShippingDuration}\n");
                
            }
            System.Console.WriteLine("Choose the product id you have to purchase");
            string productId=Console.ReadLine();
            System.Console.WriteLine("Enter number of items need to purchase");
            int count=int.Parse(Console.ReadLine());
            //product id match
            foreach(ProductClass product in productList)
            {
                if(productId==product.ProductId)
                {
                    if(product.Stock>=count)
                    {
                        double amount=(product.Price*count)+500;
                        if(CustomerDetails.WalletBalance>=amount)
                        {
                            CustomerDetails.WalletBalance=CustomerDetails.WalletBalance-amount;
                            product.Stock=product.Stock-count;
                            DateTime date=DateTime.Now.AddDays(product.ShippingDuration);
                            System.Console.WriteLine($"Your order placed successfully and delivered at {date}");
                            OrderDetails.orderList.Add(new OrderDetails(Operations.s_currentUser,productId,amount,DateTime.Now,count,OrderStatus.Ordered));
                        }
                        else{
                            System.Console.WriteLine("Insufficient wallet balance .Please recharge your wallet");
                        }
                    }
                    else
                    {
                        System.Console.WriteLine($"Required product count is not available . The available count is{product.Stock} " );
                    }
                }
            }
            
        }
        
        
         //Cancel order
        public static void  CancelOrder()
        {
            foreach(OrderDetails order in OrderDetails.orderList)
            {
                if(Operations.s_currentUser==order.CustomerId)
                {
                    System.Console.WriteLine($"Customer Id : {order.CustomerId}\tProduct Id  :{order.OrderId}\tTotal Price :{order.TotalPrice}\tOrdered date{DateTime.Now}\t Order Status  :{order.Status}");
                }
            }
            System.Console.WriteLine("Choose an order id to cancellation");
            string orderId=Console.ReadLine().ToUpper();
            foreach(OrderDetails order in OrderDetails.orderList)
            {
                if(Operations.s_currentUser==order.CustomerId)
                {//changing status
                    if(order.OrderId==orderId)
                    {
                        CustomerDetails.WalletBalance+=order.TotalPrice;
                        order.Status=OrderStatus.Cancelled;
                        //increasing the count
                       foreach(ProductClass product in productList)
                       {
                        if(order.ProductId==product.ProductId)
                        {
                            product.Stock+=order.Quantity;
                        }
                       }
                       System.Console.WriteLine("Your order cancelled successfully and your order status is "+order.Status);

                    }
                }
            

            }
            
        }
        
    }
}