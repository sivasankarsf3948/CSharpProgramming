using System;


namespace MovieTicketBooking
{
    public class UserDetails:PersonalDetails,IWallet
    {
        private static int s_userId=1000;
        public string UserId { get; set; }
        public double WalletBalance { get; set; }

    //default constructor
    public UserDetails()
    {

    }

    //file constructor
    public UserDetails(string data)
    {
        string[] value=data.Split(',');
        UserId=value[0];
        s_userId=int.Parse(value[0].Remove(0,3));
        Name=value[1];
        Age=int.Parse(value[2]);
        MobileNumber=long.Parse(value[3]);
        WalletBalance=double.Parse(value[4]);

    }
    //new user constructor
    public UserDetails(string name,int age,long phone):base(name,age,phone)
    {
        s_userId++;
        UserId="UID"+s_userId;
        WalletBalance=0;
    }


    //file or default constructor with userId
     public UserDetails(string userId,string name,int age,long phone,double balance):base(name,age,phone)
    {
        
        UserId=userId;
        WalletBalance=balance;
    }

    
    public  void WalletRecharge(double amount)
    {
       
       
        Operation.s_currentUser.WalletBalance+=amount;
        System.Console.WriteLine("Now your Wallet balance is :"+Operation.s_currentUser.WalletBalance);
    }
    }
}