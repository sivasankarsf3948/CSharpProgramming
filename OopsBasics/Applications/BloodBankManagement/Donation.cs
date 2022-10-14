using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BloodBankManagement
{
    public class Donation
    {
        public static List<Donation> donationList=new  List<Donation>();

        private static int s_donationId=1000;
       public int  DonorId { get; set; }
       public DateTime DonationDate { get; set; }
       public double Weight { get; set; }
       public double BloodPressure { get; set; }
       public double Haemoglobin { get; set; }
       public int DonationId { get; set; }
      

      //property
        public Donation(double weight,double bp,double haemoglobin,int donorId,DateTime date)
        {
            s_donationId++;

          Weight=weight;
          BloodPressure=bp;
          Haemoglobin=haemoglobin;
          DonorId=donorId;
          DonationDate=date;

            DonationId=s_donationId;


        }
       
    
     //Donate blood
        public static void DonateBlood()
        {
          //  Donation donor=new Donation();
            System.Console.WriteLine("Enter your weight");
            double weight=double.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter Blood Pressure");
            double bp=double.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter haemoglobin count ");
            double haemoglobin=double.Parse(Console.ReadLine());
           

         //TimeSpan span=DateTime.Now.Subtract(UserRegistration.DonationDate);
        
         //checking eligibility of donor
            if(weight>50 && bp<130 && haemoglobin>13)
            {
                Donation donor1=new Donation(weight,bp,haemoglobin,Operations.currentDonorId,DateTime.Now);
                donationList.Add(donor1);
                System.Console.WriteLine("Blood Donated successfully!! Your donation Id is "+donor1.DonationId);

            }
        }

            //donationHistory
            public static void DonnationHistory()
            {
                foreach(Donation donor in donationList)
                {
                        System.Console.WriteLine("Enter your donation ID");
                    int donationId=int.Parse(Console.ReadLine());
                    
                    if(donor.DonationId==donationId)
                    {
                        System.Console.WriteLine("Your weight is           "+donor.Weight);
                        System.Console.WriteLine("Your Blood Pressure iscc "+donor.BloodPressure);
                        System.Console.WriteLine("Your Haemoglobin count is"+donor.Haemoglobin);
                    
                    }
             
                
                }
            }
                //Next eligible date
                public static void NextEligibledate()
                {
                     foreach(Donation donor in donationList)
                    {
                        System.Console.WriteLine("Enter your donation ID");
                        int donationId=int.Parse(Console.ReadLine());
                    
                        if(donor.DonationId==donationId)
                        {
                        
                        System.Console.WriteLine("Next Donation Date is    "+donor.DonationDate.AddDays(60));
                        }
                    }
                }
            
            
            

        
        
        
     
    }
    
    
    
    



    
}