using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineLibraryManagement
{
    public enum Status{Default,Issued,Returned}
    public class BorrowDetails
    {
        private static int s_borrowId=300;
        public static List<BorrowDetails> borrowList=new List<BorrowDetails>();
        public string BorrowId { get; set; }
        public string BookId { get; set; }
        public string RegistrationId { get; set; }
        public DateTime BorrowedDate { get; set; }
        public Status Status { get; set; }
        
        

       //Constructor creation
       public BorrowDetails(string bookId,string registerId, DateTime date,Status status)
       {
        s_borrowId++;
        BorrowId="LB"+s_borrowId;
        BookId=bookId;
        RegistrationId=registerId;
        BorrowedDate=date;
        Status=status;


       } 
        
        
        //DefaultMethod
        public static void DefaultMethod()
        {
            borrowList.Add(new BorrowDetails("BID101","SF3001",new DateTime(2022,04,10),Status.Issued));
            borrowList.Add(new BorrowDetails("BID103","SF3001",new DateTime(2022,04,12),Status.Returned));
            borrowList.Add(new BorrowDetails("BID104","SF3001",new DateTime(2022,04,15),Status.Issued));
            borrowList.Add(new BorrowDetails("BID102","SF3002",new DateTime(2022,04,11),Status.Returned));
            borrowList.Add(new BorrowDetails("BID151","SF3002",new DateTime(2022,04,15),Status.Issued));

        }
        
        
        
        
    }
}