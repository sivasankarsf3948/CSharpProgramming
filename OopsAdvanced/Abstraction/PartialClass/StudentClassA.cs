using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartialClass
{
    public partial class StudentDetails
    {
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
        StudentDetails student=new StudentDetails()
    }
}