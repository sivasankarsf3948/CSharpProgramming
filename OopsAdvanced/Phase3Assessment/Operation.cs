using System;


namespace MovieTicketBooking
{
 
    public delegate void EventManager();
    /// <summary>
    /// This class operate all other inbuild components
    /// </summary>
    public class Operation
    {
        /// <summary>
        /// Contains user details
        /// </summary>
        /// <typeparam name="UserDetails"></typeparam>
        /// <returns>an array of users details</returns>
        public static List<UserDetails> usersList=new List<UserDetails>();
        /// <summary>
        /// Contains theatre lists
        /// </summary>
        /// <typeparam name="TheatreDetails"></typeparam>
        /// <returns>array of theatre details</returns>
        public static List<TheatreDetails> theatreList=new List<TheatreDetails>();
        /// <summary>
        /// Contains a list of movies
        /// </summary>
        /// <typeparam name="MovieDetails"></typeparam>
        /// <returns></returns>
        public static List<MovieDetails> movieList=new List<MovieDetails>();
        /// <summary>
        /// Contains theatre with screens details
        /// </summary>
        /// <typeparam name="ScreeningDetails"></typeparam>
        /// <returns></returns>
        public static List<ScreeningDetails> screenList=new List<ScreeningDetails>();
        /// <summary>
        /// Contains a list of booking detais
        /// </summary>
        /// <typeparam name="BookingDetails"></typeparam>
        /// <returns></returns>
        public static List<BookingDetails> bookingList=new List<BookingDetails>();
        /// <summary>
        /// Holds the details of current user 
        /// </summary>
        public static UserDetails s_currentUser=null;
        public static event EventManager eventlink=null;
        /// <summary>
        /// It holds user registration , login and exit options
        /// </summary>
        public static void MainMenu()
        {
            string condition="yes";
            do{

            
                System.Console.WriteLine();
                System.Console.WriteLine("-------------ManiMenu----------");
                System.Console.WriteLine();
                System.Console.WriteLine("Select Options :\n\n1.UserRegistration\n2.Login\n3.Exit");
                int choice=int.Parse(Console.ReadLine());
                switch(choice)
                {
                    case 1:
                    {
                        System.Console.WriteLine();
                        System.Console.WriteLine("----------User Registration-------");
                        UserRegistration();
                        break;
                    }
                    case 2:
                    {
                        System.Console.WriteLine();
                        System.Console.WriteLine("----------User Login-------");  
                        LogIn();
                        break;
                    }
                    case 3:
                    {
                        System.Console.WriteLine();
                        System.Console.WriteLine("Thank you!!!Enjoy your Movie!!!");
                        condition="no";
                        break;
                    }
                }
                

            }while(condition=="yes");
        }

    //events linking
    /// <summary>
    /// Subscribe method  links the events in a order manner
    /// </summary>
        public static void Subscribe()
        {
            eventlink+=new EventManager(Files.FileCreation);
            eventlink+=new EventManager(Files.ReadFiles);
            eventlink+=new EventManager(Operation.MainMenu);
            eventlink+=new EventManager(Files.WriteLines);


        }
    //start event
    /// <summary>
    /// Start event trigger the events
    /// </summary>
        public static void StartEvent()
        {
            Subscribe();
            eventlink();
        }

/// <summary>
/// Register the new user
/// </summary>
        public static void UserRegistration()
        {
            System.Console.WriteLine("Enter your Name");
            string name=Console.ReadLine();
            System.Console.WriteLine("Enter your Age");
            int age=int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter your mobile number");
            long phone=long.Parse(Console.ReadLine());
            
            UserDetails user=new UserDetails(name,age,phone);
            usersList.Add(user);

            System.Console.WriteLine("Your user id is :"+user.UserId);
        }



/// <summary>
/// checking enterd userId to login application
/// </summary>
        public static void LogIn()
        {
            int flag=0;
            System.Console.WriteLine("Enter your user Id");
            string enteredUserId=Console.ReadLine().ToUpper();
            foreach(UserDetails users in usersList)
            {
                if(users.UserId==enteredUserId)
                {
                    System.Console.WriteLine();
                    System.Console.WriteLine("------Logged In!!!------");
                    s_currentUser=users;
                    flag++;
                    SubMenu();
                    
                }
            }
            if(flag==0)
            {
                System.Console.WriteLine("Invalid User Id... Please enter the correct one!!");
            }
        }

/// <summary>
/// contains ticket booking,cancellation,booking history,wallet recharge ,exit
/// </summary>
        public static void SubMenu()
        {
             string condition="yes";

             
           
            do{

            
                System.Console.WriteLine();
                System.Console.WriteLine("-------SubMenu-----");
                System.Console.WriteLine("Select Options    :\n\n1.Ticket Booking\n2.Ticket Cancellation\n3.Booking History\n4.Wallet Recharge\n5.Exit");
               
                int choice=int.Parse(Console.ReadLine());
                switch(choice)
                {
                    case 1:
                    {
                        System.Console.WriteLine();
                        System.Console.WriteLine("----------Ticket Booking-------");
                        TicketBooking();
                       
                        break;
                    }
                    case 2:
                    {
                        System.Console.WriteLine();
                        System.Console.WriteLine("----------Ticket Cancellation-------");  
                        TicketCancellation();

                
                        break;
                    }
                    case 3:
                    {
                        System.Console.WriteLine();
                        System.Console.WriteLine("----------Booking History-------");  
                        BookingHistory();
                        break;
                    }
                     case 4:
                    {
                        System.Console.WriteLine();
                        System.Console.WriteLine("----------WalletRecharge-------");  
                        System.Console.WriteLine("Your current Wallet balance is :"+Operation.s_currentUser.WalletBalance);
                         
                        System.Console.WriteLine("Enter the amount you want to recharge now");
                        double recharge=double.Parse(Console.ReadLine());
                        s_currentUser.WalletRecharge(recharge);
                        break;
                    }
                     case 5:
                    {
                        System.Console.WriteLine();
                        System.Console.WriteLine("----------Exit from submenu----------------");  
                        System.Console.WriteLine();
                        System.Console.WriteLine("----------Redirirecting to Mani menu-------");
                        condition="no";
                        break;
                    }
                }
                

            }while(condition=="yes");
        }

/// <summary>
/// book the tickets
/// </summary>
        public static void TicketBooking()
        {
            ShowTheatre();
        
            System.Console.WriteLine("Selet a thetre Id from above list");
            string theatreId=Console.ReadLine().ToUpper();
            //showing movie list on the specific theatre
            foreach(ScreeningDetails screenedMovie in screenList)
            {
                if(theatreId==screenedMovie.TheatreId)//user entered theatre id compares with scrreneing theatre lists
                {
                   foreach(MovieDetails movies in movieList)
                   {

                        if(screenedMovie.MovieId==movies.MovieId)//incoming theatre movies compare with movie list
                        {
                            System.Console.WriteLine($"Movie Id  :{movies.MovieId}\tTheatre Id   :{screenedMovie.TheatreId}\tMovie Name   :{movies.MovieName}\t Language   :{movies.Language}   Ticket Price :{screenedMovie.TicketPrice}  Seat Availability{screenedMovie.NoOfSeatsAvailable}");
                        }
                   }
                            System.Console.WriteLine();
                            System.Console.WriteLine("Enter a movie Id from above the list.. ");
                            string movieId=Console.ReadLine().ToUpper();
                            System.Console.WriteLine("Enter the seat counts you need..");
                            int seatCount=int.Parse(Console.ReadLine());
                            
                            if(screenedMovie.NoOfSeatsAvailable>=seatCount)//seat availability check
                            {
                                double amount=seatCount*screenedMovie.TicketPrice;
                                double tax=amount*0.18;
                                double totalAmount=amount+tax;

                                if(totalAmount<=s_currentUser.WalletBalance)
                                {
                                    s_currentUser.WalletBalance-=totalAmount;
                                    screenedMovie.NoOfSeatsAvailable-=seatCount;
                                    System.Console.WriteLine("Your ticket Booking is successful");
                                    bookingList.Add(new BookingDetails(s_currentUser.UserId,screenedMovie.MovieId,screenedMovie.TheatreId,seatCount,totalAmount,BookingStatus.Booked));
                                    break;
                                }
                                else
                                {
                                    System.Console.WriteLine("Insufficient wallet balance ... please recharge");
                                    break;
                                    
                                }

                            }else{System.Console.WriteLine($"Required Seat count not available. Current availability is {screenedMovie.NoOfSeatsAvailable}");}
                            
                            
                }

                   


                
            }
        

        }
/// <summary>
/// show the booking history
/// </summary>
    public static void BookingHistory()
    {
         foreach(BookingDetails bookings in bookingList)
        {
            if(s_currentUser.UserId==bookings.UserId )
            {
                System.Console.WriteLine("Booking Id   :"+bookings.BookingId+"     Movie Id    :"+bookings.MovieId+"\tTotal amount      :"+bookings.TotalAmount+"\tTheatre Id    :"+bookings.TheatreId+"\tSeat Count    :"+bookings.SeatCount+"\tBooking Status :"+bookings.BookingStatus);
            }
        }
    }
/// <summary>
/// Cancelling the tickets
/// </summary>
         public static void TicketCancellation()
        {
        //show booking details with booked status
        System.Console.WriteLine("Your booking history are");
            foreach(BookingDetails bookings in bookingList)
            {
                if(s_currentUser.UserId==bookings.UserId )
                {
                    System.Console.WriteLine("Booking Id    : "+bookings.BookingId+"\tMovie Id   : "+bookings.MovieId+"\tTotal amount    : "+bookings.TotalAmount+"\tBooking Status     : "+bookings.BookingStatus);
                }
                
            }
            System.Console.WriteLine("Enter a booking id to delete");
            string bookId=Console.ReadLine();
            foreach(BookingDetails bookings in bookingList)
            {
                if(bookId==bookings.BookingId)
                {
                    if(bookings.BookingStatus.Equals(BookingStatus.Booked))
                    {
                        bookings.BookingStatus=BookingStatus.Cancelled;
                        s_currentUser.WalletBalance+=(bookings.TotalAmount-20);
                         System.Console.WriteLine("Your Booking is cancelled");
                        foreach(ScreeningDetails theatres in screenList)
                        {
                        if(bookings.MovieId==theatres.MovieId)
                        {
                            theatres.NoOfSeatsAvailable+=bookings.SeatCount;
                           
                            break;
                        }
                        }

                    }else{System.Console.WriteLine("Your booking is already in cancelled state");}

                    
                    
                   
                    

                }
                }
            }

           
        
        //show theatre lists
        /// <summary>
        /// Show the list of theatres
        /// </summary>
        public static void ShowTheatre()
        {
            System.Console.WriteLine();
            System.Console.WriteLine("-------List of theatres----");
            System.Console.WriteLine();
            foreach(TheatreDetails theatres in theatreList)
            {
                System.Console.WriteLine($"Theatre Id   :{theatres.TheatreId}\tTheatre Name    :{theatres.TheatreName}           \tTheatreLocation     :{theatres.TheatreLocation}");
            }
        }


       


    }
}