using System;


namespace MovieTicketBooking
{
    public class MovieDetails
    {
        private static int s_movieId=1000;
        public string MovieId { get; set; }
        public string  MovieName { get; set; }
        public string Language { get; set; }

        //default value constructor
        public MovieDetails(string movieId,string movieName,string language)
        {
            MovieId=movieId;
            MovieName=movieName;
            Language=language;
        }

        //file constructor
        public MovieDetails(string data)
        {
        string[] value=data.Split(',');
        MovieId=value[0];
        s_movieId=int.Parse(value[0].Remove(0,3));
        MovieName=value[1];
        Language=value[2];
        }
    }
}