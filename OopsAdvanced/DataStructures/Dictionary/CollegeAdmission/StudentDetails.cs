using System;


namespace CollegeAdmission
{
    public class StudentDetails
    {
       // private string _name;//field declaration
        //public string Name { get{return _name;} set{name=value;} }
        
        public string Name { get; set; }//Auto property
        public string FatherName { get; set; }
        public DateTime DOB { get; set; }
        public string Gender { get; set; }
        public long Phone { get; set; }
        public string Mail { get; set; }
        public int Physics { get; set; }
        public int Chemistry { get; set; }
        public int Maths { get; set; }
        public StudentDetails()//default constructor
        {
            Name="Your name";
            FatherName="Your Father name ";
        }
        public StudentDetails(string name,string fathername,DateTime dob,string gender,string mail,long phone,int physics,int chemistry,int maths)
        {
            Name=name;
            FatherName=fathername;
            //DOB=dob;
            Gender=gender;
            Mail=mail;
           // Phone=phone;
           // Chemistry=chemistry;
           // Maths=maths;

        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    }
}