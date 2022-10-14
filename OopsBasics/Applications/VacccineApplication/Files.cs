using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace VaccineApplication
{
    public static class Files
    {
        //creating folder
        public static void CreateFolderAndFile()
        {//creating folder and file
            if(!Directory.Exists("Vaccine"))
            {
                Directory.CreateDirectory("Vaccine");
                System.Console.WriteLine("New Folder created");
            }
            if(!File.Exists("Vaccine/Beneficiary.csv"))
            {
                File.Create("Vaccine/Beneficiary.csv");
                System.Console.WriteLine("File created");
            }
            if(!File.Exists("Vaccine/Vaccination.csv"))
            {
                File.Create("Vaccine/Vaccination.csv");
                System.Console.WriteLine("File created");
            }
            if(!File.Exists("Vaccine/VaccineAvailable.csv"))
            {
                File.Create("Vaccine/VaccineAvailable.csv");
            }
           

        }
    //File   read method 
        public static void ReadFiles()
        {
            //read return string array
            string[] beneficiary=File.ReadAllLines("Vaccine/Beneficiary.csv");
            //array file data traverse string data va list send  list need object so pass each loine data to object
            foreach(string data in beneficiary)
            {
                Beneficiary user=new Beneficiary(data);
                Beneficiary.userList.Add(user);
            }

            //vaccination file read and add to list
            string[] vaccine=File.ReadAllLines("Vaccine/VaccineAvailable.csv");

            foreach(string data1 in vaccine)
            {
                VaccineAvailable vaccine1=new VaccineAvailable(data1);
                VaccineAvailable.vaccineList.Add(vaccine1);
            }

            //vaccination
            string[] data2=File.ReadAllLines("Vaccine/Vaccination.csv");
            foreach(string data3 in data2 )
            {
                 Vaccination vaccine2=new Vaccination(data3);
                 Vaccination.vaccinationList.Add(vaccine2);

            }
            
           

           

        }
        //write files method 
        public static void WriteFiles()
        {
            //string array dec;aration
            string[] beneficiarydetails=new string[Beneficiary.userList.Count];
            //for adding string index by list elements of each object
            for(int i=0;i<Beneficiary.userList.Count;i++)
            {
                beneficiarydetails[i]=Beneficiary.userList[i].RegistrationNumber+","+Beneficiary.userList[i].Name+","+Beneficiary.userList[i].Gender+","+Beneficiary.userList[i].Age+","+Beneficiary.userList[i].MobileNumber+","+Beneficiary.userList[i].City;
            }
            File.WriteAllLines("Vaccine/Beneficiary.csv",beneficiarydetails);

            // writew for vaccine list
            string[] vaccineString =new string[VaccineAvailable.vaccineList.Count];
            for(int i=0;i<VaccineAvailable.vaccineList.Count;i++)
            {
                vaccineString[i]=VaccineAvailable.vaccineList[i].VaccineId+","+VaccineAvailable.vaccineList[i].VaccineName+","+VaccineAvailable.vaccineList[i].DosesAvailable;
            }
            File.WriteAllLines("Vaccine/VaccineAvailable.csv",vaccineString);

            //vaccination
            string[] vaccinationString=new string[Vaccination.vaccinationList.Count];
            for (int i=0;i<Vaccination.vaccinationList.Count;i++)
            {
                vaccinationString[i]=Vaccination.vaccinationList[i].VaccinationId+","+Vaccination.vaccinationList[i].VaccineId+","+Vaccination.vaccinationList[i].RegistrationNumber+","+Vaccination.vaccinationList[i].DoseNumber+","+Vaccination.vaccinationList[i].VaccinationDate;
            }
            File.WriteAllLines("Vaccine/Vaccination.csv",vaccinationString);

        }

    }
}