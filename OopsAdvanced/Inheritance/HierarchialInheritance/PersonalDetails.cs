using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HierarchialInheritance
{
    public enum Gender{Default,Male,Female,TransGender}
    public class PersonalDetails
    {
      //  public static List <PersonalDetails> personList=new List<PersonalDetails>();
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
        
        public PersonalDetails(string aid,string name,string fatherName,Gender gender,long phone)
        {
           // AadharId=aid;
          //  s_aadharId++;
            AadharId=aid;
            Name=name;
            FatherName=fatherName;
            Gender=gender;
            Mobile=phone;

        }
         
        
          //show details Method
          public void ShowDetails()
          {
           
            System.Console.WriteLine("Name        "+Name);
            System.Console.WriteLine("Father Name "+FatherName);
            System.Console.WriteLine("Aadhar Id   "+AadharId);
            System.Console.WriteLine("Gender      "+Gender);
            System.Console.WriteLine("Mobile      "+Mobile);

          }
            
        
    }
}