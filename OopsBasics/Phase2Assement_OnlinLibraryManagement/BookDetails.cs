using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineLibraryManagement
{
    public class BookDetails
    {
        public static List<BookDetails> bookList=new List<BookDetails>();
        public string BookId { get; set; }
        public string BookName { get; set; }
        public string AuthorName { get; set; }
        public int BookCount { get; set; }
        
        
        
        
        //Constructor creation
        public BookDetails(string bookID,string bookName,string authorName,int bookCount)
        {
            BookId=bookID;
            BookName=bookName;
            AuthorName=authorName;
            BookCount=bookCount;
        }
        
        
        //DefaultMethod
        public static void DefaultMethod()
        {
            bookList.Add(new BookDetails("BID101","C#","Author1",3));
            bookList.Add(new BookDetails("BID102","HTML","Author2",5));
            bookList.Add(new BookDetails("BID103","CSS","Author1",3));
            bookList.Add(new BookDetails("BID104","JS","Author1",3));
            bookList.Add(new BookDetails("BID105","TS","Author2",2));
        }
        
    }
}