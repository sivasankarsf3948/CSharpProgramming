using System;


namespace CollegeApplication
{
   
    public class AdmissionDetails
    {
        private static int s_admissionId=1000;
        public string AdmissionId { get;  }
        public string DepartmentId { get; set; }
        public DateTime AdmissionDate { get; set; }
        public AdmissionStatus AdmissionStatus { get; set; }
        public string StudentId { get; set; }
        
        
        
        
        
        public AdmissionDetails(string studentID,string departmentID,DateTime date,AdmissionStatus status)
        {
        s_admissionId++;
        AdmissionId="AID"+s_admissionId;
         StudentId=studentID;
         DepartmentId=departmentID;
         AdmissionDate=date;
         AdmissionStatus=AdmissionStatus.Booked;

        }
        
        
       //file constructor
       public AdmissionDetails(string value)
       {
        string[] value1=value.Split(',');
        AdmissionId=value1[0];
        StudentId=value1[1];
         DepartmentId=value1[2];
         AdmissionDate=DateTime.ParseExact(value1[3],"dd/MM/yyy",null);

         AdmissionStatus=AdmissionStatus.Booked;
        

       }
        
        
    }
}