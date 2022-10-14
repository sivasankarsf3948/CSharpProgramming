using System;


namespace MovieTicketBooking
{
    public class PersonalDetails
    {
        /// <summary>
        /// Holds the name of current user
        /// </summary>
        /// <value></value>
        public string Name { get; set; }
        /// <summary>
        /// Holds the age of current user
        /// </summary>
        /// <value></value>
        public int Age { get; set; }
        /// <summary>
        /// Holds the Mobile number of current user
        /// </summary>
        /// <value></value>
        public long MobileNumber { get; set; }

        //default constructor
        /// <summary>
        /// Default constructor of personal details class
        /// </summary>
        public PersonalDetails()
        {

        }
        /// <summary>
        /// Parameterized constructor
        /// </summary>
        /// <param name="name"></param>
        /// <param name="age"></param>
        /// <param name="phone"></param>

        public PersonalDetails(string name,int age,long phone)
        {
            Name=name;
            Age=age;
            MobileNumber=phone;
        }
    }
}