using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultiLevelInheritance
{
    public class EmploymentDetails:StudentDetails
    {
        private static int s_employmentId=1000;
        public string EmploymentId { get; set; }
        public DateTime DateOfRegn { get; set; }
        
        public EmploymentDetails(string studentId,string aid,string name,string fatherName,Gender gender,long phone,Department department,DateTime DateOfRegn):base( studentId, aid,name,fatherName,gender,phone,department)
        {
            s_employmentId++;
            EmploymentId="EID"+s_employmentId;
            DateOfRegn=DateTime.Now;
        }
        
        public void ShowEmploymentDetail()
        {
            System.Console.WriteLine("Employeement Id"+EmploymentId);
            ShowStudent();
            System.Console.WriteLine("Registraion date"+DateOfRegn.ToString("dd/MM/yyyy"));
        }
        
    }
}