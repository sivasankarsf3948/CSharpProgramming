using System;

using System.IO;

namespace MovieTicketBooking
{
    public class Files
    {
        //create files
        public static void FileCreation()
        {
            if(!Directory.Exists("MovieTickets"))
            {
                Directory.CreateDirectory("MovieTickets");
            }

            if(!File.Exists("MovieTickets/UserDetails.csv"))
            {
                File.Create("MovieTickets/UserDetails.csv");
            }

             if(!File.Exists("MovieTickets/TheatreDetails.csv"))
            {
                File.Create("MovieTickets/TheatreDetails.csv");
            }

            if(!File.Exists("MovieTickets/ScreeningDetails.csv"))
            {
                File.Create("MovieTickets/ScreeningDetails.csv");
            }

            if(!File.Exists("MovieTickets/MovieDetails.csv"))
            {
                File.Create("MovieTickets/MovieDetails.csv");
            }

            if(!File.Exists("MovieTickets/BookingDetails.csv"))
            {
                File.Create("MovieTickets/BookingDetails.csv");
            }

        }

        //read files 
        public static void ReadFiles()
        {
            //userdetail file
            string[] lines=File.ReadAllLines("MovieTickets/UserDetails.csv");

            foreach(string data in lines)
            {
                UserDetails user=new UserDetails(data);
                Operation.usersList.Add(user);
            }
            //TheatreDetails
            string[] theatreLines=File.ReadAllLines("MovieTickets/TheatreDetails.csv");

            foreach(string theatreData in theatreLines)
            {
                TheatreDetails theatre=new TheatreDetails(theatreData);
                Operation.theatreList.Add(theatre);
            }

            //Screening detail
            string[] screenLines=File.ReadAllLines("MovieTickets/ScreeningDetails.csv");

            foreach(string screenData in screenLines)
            {
                ScreeningDetails screen=new ScreeningDetails(screenData);
                Operation.screenList.Add(screen);
            }

            //Movie details
             string[] movieLines=File.ReadAllLines("MovieTickets/MovieDetails.csv");

            foreach(string movieData in movieLines)
            {
                MovieDetails movie=new MovieDetails(movieData);
                Operation.movieList.Add(movie);
            }
            //booking details
            string[] bookinglines=File.ReadAllLines("MovieTickets/BookingDetails.csv");

            foreach(string bookingData in bookinglines)
            {
                BookingDetails booking=new BookingDetails(bookingData);
                Operation.bookingList.Add(booking);
            }


        }


        //writeLines
        public static void WriteLines()
        {
            //userDetails
            string[] users=new string[Operation.usersList.Count];
            for(int i=0;i<Operation.usersList.Count;i++)
            {
                users[i]=Operation.usersList[i].UserId+","+Operation.usersList[i].Name+","+Operation.usersList[i].Age+","+Operation.usersList[i].MobileNumber+","+Operation.usersList[i].WalletBalance;
            }
            File.WriteAllLines("MovieTickets/UserDetails.csv",users);

           // TheatreDetails

             string[] theatres=new string[Operation.theatreList.Count];
            for(int i=0;i<Operation.theatreList.Count;i++)
            {
                theatres[i]=Operation.theatreList[i].TheatreId+","+Operation.theatreList[i].TheatreName+","+Operation.theatreList[i].TheatreLocation;
            }
            File.WriteAllLines("MovieTickets/TheatreDetails.csv",theatres);

            //movie details
            string[] movies=new string[Operation.movieList.Count];
            for(int i=0;i<Operation.movieList.Count;i++)
            {
                movies[i]=Operation.movieList[i].MovieId+","+Operation.movieList[i].MovieName+","+Operation.movieList[i].Language;
            }
            File.WriteAllLines("MovieTickets/MovieDetails.csv",movies);

            //screening details
            string[] screens=new string[Operation.screenList.Count];
            for(int i=0;i<Operation.screenList.Count;i++)
            {
                screens[i]=Operation.screenList[i].MovieId+","+Operation.screenList[i].TheatreId+","+Operation.screenList[i].TicketPrice+","+Operation.screenList[i].NoOfSeatsAvailable;
            }
            File.WriteAllLines("MovieTickets/ScreeningDetails.csv",screens);

            //booking details

            string[] bookings=new string[Operation.bookingList.Count];
            for(int i=0;i<Operation.bookingList.Count;i++)
            {
                bookings[i]=Operation.bookingList[i].BookingId+","+Operation.bookingList[i].UserId+","+Operation.bookingList[i].MovieId+","+Operation.bookingList[i].TheatreId+","+Operation.bookingList[i].SeatCount+","+Operation.bookingList[i].TotalAmount+","+Operation.bookingList[i].BookingStatus;
            }
            File.WriteAllLines("MovieTickets/BookingDetails.csv",bookings);



        }

    }
}