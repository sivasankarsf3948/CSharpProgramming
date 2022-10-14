using System;


namespace CollegeApplication
{
     public enum AdmissionStatus{Default,Booked,Cancelled} 
    public enum Gender{Default,Male,Female,TransGender}
    public class StudentDetails
    {
         private static int s_studentId=3000;
        public string StudentName { get; set; }
        public string FatherName { get; set; }
        public DateTime DOB { get; set; }
        public int Physics { get; set; }
        public int Chemistry { get; set; }
        public int  Maths { get; set; }

        public string StudentID { get;  }
        public Gender Gender { get; set; }
        
        




         //constructor
    public StudentDetails(string name,string fathername,DateTime dob,Gender gender,int physics,int chemistry,int maths)
    {
     s_studentId++;
     StudentID="SF"+s_studentId;
     StudentName=name;
     FatherName=fathername;
     DOB=dob;
     Gender=gender;
     Physics=physics;
     Chemistry=chemistry;
     Maths=maths;

    }

    public StudentDetails(string data)
    {
     string[] values=data.Split(",");
     s_studentId=int.Parse(values[0].Remove(0,2));
     StudentID=values[0];
     StudentName=values[1];
     FatherName=values[2];
      DOB=DateTime.Parse(values[3],null);
     Gender=Enum.Parse<Gender>(values[4]);
     Physics=int.Parse(values[5]);
     Chemistry=int.Parse(values[6]);
     Maths=int.Parse(values[7]);
    }

     public static void DefaultMethod()
     {
          Operations.studentList.Add(new StudentDetails("Ravi","Ettaparajan",new DateTime(1999,11,11),Gender.Male,95,95,95));
          Operations.studentList.Add(new StudentDetails("Baskaran","Sethurajan",new DateTime(1999,11,11),Gender.Male,95,95,95));
     }
    }

    
   
}