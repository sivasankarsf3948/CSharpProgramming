using System;


namespace MovieTicketBooking
{
    public class TheatreDetails
    {
        private static int s_theatreId=300;
        public string TheatreId { get;  }
        public string TheatreName { get; set; }
        public string TheatreLocation { get; set; }

        //default value constructor
        public TheatreDetails(string theatreId,string theatreName,string theatreLocation)
        {
            TheatreId=theatreId;
            TheatreName=theatreName;
            TheatreLocation=theatreLocation;
        }

        //file constructor
         public TheatreDetails(string data)
        {
        string[] value=data.Split(',');
        TheatreId=value[0];
        s_theatreId=int.Parse(value[0].Remove(0,3));
        TheatreName=value[1];
        TheatreLocation=value[2];
        }

        //if in  theatre registration needed   constructor
        public TheatreDetails(string theatreName,string theatreLocation)
        {
            s_theatreId++;
            TheatreId="TID"+s_theatreId;
            TheatreName=theatreName;
            TheatreLocation=theatreLocation;
        }
    }
}