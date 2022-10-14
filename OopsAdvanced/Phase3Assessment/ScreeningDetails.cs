using System;


namespace MovieTicketBooking
{
    public class ScreeningDetails
    {
        /// <summary>
        /// Holds the Id of movie
        /// </summary>
        /// <value></value>
        public string MovieId { get; set; }
        /// <summary>
        /// Holds the movies theatre Id
        /// </summary>
        /// <value></value>
        public string TheatreId { get;  }
        public int NoOfSeatsAvailable { get; set; }
        public double TicketPrice { get; set; }

        public ScreeningDetails(string movieId,string theatreId,double ticketPrice,int seats)
        {
            MovieId=movieId;
            TheatreId=theatreId;
            
            TicketPrice=ticketPrice;
            NoOfSeatsAvailable=seats;
        }

        //file constructor
       public ScreeningDetails(string data)
        {
        string[] value=data.Split(',');
        MovieId=value[0];
        TheatreId=value[1];
        TicketPrice=double.Parse(value[2]);
        NoOfSeatsAvailable=int.Parse(value[2]);
        }

    }
}