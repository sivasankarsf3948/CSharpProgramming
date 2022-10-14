using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VaccineApplication
{
    public class Vaccination
    {
       public static  List<Vaccination> vaccinationList=new List<Vaccination>();
       public static string currentBenefisciaryId=null;
        private static int s_vaccinationId=1000;
        public string VaccinationId { get; set; }
        public string VaccineId { get; set; }
        public string RegistrationNumber { get; set; }
        public int DoseNumber { get; set; }
        public DateTime  VaccinationDate { get; set; }
        
        //constructor
        public Vaccination(string vaccineId,int doseNumber,DateTime date,string regNumber)
        {
            s_vaccinationId++;
            VaccinationId="VID"+s_vaccinationId;
            VaccineId= vaccineId;
            RegistrationNumber=regNumber;
            DoseNumber=doseNumber;
            VaccinationDate=date;

        }

        public Vaccination(string data1)
        {
            string[] value=data1.Split(',');
            s_vaccinationId=int.Parse(value[0].Remove(0,3));
            VaccinationId=value[0];
            VaccineId= value[1];
            RegistrationNumber=value[2];
            DoseNumber=int.Parse(value[3]);
            VaccinationDate=DateTime.Parse(value[4],null);
        }
        
        //DefaultMethod
        public static void DefaultMethod()
        {
         vaccinationList.Add(new Vaccination("CID101",1,new DateTime(2021,11,11),"BID1001"));
         vaccinationList.Add(new Vaccination("CID101",1,new DateTime(2022,03,11),"BID1001"));
         vaccinationList.Add(new Vaccination("CID102",1,new DateTime(2022,04,04),"BID1002"));
        }

        //TakeVaccination Method
        public static void TakeVaccination()
        {
           VaccineAvailable.ShowVaccine();
           System.Console.WriteLine("Choose the Vaccination Id");
           string choosedvaccineId=Console.ReadLine().ToUpper();
           int count=0,temp=0;
           foreach(VaccineAvailable vaccine in VaccineAvailable.vaccineList )
           {
             if(choosedvaccineId==vaccine.VaccineId)
             {
                count++;
             }
           }
            if(count>=1)
            {
                
                foreach(Vaccination beneficiary in vaccinationList)
                {
                    if(beneficiary.RegistrationNumber==Operations.currentUser.RegistrationNumber)
                    {
                        temp++;
                       
                       if(beneficiary.DoseNumber>=1 && beneficiary.DoseNumber<3)
                        {
                           
                          if(choosedvaccineId==beneficiary.VaccineId)
                            {
                                
                                TimeSpan span=DateTime.Now.Subtract(beneficiary.VaccinationDate);
                                if(span.TotalDays>30)
                                {
                                    
                                beneficiary.DoseNumber++;
                                beneficiary.VaccinationId=currentBenefisciaryId;
                                VaccineAvailable.DoseCountDecrease();
                                //next due date
                                System.Console.WriteLine("You can take vaccine now");
                                }
                            }
                        else
                            {
                            System.Console.WriteLine("Your choosen Vaccine Id mismatch with with before dose vaccination id");
                            }
                        }
                        else if(beneficiary.DoseNumber>=3)
                        {
                           // System.Console.WriteLine("");
                            System.Console.WriteLine("All the three Vaccination course are completed you cannot be vaccinated now");
                            
                        }
                        

                        
                    }
                    
                }
                if(temp==0)
                {
                   
                    if(Operations.currentUser.Age>=14)
                        {
                        
                            System.Console.WriteLine("You can take vaccine ");
                            vaccinationList.Add(new Vaccination(choosedvaccineId,1,new DateTime(2021,11,11),Operations.currentUser.RegistrationNumber));
                            
                            VaccineAvailable.DoseCountDecrease();
                        
                        }
                    
                }
                
                

            }
            else
            {
                System.Console.WriteLine("Choosen Id does not match with available vaccine Id. Choose correct ID");
            }

           
           
        }

        //show vaccine history

        public static void MyVaccinationHistory()
        {
            foreach(Vaccination member in vaccinationList)
            {
                if(member.RegistrationNumber==Operations.currentUser.RegistrationNumber)
                {
                    System.Console.WriteLine("Registration Number   :"+member.RegistrationNumber);
                    System.Console.WriteLine("Vaccination Id        :"+member.VaccinationId);
                    System.Console.WriteLine("Vaccine Id            :"+member.VaccineId);
                    System.Console.WriteLine("Number of doses taken :"+member.DoseNumber);
                    System.Console.WriteLine("Last Vaccination date :"+member.VaccinationDate);
                }
            }
        }

        public static void NextDueDate()
        {
                foreach(Vaccination beneficiary in vaccinationList)
                {
                    if(beneficiary.RegistrationNumber==Operations.currentUser.RegistrationNumber)
                    {
                        if(beneficiary.DoseNumber<1 && Operations.currentUser.Age>=14)
                        {
                            System.Console.WriteLine("You can take vaccine now");
                          //  beneficiary.DoseNumber++;
                          //  beneficiary.VaccinationId=currentBenefisciaryId;
                          //  VaccineAvailable.DoseCountDecrease();
                           
                        }
                        else if(beneficiary.DoseNumber>=1 && beneficiary.DoseNumber<3)
                        {
                           
                            {
                                DateTime due=beneficiary.VaccinationDate;
                                due=due.AddDays(30);
                                System.Console.WriteLine("Your next vaccination date is "+due);
                                //next due date
                                
                                }
                           
                        }
                        else if(beneficiary.DoseNumber>=3)
                        {
                           // System.Console.WriteLine("");
                            System.Console.WriteLine("You have completed the vaccination course. Thanks for your participation in the vaccination drive");
                            
                        }
                        
                        

                        
                    }
                }

          
        }
        
        
        
        
        
    }
}