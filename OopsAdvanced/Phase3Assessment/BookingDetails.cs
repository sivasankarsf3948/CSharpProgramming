using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieTicketBooking
{
    enum BookingStatus{Default,Booked,Cancelled}
    public class BookingDetails
    {
        private static int s_bookingId=7000;
        public string BookingId { get; set; }
        public string UserId { get;  }
        public string MovieId { get;  }
        public string TheatreId { get;  }
        public int SeatCount { get; set; }
        public double TotalAmount { get; set; }
        public Enum BookingStatus { get; set; }

        public BookingDetails(string userId,string movieId,string theatreId,int seatCount,double totalAmount,Enum bookingStatus)
        {
            s_bookingId++;
            BookingId="BID"+s_bookingId;
            UserId=userId;
            MovieId=movieId;
            TheatreId=theatreId;
            SeatCount=seatCount;
            TotalAmount=totalAmount;
            BookingStatus=bookingStatus;

        }
        //file constructor
        public BookingDetails(string data)
        {
        string[] value=data.Split(',');
        BookingId=value[0];
        s_bookingId=int.Parse(value[0].Remove(0,3));
        UserId=value[1];
        MovieId=value[2];
        TheatreId=value[3];
        SeatCount=int.Parse(value[4]);
        TotalAmount=double.Parse(value[5]);
        BookingStatus=Enum.Parse<BookingStatus>(value[6],true);
        }

        //deault constructotr
         public BookingDetails(string bookingId,string userId,string movieId,string theatreId,int seatCount,double totalAmount,Enum bookingStatus)
        {
            
            BookingId=bookingId;
            UserId=userId;
            MovieId=movieId;
            TheatreId=theatreId;
            SeatCount=seatCount;
            TotalAmount=totalAmount;
            BookingStatus=bookingStatus;

        }

        
    }
}