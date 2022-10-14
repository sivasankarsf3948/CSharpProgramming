using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employment
{
    public enum Gender{Default,Male,Female,TransGender}
    public class PersonalDetails
    {
        public static List <PersonalDetails> personList=new List<PersonalDetails>();
        public static int s_aadharId=1000;
        public string Name { get; set; }
        public string FatherName { get; set; }
        public Enum Gender { get; set; }
        public long Mobile { get; set; }
        public string AadharId { get; set; }
        
        
        
        
        
        public PersonalDetails(string name,string fatherName,Gender gender,long phone)
        {
            s_aadharId++;
            AadharId="AID"+s_aadharId;
            Name=name;
            FatherName=fatherName;
            Gender=gender;
            Mobile=phone;

        }
        
       /* public static void Default()
        {
           
            
             personList.Add(person);
        }*/
         
        
          //show details Method
          public static void ShowDetails()
          {
           foreach(PersonalDetails person in personList)
           {
            System.Console.WriteLine("Name        "+person.Name);
            System.Console.WriteLine("Father Name "+person.FatherName);
            System.Console.WriteLine("Aadhar Id   "+person.AadharId);
            System.Console.WriteLine("Gender      "+person.Gender);
            System.Console.WriteLine("Mobile      "+person.Mobile);

           }
          }
            
        
    }
}