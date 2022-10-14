using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VaccineApplication
{
    public class VaccineAvailable
    {     
        public static List<VaccineAvailable> vaccineList=new List<VaccineAvailable>(); 
        private static int s_vaccineId=100;
        public string VaccineId { get; set; }
        public string VaccineName { get; set; }
        public int DosesAvailable { get; set; }
        

        public VaccineAvailable(string doseName,int doseCount)
        {
            s_vaccineId++;
            VaccineId="CID"+s_vaccineId;
            VaccineName=doseName;
            DosesAvailable=doseCount;
        }

        public VaccineAvailable(string data1)
        {
            string[] value1=data1.Split(',');
            s_vaccineId=int.Parse(value1[0].Remove(0,3));
            VaccineId=value1[0];
             VaccineName=value1[1];
            DosesAvailable=int.Parse(value1[2]); 


        }



        public static void DefaultMethod()
        {
            vaccineList.Add(new VaccineAvailable("CoviShield",50));
            vaccineList.Add(new VaccineAvailable("Covaccine",50));
        }  

        //Show Vaccine Method
        public static void ShowVaccine()
        {
             foreach(VaccineAvailable vaccine in vaccineList)
            {
                 System.Console.WriteLine(($"VaccineId  :{vaccine.VaccineId}\tVaccine Name  :{vaccine.VaccineName}\tNo of doses :{vaccine.DosesAvailable}"));
            }
        }  
        //DoseCountDecrease
        public static void DoseCountDecrease()
        {
            foreach(VaccineAvailable vaccine in vaccineList)
            {
                if(Vaccination.currentBenefisciaryId==vaccine.VaccineId)
                {
                    vaccine.DosesAvailable--;
                }
            }
        

        

           
        }    

    }
}