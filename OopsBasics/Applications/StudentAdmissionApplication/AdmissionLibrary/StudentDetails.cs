using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdmissionLibrary
{
    public enum Gender{Default,Male,Female,TransGender};
    public class StudentDetails
    {
       // private string _name;//field declaration
        //public string Name { get{return _name;} set{name=value;} }
        private static int s_registernumber=3000;
        public string RegisterNumber{ get;  }
        
        
        public string Name { get; set; }//Auto property
        public string FatherName { get; set; }
        public DateTime DOB { get; set; }
        public Gender Gender { get; set; }
        public long Phone { get; set; }
        public string Mail { get; set; }
        public int Physics { get; set; }
        public int Chemistry { get; set; }
        public int Maths { get; set; }
      /*  public StudentDetails()//default constructor
        {
            Name="Your name";
            FatherName="Your Father name ";
        }*/
        public StudentDetails(string name,string fathername,DateTime dob,Gender gender,string mail,long phone,int physics,int chemistry,int maths)
        {
            s_registernumber++;
            RegisterNumber="SF"+s_registernumber;
            Name=name;
            FatherName=fathername;
            DOB=dob;
            Gender=gender;
            Mail=mail;
           Phone=phone;
           Chemistry=chemistry;
           Maths=maths;
           Physics=physics;
             /*Destructor
            ~Student details()
            {

            }*/

        }
        public bool CheckEligibility(double cutoff)
        {
            double average=(double)(Physics+Chemistry+Maths)/3.0;
            if(average>=cutoff)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    }
}